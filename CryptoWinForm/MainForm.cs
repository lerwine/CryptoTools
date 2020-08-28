using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoWinForm
{
    public partial class MainForm : Form
    {
        private static readonly Regex BASE64_LINE = new Regex(@"^[A-Za-z\d+/]+$", RegexOptions.Compiled);
        private static readonly int DECODED_BUFFER_LENGTH = 5700;
        private static readonly int ENCODED_LINE_BLOCK_COUNT = 100;
        private X509CertSelection _selectedCert;
        private FileInfo _sourceFile = null;
        private DirectoryInfo _sourceDirectory;
        private FileInfo _targetFile = null;
        private DirectoryInfo _targetDirectory;
        private Encoding _selectedEncoding = Encoding.Unicode;
        private RSAEncryptionPadding _rsaEncryptionPadding = RSAEncryptionPadding.Pkcs1;
        private int _blockSize = 128;
        private int _asymmetricKeySize = 128;
        private CipherMode _asymmetricCipherMode = CipherMode.CBC;
        private PaddingMode _asymmetricPaddingMode = PaddingMode.PKCS7;
        private BindingList<KeyValuePair<String, Encoding>> _encodings = new BindingList<KeyValuePair<string, Encoding>>();
        private readonly UTF7Encoding _utf7;
        private Dictionary<int, KeyValuePair<String, Encoding>> _bomOption = new Dictionary<int, KeyValuePair<String, Encoding>>();
        private Dictionary<int, bool> _bomAlt = new Dictionary<int, bool>();

        public X509CertSelection SelectedCert
        {
            get { return _selectedCert; }
            set
            {
                if ((null == value) ? null == _selectedCert : null != _selectedCert && ReferenceEquals(_selectedCert, value))
                {
                    return;
                }
                _selectedCert = value;
                if (null == _selectedCert)
                {
                    certNameTextBox.Text = "";
                    certIssuedToValueLabel.Text = "";
                    certIssuedByValueLabel.Text = "";
                    certValidFromValueLabel.Text = "";
                    certValidToValueLabel.Text = "";
                    certAlgorithmValueLabel.Text = "";
                    certAltNamesHeadingLabel.Visible = false;
                    certAltNamesTextBox.Visible = false;
                    certUsagesHeadingLabel.Visible = false;
                    certUsagesTextBox.Visible = false;
                    publicKeyOverviewLabel.Visible = false;
                    publicKeyParametersValueLabel.Text = "";
                    publicKeyTextBox.Text = "";
                    certThumbprintTextBox.Text = "";
                    return;
                }
                X509Certificate2 cert = _selectedCert.Certificate;
                certNameTextBox.Text = _selectedCert.Name;
                certIssuedToValueLabel.Text = _selectedCert.IssuedTo;
                certIssuedByValueLabel.Text = _selectedCert.IssuedBy;
                certValidFromValueLabel.Text = _selectedCert.ValidFrom.ToString("D");
                certValidToValueLabel.Text = _selectedCert.ValidTo.ToString("D");
                certAlgorithmValueLabel.Text = _selectedCert.Algorithm;
                certAltNamesTextBox.Text = String.Join("\r\n", _selectedCert.AlternativeNameList.Select(kvp => String.Format("{0}={1}", kvp.Key, kvp.Value)).ToArray()).Trim();
                certUsagesTextBox.Text = String.Join("\r\n", _selectedCert.EnhancedUsages.Select(kvp => (kvp.Key == kvp.Value) ? kvp.Key : String.Format("{0} ({1})", kvp.Value, kvp.Key)).ToArray()).Trim();
                if (certAltNamesTextBox.Text.Length > 0 || certUsagesTextBox.Text.Length > 0)
                {
                    certAltNamesHeadingLabel.Visible = true;
                    certAltNamesTextBox.Visible = true;
                    certUsagesHeadingLabel.Visible = true;
                    certUsagesTextBox.Visible = true;
                }
                else
                {
                    certAltNamesHeadingLabel.Visible = false;
                    certAltNamesTextBox.Visible = false;
                    certUsagesHeadingLabel.Visible = false;
                    certUsagesTextBox.Visible = false;
                }
                publicKeyParametersValueLabel.Text = _selectedCert.Certificate.GetKeyAlgorithmParametersString();
                byte[] publicKey = cert.GetPublicKey();
                if (null == publicKey || publicKey.Length == 0)
                {
                    publicKeyTextBox.Text = "";
                    publicKeyOverviewLabel.Visible = false;
                }
                else
                {
                    publicKeyTextBox.Text = ParsedCertItem.BEGIN_CERTIFICATE_TEXT + Environment.NewLine + Convert.ToBase64String(publicKey, Base64FormattingOptions.InsertLineBreaks) + 
                        Environment.NewLine + ParsedCertItem.END_CERTIFICATE_TEXT;
                    publicKeyOverviewLabel.Visible = true;
                    if (String.IsNullOrWhiteSpace(_selectedCert.Algorithm))
                        publicKeyOverviewLabel.Text = String.Format("({0:d} Bits)", _selectedCert.PublicKeyBitLength);
                    else
                        publicKeyOverviewLabel.Text = String.Format("{0} ({1:d} Bits)", _selectedCert.Algorithm, _selectedCert.PublicKeyBitLength);
                    
                }
                certThumbprintTextBox.Text = _selectedCert.Thumbprint;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            Dictionary<int, KeyValuePair<String, Encoding>> dict = new Dictionary<int, KeyValuePair<string, Encoding>>();
            Encoding encoding = new UTF8Encoding(false, false);
            KeyValuePair<String, Encoding> item = new KeyValuePair<string, Encoding>("UTF-8", encoding);
            _encodings.Add(item);
            dict.Add(encoding.CodePage, item);
            _bomAlt.Add(encoding.CodePage, false);
            encoding = new UTF8Encoding(true, false);
            item = new KeyValuePair<string, Encoding>("UTF-8", encoding);
            _bomOption.Add(encoding.CodePage, item);

            encoding = new UnicodeEncoding(false, false, false);
            item = new KeyValuePair<string, Encoding>("Unicode", encoding);
            _encodings.Add(item);
            dict.Add(encoding.CodePage, item);
            _bomAlt.Add(encoding.CodePage, false);
            encoding = new UnicodeEncoding(false, true, false);
            item = new KeyValuePair<string, Encoding>("Unicode", encoding);
            _bomOption.Add(encoding.CodePage, item);

            encoding = new UnicodeEncoding(true, false, false);
            item = new KeyValuePair<string, Encoding>("Unicode (Big-Endian)", encoding);
            _encodings.Add(item);
            dict.Add(encoding.CodePage, item);
            _bomAlt.Add(encoding.CodePage, false);
            encoding = new UnicodeEncoding(true, true, false);
            item = new KeyValuePair<string, Encoding>("Unicode (Big-Endian)", encoding);
            _bomOption.Add(encoding.CodePage, item);

            item = new KeyValuePair<string, Encoding>(Encoding.ASCII.EncodingName, Encoding.ASCII);
            _encodings.Add(item);
            dict.Add(Encoding.ASCII.CodePage, item);

            _utf7 = new UTF7Encoding(true);
            item = new KeyValuePair<string, Encoding>("UTF-7", _utf7);
            _encodings.Add(item);
            dict.Add(_utf7.CodePage, item);
            _bomAlt.Add(_utf7.CodePage, false);
            encoding = new UTF7Encoding(false);
            item = new KeyValuePair<string, Encoding>("UTF-7", encoding);
            _bomOption.Add(encoding.CodePage, item);

            encoding = new UTF32Encoding(false, false, false);
            item = new KeyValuePair<string, Encoding>("UTF-32", encoding);
            _encodings.Add(item);
            dict.Add(encoding.CodePage, item);
            _bomAlt.Add(encoding.CodePage, false);
            encoding = new UTF32Encoding(false, true, false);
            item = new KeyValuePair<string, Encoding>("UTF-32", encoding);
            _bomOption.Add(encoding.CodePage, item);

            encoding = new UTF32Encoding(true, false, false);
            item = new KeyValuePair<string, Encoding>("UTF-32 (Big-Endian)", encoding);
            _encodings.Add(item);
            dict.Add(encoding.CodePage, item);
            _bomAlt.Add(encoding.CodePage, false);
            encoding = new UTF32Encoding(true, true, false);
            item = new KeyValuePair<string, Encoding>("UTF-32 (Big-Endian, with BOM)", encoding);
            _bomOption.Add(encoding.CodePage, item);

            foreach (EncodingInfo e in Encoding.GetEncodings())
            {
                encoding = e.GetEncoding();
                if (!dict.ContainsKey(e.CodePage))
                {
                    item = new KeyValuePair<string, Encoding>(e.DisplayName, encoding);
                    _encodings.Add(item);
                    dict.Add(e.CodePage, item);
                }
            }
            int codePage = Encoding.Default.CodePage;
            if (dict.ContainsKey(codePage))
            {
                item = dict[codePage];
                _encodings.Remove(item);
            }
            else
                item = new KeyValuePair<string, Encoding>(Encoding.Default.EncodingName, Encoding.Default);
            _encodings.Insert(0, item);
            encodingComboBox.DataSource = _encodings;
            encodingComboBox.SelectedItem = item;
            encodingComboBox_SelectedIndexChanged(encodingComboBox, EventArgs.Empty);
            encodingComboBox.SelectedIndexChanged += encodingComboBox_SelectedIndexChanged;
            bomCheckBox.CheckedChanged += bomCheckBox_CheckedChanged;
        }

        private void bomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, Encoding> item = (KeyValuePair<string, Encoding>)encodingComboBox.SelectedItem;
            _selectedEncoding = item.Value;
            if (_bomAlt.ContainsKey(_selectedEncoding.CodePage))
            {
                _bomAlt[_selectedEncoding.CodePage] = bomCheckBox.Checked;
                if (bomCheckBox.Checked)
                    _selectedEncoding = _bomOption[_selectedEncoding.CodePage].Value;
            }
        }

        private void encodingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, Encoding> item = (KeyValuePair<string, Encoding>)encodingComboBox.SelectedItem;
            _selectedEncoding = item.Value;
            if (_bomOption.ContainsKey(_selectedEncoding.CodePage))
            {
                bomCheckBox.Visible = true;
                if (ReferenceEquals(_selectedEncoding, _utf7))
                    bomCheckBox.Text = "No Optionals";
                else
                    bomCheckBox.Text = "Emit BOM";
                bomCheckBox.Checked = _bomAlt[_selectedEncoding.CodePage];
                if (bomCheckBox.Checked)
                    _selectedEncoding = _bomOption[_selectedEncoding.CodePage].Value;
            }
            else
                bomCheckBox.Visible = false;
        }

        private void openCertFileButton_Click(object sender, EventArgs e)
        {
            if (openCertificateDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = openCertificateDialog.FileName;
                if (null == (fileName = CertFileItem.TryCreate(fileName, out CertFileItem result)))
                    SelectedCert = result;
                else
                    MessageBox.Show(this, fileName, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void selectCertButton_Click(object sender, EventArgs e)
        {
            using (OpenFromCertStoreForm form = new OpenFromCertStoreForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    SelectedCert = form.SelectedCert;
            }
        }

        private void certFromClipboardButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                switch (ParsedCertItem.TryCreate(Clipboard.GetText(), out ParsedCertItem cert))
                {
                    case ParsedCertItem.ParseResult.Success:
                        SelectedCert = cert;
                        return;
                    case ParsedCertItem.ParseResult.Base64DecodeError:
                        MessageBox.Show(this, "Clipboard does not contain valid base-64 encoded data.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    case ParsedCertItem.ParseResult.CertificateLoadErr:
                        MessageBox.Show(this, "Cannot create certificate from decoded data.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
            }
            MessageBox.Show(this, "Clipboard does not contain base-64 encoded text.", "No Certificate", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mainTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (null != e.TabPage && !ReferenceEquals(e.TabPage, certificateTabPage) && null == _selectedCert)
            {
                MessageBox.Show(this, "You must open or select a certificate, first.", "No Certificate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void UpdateFromFileTextBoxes()
        {
            String path = sourceFileTextBox.Text.Trim();
            if (path.Length == 0)
                _sourceFile = null;
            else if (null == _sourceFile || _sourceFile.FullName != path)
            {
                _sourceFile = null;
                try
                {
                    _sourceFile = new FileInfo(path);
                    if (_sourceFile.Directory.Exists)
                        _sourceDirectory = _sourceFile.Directory;
                }
                catch { }
            }
            path = targetFileTextBox.Text.Trim();
            if (path.Length == 0)
                _targetFile = null;
            else if (path.Length > 0 && (null == _targetFile || _targetFile.FullName != path))
            {
                _targetFile = null;
                try
                {
                    _targetFile = new FileInfo(path);
                    if (_targetFile.Directory.Exists)
                        _targetDirectory = _targetFile.Directory;
                }
                catch { }
            }
        }
        private void sourceFileBrowseButton_Click(object sender, EventArgs e)
        {
            UpdateFromFileTextBoxes();
            if (null != _sourceDirectory)
                openSourceFileDialog.InitialDirectory = _sourceDirectory.FullName;
            else if (null != _targetDirectory)
                openSourceFileDialog.InitialDirectory = _targetDirectory.FullName;
            else
                openSourceFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (null != _sourceFile)
                openSourceFileDialog.FileName = _sourceFile.Name;
            if (openSourceFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                _sourceFile = new FileInfo(openSourceFileDialog.FileName);
                _sourceDirectory = _sourceFile.Directory;
                sourceFileTextBox.Text = _sourceFile.FullName;
            }
        }

        private void targetFileBrowseButton_Click(object sender, EventArgs e)
        {
            UpdateFromFileTextBoxes();
            if (null != _targetDirectory)
                saveTargetFileDialog.InitialDirectory = _targetDirectory.FullName;
            else if (null != _sourceDirectory)
                saveTargetFileDialog.InitialDirectory = _sourceDirectory.FullName;
            else
                saveTargetFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (null != _targetFile)
                saveTargetFileDialog.FileName = _targetFile.Name;
            else if (null != _sourceFile)
            {
                String n = Path.GetFileNameWithoutExtension(_sourceFile.Name);
                FileInfo f = new FileInfo(Path.Combine(saveTargetFileDialog.InitialDirectory, n + ".txt"));
                if (f.Exists)
                {
                    int i = 0;
                    do
                    {
                        f = new FileInfo(Path.Combine(saveTargetFileDialog.InitialDirectory, String.Format("{0}-{1}.txt", n, ++i)));
                    } while (f.Exists);
                }
                saveTargetFileDialog.FileName = f.Name;
            }
            if (saveTargetFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                _targetFile = new FileInfo(saveTargetFileDialog.FileName);
                _targetDirectory = _targetFile.Directory;
                targetFileTextBox.Text = _targetFile.FullName;
            }
        }

        private bool ValidateFileTextBoxes(out FileInfo sourceFile, out FileInfo targetFile)
        {
            UpdateFromFileTextBoxes();
            if (null == (sourceFile = _sourceFile))
            {
                MessageBox.Show(this, "Source file not specified.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                targetFile = null;
                return false;
            }
            if (null == (targetFile = _targetFile))
            {
                MessageBox.Show(this, "Target file not specified.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sourceFile = null;
                return false;
            }
            if (!sourceFile.Exists)
            {
                sourceFile.Refresh();
                if (!sourceFile.Exists)
                {
                    MessageBox.Show(this, "Source file not found.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sourceFile = targetFile = null;
                    return false;
                }
            }

            if (targetFile.Exists)
            {
                if (MessageBox.Show(this, "Target file already exists.\r\n\r\nOverwrite?", "File not found", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                {
                    targetFile = null;
                    return false;
                }
            }
            else if (!targetFile.Directory.Exists)
            {
                MessageBox.Show(this, "The parent directory for the target file was not found.", "Directory not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                targetFile = null;
                return false;
            }
            return true;
        }

        private void decryptFileButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFileTextBoxes(out FileInfo sourceFile, out FileInfo targetFile))
                return;

            X509Certificate2 cert;
            if (null == _selectedCert)
            {
                MessageBox.Show(this, "No data encryption certificate has been selected.", "No Certificate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cert = _selectedCert.Certificate;
            RSA pk;
            try { pk = cert.GetRSAPrivateKey(); }
            catch { pk = null; }
            if (null == pk)
            {
                MessageBox.Show(this, "Unable to get an RSA private key from the selected certificate.", "No Private Encryption Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long totalBytes = 0L;
            try
            {
                using (TempFile tempFile = new TempFile())
                {
                    using (StreamReader reader = sourceFile.OpenText())
                    {
                        using (Base64LineReader bReader = new Base64LineReader(reader))
                        {
                            byte[] buffer = bReader.getNext();
                            if (null != buffer)
                            {
                                using (FileStream stream = tempFile.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite))
                                {
                                    do
                                    {
                                        stream.Write(buffer, 0, buffer.Length);
                                    }
                                    while (null != (buffer = bReader.getNext()));
                                    stream.Flush();
                                }
                            }
                        }
                    }
                    using (FileStream inputStream = tempFile.Open(FileMode.Open, FileAccess.Read))
                    {
                        // TODO: Need to base-64 decode to a temp file, first
                        using (FileStream outputStream = targetFile.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite))
                            totalBytes = Decrypt(pk, inputStream, outputStream);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(this, String.Format("An unexpected error has occurred.\r\n\r\n{0}", exc.ToString()), "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, String.Format("{0} bytes decrypted from {1}", totalBytes, sourceFile.FullName), "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void encryptFileButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFileTextBoxes(out FileInfo sourceFile, out FileInfo targetFile))
                return;

            X509Certificate2 cert;
            if (null == _selectedCert)
            {
                MessageBox.Show(this, "No data encryption certificate has been selected.", "No Certificate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cert = _selectedCert.Certificate;
            RSA pk;
            try { pk = cert.GetRSAPublicKey(); }
            catch { pk = null; }
            if (null == pk)
            {
                MessageBox.Show(this, "Unable to get an RSA public key from the selected certificate.", "No Public Encryption Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long totalBytes = 0L;
            try
            {
                using (FileStream inputStream = sourceFile.Open(FileMode.Open, FileAccess.Read))
                {
                    // TODO: Need to write to a temp file, first, then base-64 encode
                    using (FileStream outputStream = targetFile.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite))
                        totalBytes = Encrypt(pk, inputStream, outputStream);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(this, String.Format("An unexpected error has occurred.\r\n\r\n{0}", exc.ToString()), "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, String.Format("{0} bytes encrypted to {1}", totalBytes, targetFile.FullName), "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textEncryptButton_Click(object sender, EventArgs e)
        {
            String text = textInputTextBox.Text;
            if (text.Length == 0)
            {
                MessageBox.Show(this, "No text to encrypt.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            X509Certificate2 cert;
            if (null == _selectedCert)
            {
                MessageBox.Show(this, "No data encryption certificate has been selected.", "No Certificate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cert = _selectedCert.Certificate;
            RSA pk;
            try { pk = cert.GetRSAPublicKey(); }
            catch { pk = null; }
            if (null == pk)
            {
                MessageBox.Show(this, "Unable to get an RSA public key from the selected certificate.", "No Public Encryption Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MemoryStream inputStream = new MemoryStream(_selectedEncoding.GetBytes(text)))
                {
                    using (MemoryStream outputStream = new MemoryStream())
                    {
                        Encrypt(pk, inputStream, outputStream);
                        textOutputTextBox.Text = Convert.ToBase64String(outputStream.ToArray(), Base64FormattingOptions.InsertLineBreaks);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(this, String.Format("An unexpected error has occurred.\r\n\r\n{0}", exc.ToString()), "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textEncryptionTabControl.SelectedTab = textOutputTabPage;
        }

        private void textDecryptButton_Click(object sender, EventArgs e)
        {
            String text = textInputTextBox.Text.Trim();
            if (text.Length == 0)
            {
                MessageBox.Show(this, "No text to decrypt.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            X509Certificate2 cert;
            if (null == _selectedCert)
            {
                MessageBox.Show(this, "No data encryption certificate has been selected.", "No Certificate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cert = _selectedCert.Certificate;
            RSA pk;
            try { pk = cert.GetRSAPublicKey(); }
            catch { pk = null; }
            if (null == pk)
            {
                MessageBox.Show(this, "Unable to get an RSA public key from the selected certificate.", "No Public Encryption Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MemoryStream inputStream = new MemoryStream(Convert.FromBase64String(text)))
                {
                    using (MemoryStream outputStream = new MemoryStream())
                    {
                        Decrypt(pk, inputStream, outputStream);
                        textOutputTextBox.Text = _selectedEncoding.GetString(outputStream.ToArray());
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(this, String.Format("An unexpected error has occurred.\r\n\r\n{0}", exc.ToString()), "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textEncryptionTabControl.SelectedTab = textOutputTabPage;
        }

        private long Encrypt(RSA pk, Stream inputStream, Stream outputStream)
        {
            long totalBytes;
            using (AesManaged aesManaged = new AesManaged())
            {
                aesManaged.BlockSize = _blockSize;
                aesManaged.Mode = _asymmetricCipherMode;
                aesManaged.Padding = _asymmetricPaddingMode;
                aesManaged.KeySize = _asymmetricKeySize;
                totalBytes = WriteLengthEncodedBytes(outputStream, aesManaged.IV);
                byte[] encryptedKey = pk.Encrypt(aesManaged.Key, _rsaEncryptionPadding);
                totalBytes += WriteLengthEncodedBytes(outputStream, encryptedKey);
                using (ICryptoTransform transform = aesManaged.CreateEncryptor())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(outputStream, transform, CryptoStreamMode.Write))
                    {
                        byte[] block = new byte[aesManaged.BlockSize];
                        for (int i = inputStream.Read(block, 0, block.Length); i > 0; i = inputStream.Read(block, 0, block.Length))
                        {
                            cryptoStream.Write(block, 0, i);
                            totalBytes += (long)i;
                        }
                        cryptoStream.Flush();
                        outputStream.Flush();
                    }
                }
            }

            return totalBytes;
        }

        private long Decrypt(RSA pk, Stream inputStream, Stream outputStream)
        {
            long totalBytes;
            using (AesManaged aesManaged = new AesManaged())
            {
                aesManaged.BlockSize = _blockSize;
                aesManaged.Mode = _asymmetricCipherMode;
                aesManaged.Padding = _asymmetricPaddingMode;
                aesManaged.KeySize = _asymmetricKeySize;
                byte[] key;
                totalBytes = ReadLengthEncodedBytes(inputStream, out key);
                aesManaged.IV = key;
                totalBytes += ReadLengthEncodedBytes(inputStream, out key);
                aesManaged.Key = pk.Decrypt(aesManaged.Key, _rsaEncryptionPadding);
                using (ICryptoTransform transform = aesManaged.CreateDecryptor())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(inputStream, transform, CryptoStreamMode.Read))
                    {
                        byte[] block = new byte[aesManaged.BlockSize];
                        for (int i = cryptoStream.Read(block, 0, block.Length); i > 0; i = cryptoStream.Read(block, 0, block.Length))
                        {
                            outputStream.Write(block, 0, i);
                            totalBytes += (long)i;
                        }
                        outputStream.Flush();
                    }
                }
            }

            return totalBytes;
        }

        private long WriteLengthEncodedBytes(Stream stream, byte[] buffer)
        {
            long count = WriteInteger(stream, buffer.Length);
            if (buffer.Length > 0)
                stream.Write(buffer, 0, buffer.Length);
            return count + (long)buffer.Length;
        }

        private long ReadLengthEncodedBytes(Stream stream, out byte[] output)
        {
            if (stream == null)
                throw new ArgumentNullException("inputStream");

            int length;
            long count = ReadInteger(stream, out length);
            if (length < 0)
                throw new InvalidOperationException("Invalid length");

            output = new byte[length];
            if (length > 0 && stream.Read(output, 0, length) != length)
                throw new InvalidOperationException("Unexpected end of stream");
            return count + (long)output.Length;
        }

        public static int ReadInteger(Stream stream, out int result)
        {
            if (stream == null)
                throw new ArgumentNullException("inputStream");

            byte[] buffer = new byte[sizeof(int)];
            if (stream.Read(buffer, 0, buffer.Length) != buffer.Length)
                throw new InvalidOperationException("Unexpected end of stream");

            result = BitConverter.ToInt32(buffer, 0);
            return buffer.Length;
        }

        public static int WriteInteger(Stream stream, int value)
        {
            if (stream == null)
                throw new ArgumentNullException("outputStream");
            byte[] buffer = BitConverter.GetBytes(value);
            stream.Write(buffer, 0, buffer.Length);
            return buffer.Length;
        }

    }
}
