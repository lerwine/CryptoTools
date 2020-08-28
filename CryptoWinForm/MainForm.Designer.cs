namespace CryptoWinForm
{
    partial class MainForm
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.certificateTabPage = new System.Windows.Forms.TabPage();
            this.certificateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.certFriendlyNameHeadingLabel = new System.Windows.Forms.Label();
            this.certNameTextBox = new System.Windows.Forms.TextBox();
            this.certIssuedToHeadingLabel = new System.Windows.Forms.Label();
            this.certIssuedToValueLabel = new System.Windows.Forms.Label();
            this.certValidFromHeadingLabel = new System.Windows.Forms.Label();
            this.certAlgorithmHeadingLabel = new System.Windows.Forms.Label();
            this.certIssuedByHeadingLabel = new System.Windows.Forms.Label();
            this.certAltNamesHeadingLabel = new System.Windows.Forms.Label();
            this.certUsagesHeadingLabel = new System.Windows.Forms.Label();
            this.certhThumbprintHeadingLabel = new System.Windows.Forms.Label();
            this.certThumbprintTextBox = new System.Windows.Forms.TextBox();
            this.publicKeyGroupBox = new System.Windows.Forms.GroupBox();
            this.publicKeyTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.publicKeyOverviewLabel = new System.Windows.Forms.Label();
            this.publicKeyParametersHeadingLabel = new System.Windows.Forms.Label();
            this.publicKeyParametersValueLabel = new System.Windows.Forms.Label();
            this.publicKeyTextBox = new System.Windows.Forms.TextBox();
            this.buttonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.openCertFileButton = new System.Windows.Forms.Button();
            this.selectCertButton = new System.Windows.Forms.Button();
            this.certFromClipboardButton = new System.Windows.Forms.Button();
            this.certAlgorithmValueLabel = new System.Windows.Forms.Label();
            this.certIssuedByValueLabel = new System.Windows.Forms.Label();
            this.certAltNamesTextBox = new System.Windows.Forms.TextBox();
            this.certUsagesTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.certValidFromValueLabel = new System.Windows.Forms.Label();
            this.certValidToHeadingLabel = new System.Windows.Forms.Label();
            this.certValidToValueLabel = new System.Windows.Forms.Label();
            this.fileEncryptionTabPage = new System.Windows.Forms.TabPage();
            this.fileEncryptionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sourceFileLabel = new System.Windows.Forms.Label();
            this.sourceFileTextBox = new System.Windows.Forms.TextBox();
            this.sourceFileBrowseButton = new System.Windows.Forms.Button();
            this.targetFileLabel = new System.Windows.Forms.Label();
            this.targetFileTextBox = new System.Windows.Forms.TextBox();
            this.targetFileBrowseButton = new System.Windows.Forms.Button();
            this.fileEncryptionFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.decryptFileButton = new System.Windows.Forms.Button();
            this.encryptFileButton = new System.Windows.Forms.Button();
            this.fileCryptoResultLabel = new System.Windows.Forms.Label();
            this.textEncryptionTabPage = new System.Windows.Forms.TabPage();
            this.textEncryptionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textEncryptionActionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textDecryptButton = new System.Windows.Forms.Button();
            this.textEncryptButton = new System.Windows.Forms.Button();
            this.textEncodingLabel = new System.Windows.Forms.Label();
            this.encodingComboBox = new System.Windows.Forms.ComboBox();
            this.bomCheckBox = new System.Windows.Forms.CheckBox();
            this.textEncryptionTabControl = new System.Windows.Forms.TabControl();
            this.textInputTabPage = new System.Windows.Forms.TabPage();
            this.textInputTextBox = new System.Windows.Forms.TextBox();
            this.textOutputTabPage = new System.Windows.Forms.TabPage();
            this.textOutputTextBox = new System.Windows.Forms.TextBox();
            this.openCertificateDialog = new System.Windows.Forms.OpenFileDialog();
            this.openSourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveTargetFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainTabControl.SuspendLayout();
            this.certificateTabPage.SuspendLayout();
            this.certificateTableLayoutPanel.SuspendLayout();
            this.publicKeyGroupBox.SuspendLayout();
            this.publicKeyTableLayoutPanel.SuspendLayout();
            this.buttonsFlowLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.fileEncryptionTabPage.SuspendLayout();
            this.fileEncryptionTableLayoutPanel.SuspendLayout();
            this.fileEncryptionFlowLayoutPanel.SuspendLayout();
            this.textEncryptionTabPage.SuspendLayout();
            this.textEncryptionTableLayoutPanel.SuspendLayout();
            this.textEncryptionActionTableLayoutPanel.SuspendLayout();
            this.textEncryptionTabControl.SuspendLayout();
            this.textInputTabPage.SuspendLayout();
            this.textOutputTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.certificateTabPage);
            this.mainTabControl.Controls.Add(this.fileEncryptionTabPage);
            this.mainTabControl.Controls.Add(this.textEncryptionTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(800, 450);
            this.mainTabControl.TabIndex = 1;
            this.mainTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.mainTabControl_Selecting);
            // 
            // certificateTabPage
            // 
            this.certificateTabPage.Controls.Add(this.certificateTableLayoutPanel);
            this.certificateTabPage.Location = new System.Drawing.Point(4, 22);
            this.certificateTabPage.Name = "certificateTabPage";
            this.certificateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.certificateTabPage.Size = new System.Drawing.Size(792, 424);
            this.certificateTabPage.TabIndex = 0;
            this.certificateTabPage.Text = "Certificate";
            this.certificateTabPage.UseVisualStyleBackColor = true;
            // 
            // certificateTableLayoutPanel
            // 
            this.certificateTableLayoutPanel.AutoSize = true;
            this.certificateTableLayoutPanel.ColumnCount = 4;
            this.certificateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.certificateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.certificateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.certificateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.certificateTableLayoutPanel.Controls.Add(this.certFriendlyNameHeadingLabel, 0, 0);
            this.certificateTableLayoutPanel.Controls.Add(this.certNameTextBox, 1, 0);
            this.certificateTableLayoutPanel.Controls.Add(this.certIssuedToHeadingLabel, 0, 1);
            this.certificateTableLayoutPanel.Controls.Add(this.certIssuedToValueLabel, 1, 1);
            this.certificateTableLayoutPanel.Controls.Add(this.certValidFromHeadingLabel, 0, 2);
            this.certificateTableLayoutPanel.Controls.Add(this.certAlgorithmHeadingLabel, 2, 2);
            this.certificateTableLayoutPanel.Controls.Add(this.certIssuedByHeadingLabel, 2, 1);
            this.certificateTableLayoutPanel.Controls.Add(this.certAltNamesHeadingLabel, 0, 3);
            this.certificateTableLayoutPanel.Controls.Add(this.certUsagesHeadingLabel, 2, 3);
            this.certificateTableLayoutPanel.Controls.Add(this.certhThumbprintHeadingLabel, 2, 4);
            this.certificateTableLayoutPanel.Controls.Add(this.certThumbprintTextBox, 3, 4);
            this.certificateTableLayoutPanel.Controls.Add(this.publicKeyGroupBox, 0, 4);
            this.certificateTableLayoutPanel.Controls.Add(this.buttonsFlowLayoutPanel, 2, 5);
            this.certificateTableLayoutPanel.Controls.Add(this.certAlgorithmValueLabel, 3, 1);
            this.certificateTableLayoutPanel.Controls.Add(this.certIssuedByValueLabel, 3, 2);
            this.certificateTableLayoutPanel.Controls.Add(this.certAltNamesTextBox, 1, 3);
            this.certificateTableLayoutPanel.Controls.Add(this.certUsagesTextBox, 3, 3);
            this.certificateTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.certificateTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.certificateTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.certificateTableLayoutPanel.Name = "certificateTableLayoutPanel";
            this.certificateTableLayoutPanel.RowCount = 6;
            this.certificateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.certificateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.certificateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.certificateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.certificateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.certificateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.certificateTableLayoutPanel.Size = new System.Drawing.Size(786, 418);
            this.certificateTableLayoutPanel.TabIndex = 0;
            // 
            // certFriendlyNameHeadingLabel
            // 
            this.certFriendlyNameHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.certFriendlyNameHeadingLabel.AutoSize = true;
            this.certFriendlyNameHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certFriendlyNameHeadingLabel.Location = new System.Drawing.Point(74, 6);
            this.certFriendlyNameHeadingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 0, 7);
            this.certFriendlyNameHeadingLabel.Name = "certFriendlyNameHeadingLabel";
            this.certFriendlyNameHeadingLabel.Size = new System.Drawing.Size(43, 13);
            this.certFriendlyNameHeadingLabel.TabIndex = 0;
            this.certFriendlyNameHeadingLabel.Text = "Name:";
            // 
            // certNameTextBox
            // 
            this.certificateTableLayoutPanel.SetColumnSpan(this.certNameTextBox, 3);
            this.certNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.certNameTextBox.Location = new System.Drawing.Point(120, 3);
            this.certNameTextBox.Name = "certNameTextBox";
            this.certNameTextBox.ReadOnly = true;
            this.certNameTextBox.Size = new System.Drawing.Size(663, 20);
            this.certNameTextBox.TabIndex = 1;
            // 
            // certIssuedToHeadingLabel
            // 
            this.certIssuedToHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.certIssuedToHeadingLabel.AutoSize = true;
            this.certIssuedToHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certIssuedToHeadingLabel.Location = new System.Drawing.Point(50, 32);
            this.certIssuedToHeadingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 0, 7);
            this.certIssuedToHeadingLabel.Name = "certIssuedToHeadingLabel";
            this.certIssuedToHeadingLabel.Size = new System.Drawing.Size(67, 13);
            this.certIssuedToHeadingLabel.TabIndex = 2;
            this.certIssuedToHeadingLabel.Text = "Issued To:";
            // 
            // certIssuedToValueLabel
            // 
            this.certIssuedToValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.certIssuedToValueLabel.AutoSize = true;
            this.certIssuedToValueLabel.Location = new System.Drawing.Point(117, 32);
            this.certIssuedToValueLabel.Margin = new System.Windows.Forms.Padding(0, 6, 3, 7);
            this.certIssuedToValueLabel.Name = "certIssuedToValueLabel";
            this.certIssuedToValueLabel.Size = new System.Drawing.Size(0, 13);
            this.certIssuedToValueLabel.TabIndex = 3;
            // 
            // certValidFromHeadingLabel
            // 
            this.certValidFromHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.certValidFromHeadingLabel.AutoSize = true;
            this.certValidFromHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certValidFromHeadingLabel.Location = new System.Drawing.Point(47, 58);
            this.certValidFromHeadingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 0, 7);
            this.certValidFromHeadingLabel.Name = "certValidFromHeadingLabel";
            this.certValidFromHeadingLabel.Size = new System.Drawing.Size(70, 13);
            this.certValidFromHeadingLabel.TabIndex = 6;
            this.certValidFromHeadingLabel.Text = "Valid From:";
            // 
            // certAlgorithmHeadingLabel
            // 
            this.certAlgorithmHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.certAlgorithmHeadingLabel.AutoSize = true;
            this.certAlgorithmHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certAlgorithmHeadingLabel.Location = new System.Drawing.Point(427, 58);
            this.certAlgorithmHeadingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 0, 7);
            this.certAlgorithmHeadingLabel.Name = "certAlgorithmHeadingLabel";
            this.certAlgorithmHeadingLabel.Size = new System.Drawing.Size(63, 13);
            this.certAlgorithmHeadingLabel.TabIndex = 10;
            this.certAlgorithmHeadingLabel.Text = "Algorithm:";
            // 
            // certIssuedByHeadingLabel
            // 
            this.certIssuedByHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.certIssuedByHeadingLabel.AutoSize = true;
            this.certIssuedByHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certIssuedByHeadingLabel.Location = new System.Drawing.Point(424, 32);
            this.certIssuedByHeadingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 0, 7);
            this.certIssuedByHeadingLabel.Name = "certIssuedByHeadingLabel";
            this.certIssuedByHeadingLabel.Size = new System.Drawing.Size(66, 13);
            this.certIssuedByHeadingLabel.TabIndex = 4;
            this.certIssuedByHeadingLabel.Text = "Issued By:";
            // 
            // certAltNamesHeadingLabel
            // 
            this.certAltNamesHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.certAltNamesHeadingLabel.AutoSize = true;
            this.certAltNamesHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certAltNamesHeadingLabel.Location = new System.Drawing.Point(3, 149);
            this.certAltNamesHeadingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 0, 7);
            this.certAltNamesHeadingLabel.Name = "certAltNamesHeadingLabel";
            this.certAltNamesHeadingLabel.Size = new System.Drawing.Size(114, 13);
            this.certAltNamesHeadingLabel.TabIndex = 12;
            this.certAltNamesHeadingLabel.Text = "Alternative Names:";
            // 
            // certUsagesHeadingLabel
            // 
            this.certUsagesHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.certUsagesHeadingLabel.AutoSize = true;
            this.certUsagesHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certUsagesHeadingLabel.Location = new System.Drawing.Point(437, 149);
            this.certUsagesHeadingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 0, 7);
            this.certUsagesHeadingLabel.Name = "certUsagesHeadingLabel";
            this.certUsagesHeadingLabel.Size = new System.Drawing.Size(53, 13);
            this.certUsagesHeadingLabel.TabIndex = 14;
            this.certUsagesHeadingLabel.Text = "Usages:";
            // 
            // certhThumbprintHeadingLabel
            // 
            this.certhThumbprintHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.certhThumbprintHeadingLabel.AutoSize = true;
            this.certhThumbprintHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certhThumbprintHeadingLabel.Location = new System.Drawing.Point(416, 241);
            this.certhThumbprintHeadingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 0, 7);
            this.certhThumbprintHeadingLabel.Name = "certhThumbprintHeadingLabel";
            this.certhThumbprintHeadingLabel.Size = new System.Drawing.Size(74, 13);
            this.certhThumbprintHeadingLabel.TabIndex = 16;
            this.certhThumbprintHeadingLabel.Text = "Thumbprint:";
            // 
            // certThumbprintTextBox
            // 
            this.certThumbprintTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.certThumbprintTextBox.Location = new System.Drawing.Point(493, 238);
            this.certThumbprintTextBox.Name = "certThumbprintTextBox";
            this.certThumbprintTextBox.ReadOnly = true;
            this.certThumbprintTextBox.Size = new System.Drawing.Size(290, 20);
            this.certThumbprintTextBox.TabIndex = 17;
            // 
            // publicKeyGroupBox
            // 
            this.publicKeyGroupBox.AutoSize = true;
            this.certificateTableLayoutPanel.SetColumnSpan(this.publicKeyGroupBox, 2);
            this.publicKeyGroupBox.Controls.Add(this.publicKeyTableLayoutPanel);
            this.publicKeyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.publicKeyGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicKeyGroupBox.Location = new System.Drawing.Point(3, 238);
            this.publicKeyGroupBox.Name = "publicKeyGroupBox";
            this.certificateTableLayoutPanel.SetRowSpan(this.publicKeyGroupBox, 2);
            this.publicKeyGroupBox.Size = new System.Drawing.Size(407, 177);
            this.publicKeyGroupBox.TabIndex = 18;
            this.publicKeyGroupBox.TabStop = false;
            this.publicKeyGroupBox.Text = "Public Key:";
            // 
            // publicKeyTableLayoutPanel
            // 
            this.publicKeyTableLayoutPanel.AutoSize = true;
            this.publicKeyTableLayoutPanel.ColumnCount = 2;
            this.publicKeyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.publicKeyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.publicKeyTableLayoutPanel.Controls.Add(this.publicKeyOverviewLabel, 0, 0);
            this.publicKeyTableLayoutPanel.Controls.Add(this.publicKeyParametersHeadingLabel, 0, 2);
            this.publicKeyTableLayoutPanel.Controls.Add(this.publicKeyParametersValueLabel, 1, 2);
            this.publicKeyTableLayoutPanel.Controls.Add(this.publicKeyTextBox, 0, 1);
            this.publicKeyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.publicKeyTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.publicKeyTableLayoutPanel.Name = "publicKeyTableLayoutPanel";
            this.publicKeyTableLayoutPanel.RowCount = 3;
            this.publicKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.publicKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.publicKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.publicKeyTableLayoutPanel.Size = new System.Drawing.Size(401, 158);
            this.publicKeyTableLayoutPanel.TabIndex = 0;
            // 
            // publicKeyOverviewLabel
            // 
            this.publicKeyOverviewLabel.AutoSize = true;
            this.publicKeyTableLayoutPanel.SetColumnSpan(this.publicKeyOverviewLabel, 2);
            this.publicKeyOverviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicKeyOverviewLabel.Location = new System.Drawing.Point(3, 0);
            this.publicKeyOverviewLabel.Name = "publicKeyOverviewLabel";
            this.publicKeyOverviewLabel.Size = new System.Drawing.Size(0, 13);
            this.publicKeyOverviewLabel.TabIndex = 0;
            // 
            // publicKeyParametersHeadingLabel
            // 
            this.publicKeyParametersHeadingLabel.AutoSize = true;
            this.publicKeyParametersHeadingLabel.Location = new System.Drawing.Point(3, 145);
            this.publicKeyParametersHeadingLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.publicKeyParametersHeadingLabel.Name = "publicKeyParametersHeadingLabel";
            this.publicKeyParametersHeadingLabel.Size = new System.Drawing.Size(74, 13);
            this.publicKeyParametersHeadingLabel.TabIndex = 1;
            this.publicKeyParametersHeadingLabel.Text = "Parameters:";
            // 
            // publicKeyParametersValueLabel
            // 
            this.publicKeyParametersValueLabel.AutoSize = true;
            this.publicKeyParametersValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicKeyParametersValueLabel.Location = new System.Drawing.Point(80, 145);
            this.publicKeyParametersValueLabel.Name = "publicKeyParametersValueLabel";
            this.publicKeyParametersValueLabel.Size = new System.Drawing.Size(0, 13);
            this.publicKeyParametersValueLabel.TabIndex = 2;
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.AcceptsReturn = true;
            this.publicKeyTextBox.AcceptsTab = true;
            this.publicKeyTableLayoutPanel.SetColumnSpan(this.publicKeyTextBox, 2);
            this.publicKeyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.publicKeyTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicKeyTextBox.Location = new System.Drawing.Point(3, 16);
            this.publicKeyTextBox.Multiline = true;
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.ReadOnly = true;
            this.publicKeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.publicKeyTextBox.Size = new System.Drawing.Size(395, 126);
            this.publicKeyTextBox.TabIndex = 3;
            this.publicKeyTextBox.WordWrap = false;
            // 
            // buttonsFlowLayoutPanel
            // 
            this.buttonsFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsFlowLayoutPanel.AutoSize = true;
            this.certificateTableLayoutPanel.SetColumnSpan(this.buttonsFlowLayoutPanel, 2);
            this.buttonsFlowLayoutPanel.Controls.Add(this.openCertFileButton);
            this.buttonsFlowLayoutPanel.Controls.Add(this.selectCertButton);
            this.buttonsFlowLayoutPanel.Controls.Add(this.certFromClipboardButton);
            this.buttonsFlowLayoutPanel.Location = new System.Drawing.Point(540, 386);
            this.buttonsFlowLayoutPanel.Name = "buttonsFlowLayoutPanel";
            this.buttonsFlowLayoutPanel.Size = new System.Drawing.Size(243, 29);
            this.buttonsFlowLayoutPanel.TabIndex = 19;
            // 
            // openCertFileButton
            // 
            this.openCertFileButton.Location = new System.Drawing.Point(3, 3);
            this.openCertFileButton.Name = "openCertFileButton";
            this.openCertFileButton.Size = new System.Drawing.Size(75, 23);
            this.openCertFileButton.TabIndex = 0;
            this.openCertFileButton.Text = "Open File";
            this.openCertFileButton.UseVisualStyleBackColor = true;
            this.openCertFileButton.Click += new System.EventHandler(this.openCertFileButton_Click);
            // 
            // selectCertButton
            // 
            this.selectCertButton.Location = new System.Drawing.Point(84, 3);
            this.selectCertButton.Name = "selectCertButton";
            this.selectCertButton.Size = new System.Drawing.Size(75, 23);
            this.selectCertButton.TabIndex = 1;
            this.selectCertButton.Text = "Select";
            this.selectCertButton.UseVisualStyleBackColor = true;
            this.selectCertButton.Click += new System.EventHandler(this.selectCertButton_Click);
            // 
            // certFromClipboardButton
            // 
            this.certFromClipboardButton.Location = new System.Drawing.Point(165, 3);
            this.certFromClipboardButton.Name = "certFromClipboardButton";
            this.certFromClipboardButton.Size = new System.Drawing.Size(75, 23);
            this.certFromClipboardButton.TabIndex = 4;
            this.certFromClipboardButton.Text = "Clipboard";
            this.certFromClipboardButton.UseVisualStyleBackColor = true;
            this.certFromClipboardButton.Click += new System.EventHandler(this.certFromClipboardButton_Click);
            // 
            // certAlgorithmValueLabel
            // 
            this.certAlgorithmValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.certAlgorithmValueLabel.AutoSize = true;
            this.certAlgorithmValueLabel.Location = new System.Drawing.Point(490, 32);
            this.certAlgorithmValueLabel.Margin = new System.Windows.Forms.Padding(0, 6, 3, 7);
            this.certAlgorithmValueLabel.Name = "certAlgorithmValueLabel";
            this.certAlgorithmValueLabel.Size = new System.Drawing.Size(0, 13);
            this.certAlgorithmValueLabel.TabIndex = 11;
            // 
            // certIssuedByValueLabel
            // 
            this.certIssuedByValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.certIssuedByValueLabel.AutoSize = true;
            this.certIssuedByValueLabel.Location = new System.Drawing.Point(490, 58);
            this.certIssuedByValueLabel.Margin = new System.Windows.Forms.Padding(0, 6, 3, 7);
            this.certIssuedByValueLabel.Name = "certIssuedByValueLabel";
            this.certIssuedByValueLabel.Size = new System.Drawing.Size(0, 13);
            this.certIssuedByValueLabel.TabIndex = 5;
            // 
            // certAltNamesTextBox
            // 
            this.certAltNamesTextBox.AcceptsReturn = true;
            this.certAltNamesTextBox.AcceptsTab = true;
            this.certAltNamesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.certAltNamesTextBox.Location = new System.Drawing.Point(120, 81);
            this.certAltNamesTextBox.Multiline = true;
            this.certAltNamesTextBox.Name = "certAltNamesTextBox";
            this.certAltNamesTextBox.ReadOnly = true;
            this.certAltNamesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.certAltNamesTextBox.Size = new System.Drawing.Size(290, 151);
            this.certAltNamesTextBox.TabIndex = 20;
            this.certAltNamesTextBox.WordWrap = false;
            // 
            // certUsagesTextBox
            // 
            this.certUsagesTextBox.AcceptsReturn = true;
            this.certUsagesTextBox.AcceptsTab = true;
            this.certUsagesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.certUsagesTextBox.Location = new System.Drawing.Point(493, 81);
            this.certUsagesTextBox.Multiline = true;
            this.certUsagesTextBox.Name = "certUsagesTextBox";
            this.certUsagesTextBox.ReadOnly = true;
            this.certUsagesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.certUsagesTextBox.Size = new System.Drawing.Size(290, 151);
            this.certUsagesTextBox.TabIndex = 21;
            this.certUsagesTextBox.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.certValidFromValueLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.certValidToHeadingLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.certValidToValueLabel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(117, 52);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 26);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // certValidFromValueLabel
            // 
            this.certValidFromValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.certValidFromValueLabel.AutoSize = true;
            this.certValidFromValueLabel.Location = new System.Drawing.Point(0, 6);
            this.certValidFromValueLabel.Margin = new System.Windows.Forms.Padding(0, 6, 3, 7);
            this.certValidFromValueLabel.Name = "certValidFromValueLabel";
            this.certValidFromValueLabel.Size = new System.Drawing.Size(0, 13);
            this.certValidFromValueLabel.TabIndex = 8;
            // 
            // certValidToHeadingLabel
            // 
            this.certValidToHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.certValidToHeadingLabel.AutoSize = true;
            this.certValidToHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certValidToHeadingLabel.Location = new System.Drawing.Point(3, 6);
            this.certValidToHeadingLabel.Margin = new System.Windows.Forms.Padding(0, 6, 0, 7);
            this.certValidToHeadingLabel.Name = "certValidToHeadingLabel";
            this.certValidToHeadingLabel.Size = new System.Drawing.Size(18, 13);
            this.certValidToHeadingLabel.TabIndex = 8;
            this.certValidToHeadingLabel.Text = "to";
            // 
            // certValidToValueLabel
            // 
            this.certValidToValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.certValidToValueLabel.AutoSize = true;
            this.certValidToValueLabel.Location = new System.Drawing.Point(21, 6);
            this.certValidToValueLabel.Margin = new System.Windows.Forms.Padding(0, 6, 3, 7);
            this.certValidToValueLabel.Name = "certValidToValueLabel";
            this.certValidToValueLabel.Size = new System.Drawing.Size(0, 13);
            this.certValidToValueLabel.TabIndex = 9;
            // 
            // fileEncryptionTabPage
            // 
            this.fileEncryptionTabPage.Controls.Add(this.fileEncryptionTableLayoutPanel);
            this.fileEncryptionTabPage.Location = new System.Drawing.Point(4, 22);
            this.fileEncryptionTabPage.Name = "fileEncryptionTabPage";
            this.fileEncryptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fileEncryptionTabPage.Size = new System.Drawing.Size(792, 424);
            this.fileEncryptionTabPage.TabIndex = 1;
            this.fileEncryptionTabPage.Text = "File Encrypt/Decrypt";
            this.fileEncryptionTabPage.UseVisualStyleBackColor = true;
            // 
            // fileEncryptionTableLayoutPanel
            // 
            this.fileEncryptionTableLayoutPanel.AutoSize = true;
            this.fileEncryptionTableLayoutPanel.ColumnCount = 2;
            this.fileEncryptionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fileEncryptionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.fileEncryptionTableLayoutPanel.Controls.Add(this.sourceFileLabel, 0, 0);
            this.fileEncryptionTableLayoutPanel.Controls.Add(this.sourceFileTextBox, 0, 1);
            this.fileEncryptionTableLayoutPanel.Controls.Add(this.sourceFileBrowseButton, 1, 1);
            this.fileEncryptionTableLayoutPanel.Controls.Add(this.targetFileLabel, 0, 2);
            this.fileEncryptionTableLayoutPanel.Controls.Add(this.targetFileTextBox, 0, 3);
            this.fileEncryptionTableLayoutPanel.Controls.Add(this.targetFileBrowseButton, 1, 3);
            this.fileEncryptionTableLayoutPanel.Controls.Add(this.fileEncryptionFlowLayoutPanel, 0, 4);
            this.fileEncryptionTableLayoutPanel.Controls.Add(this.fileCryptoResultLabel, 0, 5);
            this.fileEncryptionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileEncryptionTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.fileEncryptionTableLayoutPanel.Name = "fileEncryptionTableLayoutPanel";
            this.fileEncryptionTableLayoutPanel.RowCount = 6;
            this.fileEncryptionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileEncryptionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileEncryptionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileEncryptionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileEncryptionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileEncryptionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fileEncryptionTableLayoutPanel.Size = new System.Drawing.Size(786, 418);
            this.fileEncryptionTableLayoutPanel.TabIndex = 0;
            // 
            // sourceFileLabel
            // 
            this.sourceFileLabel.AutoSize = true;
            this.fileEncryptionTableLayoutPanel.SetColumnSpan(this.sourceFileLabel, 2);
            this.sourceFileLabel.Location = new System.Drawing.Point(3, 0);
            this.sourceFileLabel.Name = "sourceFileLabel";
            this.sourceFileLabel.Size = new System.Drawing.Size(41, 13);
            this.sourceFileLabel.TabIndex = 0;
            this.sourceFileLabel.Text = "Source";
            // 
            // sourceFileTextBox
            // 
            this.sourceFileTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.sourceFileTextBox.Location = new System.Drawing.Point(3, 16);
            this.sourceFileTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.sourceFileTextBox.Name = "sourceFileTextBox";
            this.sourceFileTextBox.Size = new System.Drawing.Size(705, 20);
            this.sourceFileTextBox.TabIndex = 1;
            // 
            // sourceFileBrowseButton
            // 
            this.sourceFileBrowseButton.Location = new System.Drawing.Point(708, 16);
            this.sourceFileBrowseButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.sourceFileBrowseButton.Name = "sourceFileBrowseButton";
            this.sourceFileBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.sourceFileBrowseButton.TabIndex = 2;
            this.sourceFileBrowseButton.Text = "Browse";
            this.sourceFileBrowseButton.UseVisualStyleBackColor = true;
            this.sourceFileBrowseButton.Click += new System.EventHandler(this.sourceFileBrowseButton_Click);
            // 
            // targetFileLabel
            // 
            this.targetFileLabel.AutoSize = true;
            this.fileEncryptionTableLayoutPanel.SetColumnSpan(this.targetFileLabel, 2);
            this.targetFileLabel.Location = new System.Drawing.Point(3, 42);
            this.targetFileLabel.Name = "targetFileLabel";
            this.targetFileLabel.Size = new System.Drawing.Size(38, 13);
            this.targetFileLabel.TabIndex = 4;
            this.targetFileLabel.Text = "Target";
            // 
            // targetFileTextBox
            // 
            this.targetFileTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.targetFileTextBox.Location = new System.Drawing.Point(3, 58);
            this.targetFileTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.targetFileTextBox.Name = "targetFileTextBox";
            this.targetFileTextBox.Size = new System.Drawing.Size(705, 20);
            this.targetFileTextBox.TabIndex = 5;
            // 
            // targetFileBrowseButton
            // 
            this.targetFileBrowseButton.Location = new System.Drawing.Point(708, 58);
            this.targetFileBrowseButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.targetFileBrowseButton.Name = "targetFileBrowseButton";
            this.targetFileBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.targetFileBrowseButton.TabIndex = 6;
            this.targetFileBrowseButton.Text = "Browse";
            this.targetFileBrowseButton.UseVisualStyleBackColor = true;
            this.targetFileBrowseButton.Click += new System.EventHandler(this.targetFileBrowseButton_Click);
            // 
            // fileEncryptionFlowLayoutPanel
            // 
            this.fileEncryptionFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileEncryptionFlowLayoutPanel.AutoSize = true;
            this.fileEncryptionTableLayoutPanel.SetColumnSpan(this.fileEncryptionFlowLayoutPanel, 2);
            this.fileEncryptionFlowLayoutPanel.Controls.Add(this.decryptFileButton);
            this.fileEncryptionFlowLayoutPanel.Controls.Add(this.encryptFileButton);
            this.fileEncryptionFlowLayoutPanel.Location = new System.Drawing.Point(621, 87);
            this.fileEncryptionFlowLayoutPanel.Name = "fileEncryptionFlowLayoutPanel";
            this.fileEncryptionFlowLayoutPanel.Size = new System.Drawing.Size(162, 29);
            this.fileEncryptionFlowLayoutPanel.TabIndex = 7;
            // 
            // decryptFileButton
            // 
            this.decryptFileButton.Location = new System.Drawing.Point(3, 3);
            this.decryptFileButton.Name = "decryptFileButton";
            this.decryptFileButton.Size = new System.Drawing.Size(75, 23);
            this.decryptFileButton.TabIndex = 0;
            this.decryptFileButton.Text = "Decrypt";
            this.decryptFileButton.UseVisualStyleBackColor = true;
            this.decryptFileButton.Click += new System.EventHandler(this.decryptFileButton_Click);
            // 
            // encryptFileButton
            // 
            this.encryptFileButton.Location = new System.Drawing.Point(84, 3);
            this.encryptFileButton.Name = "encryptFileButton";
            this.encryptFileButton.Size = new System.Drawing.Size(75, 23);
            this.encryptFileButton.TabIndex = 1;
            this.encryptFileButton.Text = "Encrypt";
            this.encryptFileButton.UseVisualStyleBackColor = true;
            this.encryptFileButton.Click += new System.EventHandler(this.encryptFileButton_Click);
            // 
            // fileCryptoResultLabel
            // 
            this.fileCryptoResultLabel.AutoSize = true;
            this.fileEncryptionTableLayoutPanel.SetColumnSpan(this.fileCryptoResultLabel, 2);
            this.fileCryptoResultLabel.Location = new System.Drawing.Point(3, 119);
            this.fileCryptoResultLabel.Name = "fileCryptoResultLabel";
            this.fileCryptoResultLabel.Size = new System.Drawing.Size(0, 13);
            this.fileCryptoResultLabel.TabIndex = 8;
            // 
            // textEncryptionTabPage
            // 
            this.textEncryptionTabPage.Controls.Add(this.textEncryptionTableLayoutPanel);
            this.textEncryptionTabPage.Location = new System.Drawing.Point(4, 22);
            this.textEncryptionTabPage.Name = "textEncryptionTabPage";
            this.textEncryptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.textEncryptionTabPage.Size = new System.Drawing.Size(792, 424);
            this.textEncryptionTabPage.TabIndex = 2;
            this.textEncryptionTabPage.Text = "Text Encrypt/Decrypt";
            this.textEncryptionTabPage.UseVisualStyleBackColor = true;
            // 
            // textEncryptionTableLayoutPanel
            // 
            this.textEncryptionTableLayoutPanel.ColumnCount = 1;
            this.textEncryptionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.textEncryptionTableLayoutPanel.Controls.Add(this.textEncryptionActionTableLayoutPanel, 0, 1);
            this.textEncryptionTableLayoutPanel.Controls.Add(this.textEncryptionTabControl, 0, 0);
            this.textEncryptionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEncryptionTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.textEncryptionTableLayoutPanel.Name = "textEncryptionTableLayoutPanel";
            this.textEncryptionTableLayoutPanel.RowCount = 2;
            this.textEncryptionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.textEncryptionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.textEncryptionTableLayoutPanel.Size = new System.Drawing.Size(786, 418);
            this.textEncryptionTableLayoutPanel.TabIndex = 0;
            // 
            // textEncryptionActionTableLayoutPanel
            // 
            this.textEncryptionActionTableLayoutPanel.AutoSize = true;
            this.textEncryptionActionTableLayoutPanel.ColumnCount = 5;
            this.textEncryptionActionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.textEncryptionActionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.textEncryptionActionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.textEncryptionActionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.textEncryptionActionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.textEncryptionActionTableLayoutPanel.Controls.Add(this.textDecryptButton, 3, 0);
            this.textEncryptionActionTableLayoutPanel.Controls.Add(this.textEncryptButton, 4, 0);
            this.textEncryptionActionTableLayoutPanel.Controls.Add(this.textEncodingLabel, 0, 0);
            this.textEncryptionActionTableLayoutPanel.Controls.Add(this.encodingComboBox, 1, 0);
            this.textEncryptionActionTableLayoutPanel.Controls.Add(this.bomCheckBox, 2, 0);
            this.textEncryptionActionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.textEncryptionActionTableLayoutPanel.Location = new System.Drawing.Point(0, 391);
            this.textEncryptionActionTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.textEncryptionActionTableLayoutPanel.Name = "textEncryptionActionTableLayoutPanel";
            this.textEncryptionActionTableLayoutPanel.RowCount = 1;
            this.textEncryptionActionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.textEncryptionActionTableLayoutPanel.Size = new System.Drawing.Size(786, 27);
            this.textEncryptionActionTableLayoutPanel.TabIndex = 2;
            // 
            // textDecryptButton
            // 
            this.textDecryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textDecryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDecryptButton.Location = new System.Drawing.Point(627, 1);
            this.textDecryptButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textDecryptButton.Name = "textDecryptButton";
            this.textDecryptButton.Size = new System.Drawing.Size(75, 23);
            this.textDecryptButton.TabIndex = 2;
            this.textDecryptButton.Text = "Decrypt";
            this.textDecryptButton.UseVisualStyleBackColor = true;
            this.textDecryptButton.Click += new System.EventHandler(this.textDecryptButton_Click);
            // 
            // textEncryptButton
            // 
            this.textEncryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textEncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEncryptButton.Location = new System.Drawing.Point(708, 1);
            this.textEncryptButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textEncryptButton.Name = "textEncryptButton";
            this.textEncryptButton.Size = new System.Drawing.Size(75, 23);
            this.textEncryptButton.TabIndex = 3;
            this.textEncryptButton.Text = "Encrypt";
            this.textEncryptButton.UseVisualStyleBackColor = true;
            this.textEncryptButton.Click += new System.EventHandler(this.textEncryptButton_Click);
            // 
            // textEncodingLabel
            // 
            this.textEncodingLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textEncodingLabel.AutoSize = true;
            this.textEncodingLabel.Location = new System.Drawing.Point(3, 7);
            this.textEncodingLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.textEncodingLabel.Name = "textEncodingLabel";
            this.textEncodingLabel.Size = new System.Drawing.Size(55, 13);
            this.textEncodingLabel.TabIndex = 4;
            this.textEncodingLabel.Text = "Encoding:";
            // 
            // encodingComboBox
            // 
            this.encodingComboBox.DisplayMember = "Key";
            this.encodingComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.encodingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encodingComboBox.FormattingEnabled = true;
            this.encodingComboBox.Location = new System.Drawing.Point(58, 3);
            this.encodingComboBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.encodingComboBox.Name = "encodingComboBox";
            this.encodingComboBox.Size = new System.Drawing.Size(484, 21);
            this.encodingComboBox.TabIndex = 5;
            // 
            // bomCheckBox
            // 
            this.bomCheckBox.AutoSize = true;
            this.bomCheckBox.Location = new System.Drawing.Point(548, 3);
            this.bomCheckBox.Name = "bomCheckBox";
            this.bomCheckBox.Size = new System.Drawing.Size(73, 17);
            this.bomCheckBox.TabIndex = 6;
            this.bomCheckBox.Text = "Emit BOM";
            this.bomCheckBox.UseVisualStyleBackColor = true;
            // 
            // textEncryptionTabControl
            // 
            this.textEncryptionTabControl.Controls.Add(this.textInputTabPage);
            this.textEncryptionTabControl.Controls.Add(this.textOutputTabPage);
            this.textEncryptionTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEncryptionTabControl.Location = new System.Drawing.Point(0, 0);
            this.textEncryptionTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.textEncryptionTabControl.Name = "textEncryptionTabControl";
            this.textEncryptionTabControl.SelectedIndex = 0;
            this.textEncryptionTabControl.Size = new System.Drawing.Size(786, 391);
            this.textEncryptionTabControl.TabIndex = 1;
            // 
            // textInputTabPage
            // 
            this.textInputTabPage.Controls.Add(this.textInputTextBox);
            this.textInputTabPage.Location = new System.Drawing.Point(4, 22);
            this.textInputTabPage.Name = "textInputTabPage";
            this.textInputTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.textInputTabPage.Size = new System.Drawing.Size(778, 365);
            this.textInputTabPage.TabIndex = 0;
            this.textInputTabPage.Text = "Input";
            this.textInputTabPage.UseVisualStyleBackColor = true;
            // 
            // textInputTextBox
            // 
            this.textInputTextBox.AcceptsReturn = true;
            this.textInputTextBox.AcceptsTab = true;
            this.textInputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textInputTextBox.Location = new System.Drawing.Point(3, 3);
            this.textInputTextBox.Multiline = true;
            this.textInputTextBox.Name = "textInputTextBox";
            this.textInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textInputTextBox.Size = new System.Drawing.Size(772, 359);
            this.textInputTextBox.TabIndex = 0;
            this.textInputTextBox.WordWrap = false;
            // 
            // textOutputTabPage
            // 
            this.textOutputTabPage.Controls.Add(this.textOutputTextBox);
            this.textOutputTabPage.Location = new System.Drawing.Point(4, 22);
            this.textOutputTabPage.Name = "textOutputTabPage";
            this.textOutputTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.textOutputTabPage.Size = new System.Drawing.Size(778, 365);
            this.textOutputTabPage.TabIndex = 1;
            this.textOutputTabPage.Text = "Output";
            this.textOutputTabPage.UseVisualStyleBackColor = true;
            // 
            // textOutputTextBox
            // 
            this.textOutputTextBox.AcceptsReturn = true;
            this.textOutputTextBox.AcceptsTab = true;
            this.textOutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textOutputTextBox.Location = new System.Drawing.Point(3, 3);
            this.textOutputTextBox.Multiline = true;
            this.textOutputTextBox.Name = "textOutputTextBox";
            this.textOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textOutputTextBox.Size = new System.Drawing.Size(772, 359);
            this.textOutputTextBox.TabIndex = 0;
            // 
            // openCertificateDialog
            // 
            this.openCertificateDialog.DefaultExt = "*.cer";
            this.openCertificateDialog.Filter = "Base-64 CER|*.cer|PKCS #7 Certificates|*.p7b|Personal Information Exchange (PKCS " +
    "#12)|*.pfx;*.p12|All Files|*.*";
            this.openCertificateDialog.Title = "Open Certificate";
            // 
            // openSourceFileDialog
            // 
            this.openSourceFileDialog.Filter = "All Files|*.*";
            this.openSourceFileDialog.Title = "Source File";
            // 
            // saveTargetFileDialog
            // 
            this.saveTargetFileDialog.DefaultExt = "txt";
            this.saveTargetFileDialog.Filter = "Text File (*.txt)|*.txt|GZip File (*.gz)|*.gz|All Files|*.*";
            this.saveTargetFileDialog.Title = "Target File";
            // 
            // EncryptionHelperForm
            // 
            this.components = new System.ComponentModel.Container();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTabControl);
            this.Name = "EncryptionHelperForm";
            this.Text = "Encryption Helper";
            this.mainTabControl.ResumeLayout(false);
            this.certificateTabPage.ResumeLayout(false);
            this.certificateTabPage.PerformLayout();
            this.certificateTableLayoutPanel.ResumeLayout(false);
            this.certificateTableLayoutPanel.PerformLayout();
            this.publicKeyGroupBox.ResumeLayout(false);
            this.publicKeyGroupBox.PerformLayout();
            this.publicKeyTableLayoutPanel.ResumeLayout(false);
            this.publicKeyTableLayoutPanel.PerformLayout();
            this.buttonsFlowLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.fileEncryptionTabPage.ResumeLayout(false);
            this.fileEncryptionTabPage.PerformLayout();
            this.fileEncryptionTableLayoutPanel.ResumeLayout(false);
            this.fileEncryptionTableLayoutPanel.PerformLayout();
            this.fileEncryptionFlowLayoutPanel.ResumeLayout(false);
            this.textEncryptionTabPage.ResumeLayout(false);
            this.textEncryptionTableLayoutPanel.ResumeLayout(false);
            this.textEncryptionTableLayoutPanel.PerformLayout();
            this.textEncryptionActionTableLayoutPanel.ResumeLayout(false);
            this.textEncryptionActionTableLayoutPanel.PerformLayout();
            this.textEncryptionTabControl.ResumeLayout(false);
            this.textInputTabPage.ResumeLayout(false);
            this.textInputTabPage.PerformLayout();
            this.textOutputTabPage.ResumeLayout(false);
            this.textOutputTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage certificateTabPage;
        private System.Windows.Forms.TableLayoutPanel certificateTableLayoutPanel;
        private System.Windows.Forms.Label certFriendlyNameHeadingLabel;
        private System.Windows.Forms.TextBox certNameTextBox;
        private System.Windows.Forms.Label certIssuedToHeadingLabel;
        private System.Windows.Forms.Label certIssuedToValueLabel;
        private System.Windows.Forms.Label certValidFromHeadingLabel;
        private System.Windows.Forms.Label certValidToHeadingLabel;
        private System.Windows.Forms.Label certValidToValueLabel;
        private System.Windows.Forms.Label certAlgorithmHeadingLabel;
        private System.Windows.Forms.Label certIssuedByValueLabel;
        private System.Windows.Forms.Label certIssuedByHeadingLabel;
        private System.Windows.Forms.Label certAlgorithmValueLabel;
        private System.Windows.Forms.Label certAltNamesHeadingLabel;
        private System.Windows.Forms.Label certUsagesHeadingLabel;
        private System.Windows.Forms.Label certhThumbprintHeadingLabel;
        private System.Windows.Forms.TextBox certThumbprintTextBox;
        private System.Windows.Forms.GroupBox publicKeyGroupBox;
        private System.Windows.Forms.TableLayoutPanel publicKeyTableLayoutPanel;
        private System.Windows.Forms.Label publicKeyOverviewLabel;
        private System.Windows.Forms.Label publicKeyParametersHeadingLabel;
        private System.Windows.Forms.Label publicKeyParametersValueLabel;
        private System.Windows.Forms.TextBox publicKeyTextBox;
        private System.Windows.Forms.FlowLayoutPanel buttonsFlowLayoutPanel;
        private System.Windows.Forms.Button openCertFileButton;
        private System.Windows.Forms.Button selectCertButton;
        private System.Windows.Forms.TabPage fileEncryptionTabPage;
        private System.Windows.Forms.TabPage textEncryptionTabPage;
        private System.Windows.Forms.TableLayoutPanel textEncryptionTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel textEncryptionActionTableLayoutPanel;
        private System.Windows.Forms.Button textDecryptButton;
        private System.Windows.Forms.Button textEncryptButton;
        private System.Windows.Forms.TabControl textEncryptionTabControl;
        private System.Windows.Forms.TabPage textInputTabPage;
        private System.Windows.Forms.TabPage textOutputTabPage;
        private System.Windows.Forms.Button certFromClipboardButton;
        private System.Windows.Forms.OpenFileDialog openCertificateDialog;
        private System.Windows.Forms.TextBox certAltNamesTextBox;
        private System.Windows.Forms.TextBox certUsagesTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label certValidFromValueLabel;
        private System.Windows.Forms.TableLayoutPanel fileEncryptionTableLayoutPanel;
        private System.Windows.Forms.Label sourceFileLabel;
        private System.Windows.Forms.TextBox sourceFileTextBox;
        private System.Windows.Forms.Button sourceFileBrowseButton;
        private System.Windows.Forms.Label targetFileLabel;
        private System.Windows.Forms.TextBox targetFileTextBox;
        private System.Windows.Forms.Button targetFileBrowseButton;
        private System.Windows.Forms.FlowLayoutPanel fileEncryptionFlowLayoutPanel;
        private System.Windows.Forms.Button decryptFileButton;
        private System.Windows.Forms.Button encryptFileButton;
        private System.Windows.Forms.Label fileCryptoResultLabel;
        private System.Windows.Forms.TextBox textInputTextBox;
        private System.Windows.Forms.TextBox textOutputTextBox;
        private System.Windows.Forms.Label textEncodingLabel;
        private System.Windows.Forms.ComboBox encodingComboBox;
        private System.Windows.Forms.OpenFileDialog openSourceFileDialog;
        private System.Windows.Forms.SaveFileDialog saveTargetFileDialog;
        private System.Windows.Forms.CheckBox bomCheckBox;
    }
}

