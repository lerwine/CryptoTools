namespace CryptoWinForm
{
    partial class OpenFromCertStoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.storeNameComboBox = new System.Windows.Forms.ComboBox();
            this.storeLocationComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.storeCertsDataGridView = new System.Windows.Forms.DataGridView();
            this.showAllCheckBox = new System.Windows.Forms.CheckBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usagesDisplayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algorithmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thumbprintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTableLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeCertsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.label2, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.storeNameComboBox, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.storeLocationComboBox, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.storeCertsDataGridView, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.showAllCheckBox, 2, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location";
            // 
            // storeNameComboBox
            // 
            this.storeNameComboBox.DisplayMember = "Display";
            this.storeNameComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.storeNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeNameComboBox.FormattingEnabled = true;
            this.storeNameComboBox.Location = new System.Drawing.Point(3, 16);
            this.storeNameComboBox.Name = "storeNameComboBox";
            this.storeNameComboBox.Size = new System.Drawing.Size(357, 21);
            this.storeNameComboBox.TabIndex = 2;
            this.storeNameComboBox.ValueMember = "Value";
            // 
            // storeLocationComboBox
            // 
            this.storeLocationComboBox.DisplayMember = "Display";
            this.storeLocationComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.storeLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeLocationComboBox.FormattingEnabled = true;
            this.storeLocationComboBox.Location = new System.Drawing.Point(366, 16);
            this.storeLocationComboBox.Name = "storeLocationComboBox";
            this.storeLocationComboBox.Size = new System.Drawing.Size(357, 21);
            this.storeLocationComboBox.TabIndex = 3;
            this.storeLocationComboBox.ValueMember = "Value";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.mainTableLayoutPanel.SetColumnSpan(this.flowLayoutPanel1, 3);
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.Controls.Add(this.okButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 418);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 29);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(716, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(635, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // storeCertsDataGridView
            // 
            this.storeCertsDataGridView.AllowUserToAddRows = false;
            this.storeCertsDataGridView.AllowUserToDeleteRows = false;
            this.storeCertsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeCertsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.usagesDisplayDataGridViewTextBoxColumn,
            this.issuedToDataGridViewTextBoxColumn,
            this.issuedByDataGridViewTextBoxColumn,
            this.validFromDataGridViewTextBoxColumn,
            this.validToDataGridViewTextBoxColumn,
            this.algorithmDataGridViewTextBoxColumn,
            this.serialNumberDataGridViewTextBoxColumn,
            this.thumbprintDataGridViewTextBoxColumn});
            this.mainTableLayoutPanel.SetColumnSpan(this.storeCertsDataGridView, 3);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storeCertsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.storeCertsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeCertsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.storeCertsDataGridView.Location = new System.Drawing.Point(3, 43);
            this.storeCertsDataGridView.MultiSelect = false;
            this.storeCertsDataGridView.Name = "storeCertsDataGridView";
            this.storeCertsDataGridView.ReadOnly = true;
            this.storeCertsDataGridView.RowHeadersVisible = false;
            this.storeCertsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.storeCertsDataGridView.ShowEditingIcon = false;
            this.storeCertsDataGridView.Size = new System.Drawing.Size(794, 369);
            this.storeCertsDataGridView.TabIndex = 5;
            this.storeCertsDataGridView.SelectionChanged += new System.EventHandler(this.storeCertsDataGridView_SelectionChanged);
            // 
            // showAllCheckBox
            // 
            this.showAllCheckBox.AutoSize = true;
            this.showAllCheckBox.Location = new System.Drawing.Point(729, 3);
            this.showAllCheckBox.Name = "showAllCheckBox";
            this.mainTableLayoutPanel.SetRowSpan(this.showAllCheckBox, 2);
            this.showAllCheckBox.Size = new System.Drawing.Size(67, 17);
            this.showAllCheckBox.TabIndex = 6;
            this.showAllCheckBox.Text = "Show All";
            this.showAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // usagesDisplayDataGridViewTextBoxColumn
            // 
            this.usagesDisplayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usagesDisplayDataGridViewTextBoxColumn.DataPropertyName = "UsagesDisplay";
            this.usagesDisplayDataGridViewTextBoxColumn.HeaderText = "Usages";
            this.usagesDisplayDataGridViewTextBoxColumn.Name = "usagesDisplayDataGridViewTextBoxColumn";
            this.usagesDisplayDataGridViewTextBoxColumn.ReadOnly = true;
            this.usagesDisplayDataGridViewTextBoxColumn.Width = 68;
            // 
            // issuedToDataGridViewTextBoxColumn
            // 
            this.issuedToDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issuedToDataGridViewTextBoxColumn.DataPropertyName = "IssuedTo";
            this.issuedToDataGridViewTextBoxColumn.HeaderText = "Issued To";
            this.issuedToDataGridViewTextBoxColumn.Name = "issuedToDataGridViewTextBoxColumn";
            this.issuedToDataGridViewTextBoxColumn.ReadOnly = true;
            this.issuedToDataGridViewTextBoxColumn.Width = 79;
            // 
            // issuedByDataGridViewTextBoxColumn
            // 
            this.issuedByDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issuedByDataGridViewTextBoxColumn.DataPropertyName = "IssuedBy";
            this.issuedByDataGridViewTextBoxColumn.HeaderText = "Issued By";
            this.issuedByDataGridViewTextBoxColumn.Name = "issuedByDataGridViewTextBoxColumn";
            this.issuedByDataGridViewTextBoxColumn.ReadOnly = true;
            this.issuedByDataGridViewTextBoxColumn.Width = 78;
            // 
            // validFromDataGridViewTextBoxColumn
            // 
            this.validFromDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.validFromDataGridViewTextBoxColumn.DataPropertyName = "ValidFrom";
            this.validFromDataGridViewTextBoxColumn.HeaderText = "Valid From";
            this.validFromDataGridViewTextBoxColumn.Name = "validFromDataGridViewTextBoxColumn";
            this.validFromDataGridViewTextBoxColumn.ReadOnly = true;
            this.validFromDataGridViewTextBoxColumn.Width = 81;
            // 
            // validToDataGridViewTextBoxColumn
            // 
            this.validToDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.validToDataGridViewTextBoxColumn.DataPropertyName = "ValidTo";
            this.validToDataGridViewTextBoxColumn.HeaderText = "Valid  To";
            this.validToDataGridViewTextBoxColumn.Name = "validToDataGridViewTextBoxColumn";
            this.validToDataGridViewTextBoxColumn.ReadOnly = true;
            this.validToDataGridViewTextBoxColumn.Width = 74;
            // 
            // algorithmDataGridViewTextBoxColumn
            // 
            this.algorithmDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.algorithmDataGridViewTextBoxColumn.DataPropertyName = "Algorithm";
            this.algorithmDataGridViewTextBoxColumn.HeaderText = "Algorithm";
            this.algorithmDataGridViewTextBoxColumn.Name = "algorithmDataGridViewTextBoxColumn";
            this.algorithmDataGridViewTextBoxColumn.ReadOnly = true;
            this.algorithmDataGridViewTextBoxColumn.Width = 75;
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "SerialNumber";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "SN";
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            this.serialNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialNumberDataGridViewTextBoxColumn.Width = 47;
            // 
            // thumbprintDataGridViewTextBoxColumn
            // 
            this.thumbprintDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.thumbprintDataGridViewTextBoxColumn.DataPropertyName = "Thumbprint";
            this.thumbprintDataGridViewTextBoxColumn.HeaderText = "Thumbprint";
            this.thumbprintDataGridViewTextBoxColumn.Name = "thumbprintDataGridViewTextBoxColumn";
            this.thumbprintDataGridViewTextBoxColumn.ReadOnly = true;
            this.thumbprintDataGridViewTextBoxColumn.Width = 85;
            // 
            // OpenFromCertStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "OpenFromCertStoreForm";
            this.Text = "Select Certificate";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storeCertsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox storeNameComboBox;
        private System.Windows.Forms.ComboBox storeLocationComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridView storeCertsDataGridView;
        private System.Windows.Forms.CheckBox showAllCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usagesDisplayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn algorithmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thumbprintDataGridViewTextBoxColumn;
    }
}