using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoWinForm
{
    public partial class OpenFromCertStoreForm : Form
    {
        private BindingList<X509CertStoreItem> _storeCerts = new BindingList<X509CertStoreItem>();
        private X509CertStoreItem _selectedCert;

        internal X509CertStoreItem SelectedCert { get => _selectedCert; }

        public OpenFromCertStoreForm() : this(StoreName.My, StoreLocation.CurrentUser) { }

        public OpenFromCertStoreForm(StoreName storeName, StoreLocation storeLocation)
        {
            InitializeComponent();
            foreach (StoreName n in Enum.GetValues(typeof(StoreName)))
                storeNameComboBox.Items.Add(new EnumItem<StoreName>(n, null));
            storeNameComboBox.SelectedItem = storeNameComboBox.Items.Cast<EnumItem<StoreName>>().First(i => i.Value == storeName);
            foreach (StoreLocation n in Enum.GetValues(typeof(StoreLocation)))
                storeLocationComboBox.Items.Add(new EnumItem<StoreLocation>(n, null));
            storeLocationComboBox.SelectedItem = storeLocationComboBox.Items.Cast<EnumItem<StoreLocation>>().First(i => i.Value == storeLocation);
            storeControl_SelectionChanged(storeLocationComboBox, EventArgs.Empty);
            storeCertsDataGridView.AutoGenerateColumns = false;
            storeCertsDataGridView.DataSource = _storeCerts;
            storeCertsDataGridView_SelectionChanged(storeCertsDataGridView, EventArgs.Empty);
            storeNameComboBox.SelectedIndexChanged += storeControl_SelectionChanged;
            storeLocationComboBox.SelectedIndexChanged += storeControl_SelectionChanged;
            showAllCheckBox.CheckedChanged += storeControl_SelectionChanged;
            storeCertsDataGridView.SelectionChanged += storeCertsDataGridView_SelectionChanged;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (storeCertsDataGridView.SelectedRows.Count > 0)
            {
                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void storeControl_SelectionChanged(object sender, EventArgs e)
        {
            storeCertsDataGridView.ClearSelection();
            StoreName storeName = ((EnumItem<StoreName>)storeNameComboBox.SelectedItem).Value;
            StoreLocation storeLocation = ((EnumItem<StoreLocation>)storeLocationComboBox.SelectedItem).Value;
            using (X509Store currentStore = new X509Store(storeName, storeLocation))
            {
                currentStore.Open(OpenFlags.ReadOnly);
                _storeCerts.Clear();
                IEnumerable<X509CertStoreItem> items = currentStore.Certificates.OfType<X509Certificate2>().Select(c => new X509CertStoreItem(c, storeName, storeLocation));
                if (!showAllCheckBox.Checked)
                {
                    // CN=*.pipe.aria.microsoft.com, O=DO_NOT_TRUST, OU=Created by http://www.fiddler2.com	CN=DO_NOT_TRUST_FiddlerRoot, O=DO_NOT_TRUST, OU=Created by http://www.fiddler2.com	*.pipe.aria.microsoft.com	Data encryption, Key encryption, Digital signature, Server Authentication	9/10/2017 6:44 AM	9/10/2023 6:44 AM	RSA	737554FDD9549DBA42C2090157C7B7B0	FFE6A2E3DB343DFA43C8FF2138B4FED220B22DD9
                    X509KeyUsageFlags f = X509KeyUsageFlags.DataEncipherment | X509KeyUsageFlags.DecipherOnly | X509KeyUsageFlags.EncipherOnly | X509KeyUsageFlags.KeyEncipherment;
                    items = items.Where(c => ((c.KeyUsages & f) != X509KeyUsageFlags.None) && !c.IssuedBy.StartsWith("CN=DO_NOT_TRUST_FiddlerRoot,"));
                }
                foreach (X509CertStoreItem i in items)
                    _storeCerts.Add(i);
                currentStore.Close();
            }
        }

        private void storeCertsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (storeCertsDataGridView.SelectedRows.Count > 0)
            {
                okButton.Enabled = true;
                _selectedCert = (X509CertStoreItem)storeCertsDataGridView.SelectedRows[0].DataBoundItem;
            }
            else
            {
                _selectedCert = null;
                okButton.Enabled = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _selectedCert = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
