namespace Asg2_klh170130
{
    partial class frmRebate
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "A",
            "B",
            "C",
            "8888888888"}, -1);
            this.lsvData = new System.Windows.Forms.ListView();
            this.clhFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhMI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFName = new System.Windows.Forms.Label();
            this.lblMI = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblProof = new System.Windows.Forms.Label();
            this.lblDateReceived = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.cbbState = new System.Windows.Forms.ComboBox();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbbProof = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCurrentMode = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblModeSwitch = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtpDateReceived = new System.Windows.Forms.DateTimePicker();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.erpEP1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpEP1)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvData
            // 
            this.lsvData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvData.CausesValidation = false;
            this.lsvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhFName,
            this.clhMI,
            this.clhLName,
            this.clhPhone});
            this.lsvData.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lsvData.Location = new System.Drawing.Point(487, 12);
            this.lsvData.MultiSelect = false;
            this.lsvData.Name = "lsvData";
            this.lsvData.Size = new System.Drawing.Size(445, 409);
            this.lsvData.TabIndex = 13;
            this.lsvData.UseCompatibleStateImageBehavior = false;
            this.lsvData.View = System.Windows.Forms.View.Details;
            this.lsvData.SelectedIndexChanged += new System.EventHandler(this.lsvData_SelectedIndexChanged);
            // 
            // clhFName
            // 
            this.clhFName.Text = "First Name";
            this.clhFName.Width = 100;
            // 
            // clhMI
            // 
            this.clhMI.Text = "MI";
            this.clhMI.Width = 42;
            // 
            // clhLName
            // 
            this.clhLName.Text = "Last Name";
            this.clhLName.Width = 105;
            // 
            // clhPhone
            // 
            this.clhPhone.Text = "Phone Number";
            this.clhPhone.Width = 193;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(20, 78);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(75, 18);
            this.lblFName.TabIndex = 100;
            this.lblFName.Text = "First Name";
            // 
            // lblMI
            // 
            this.lblMI.AutoSize = true;
            this.lblMI.Location = new System.Drawing.Point(20, 110);
            this.lblMI.Name = "lblMI";
            this.lblMI.Size = new System.Drawing.Size(90, 18);
            this.lblMI.TabIndex = 101;
            this.lblMI.Text = "Middle Initial";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(20, 142);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(72, 18);
            this.lblLName.TabIndex = 102;
            this.lblLName.Text = "Last Name";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(20, 174);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(105, 18);
            this.lblAddress1.TabIndex = 103;
            this.lblAddress1.Text = "Address (line 1)";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(20, 206);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(105, 18);
            this.lblAddress2.TabIndex = 104;
            this.lblAddress2.Text = "Address (line 2)";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(20, 238);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 18);
            this.lblCity.TabIndex = 105;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(20, 270);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(40, 18);
            this.lblState.TabIndex = 106;
            this.lblState.Text = "State";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(20, 302);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(62, 18);
            this.lblZip.TabIndex = 107;
            this.lblZip.Text = "Zip Code";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, 334);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 18);
            this.lblGender.TabIndex = 108;
            this.lblGender.Text = "Gender";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 366);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(48, 18);
            this.lblPhone.TabIndex = 109;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 398);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(95, 18);
            this.lblEmail.TabIndex = 110;
            this.lblEmail.Text = "Email Address";
            // 
            // lblProof
            // 
            this.lblProof.AutoSize = true;
            this.lblProof.Location = new System.Drawing.Point(20, 430);
            this.lblProof.Name = "lblProof";
            this.lblProof.Size = new System.Drawing.Size(176, 18);
            this.lblProof.TabIndex = 111;
            this.lblProof.Text = "Proof of Purchase Attached";
            // 
            // lblDateReceived
            // 
            this.lblDateReceived.AutoSize = true;
            this.lblDateReceived.Location = new System.Drawing.Point(20, 465);
            this.lblDateReceived.Name = "lblDateReceived";
            this.lblDateReceived.Size = new System.Drawing.Size(97, 18);
            this.lblDateReceived.TabIndex = 112;
            this.lblDateReceived.Text = "Date Received";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(131, 75);
            this.txtFName.MaxLength = 20;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(227, 26);
            this.txtFName.TabIndex = 0;
            this.txtFName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFName_Validating);
            this.txtFName.Validated += new System.EventHandler(this.txtFName_Validated);
            // 
            // txtMI
            // 
            this.txtMI.Location = new System.Drawing.Point(131, 107);
            this.txtMI.MaxLength = 1;
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(26, 26);
            this.txtMI.TabIndex = 1;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(131, 139);
            this.txtLName.MaxLength = 20;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(227, 26);
            this.txtLName.TabIndex = 2;
            this.txtLName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLName_Validating);
            this.txtLName.Validated += new System.EventHandler(this.txtLName_Validated);
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(131, 171);
            this.txtAddress1.MaxLength = 35;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(350, 26);
            this.txtAddress1.TabIndex = 3;
            this.txtAddress1.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress1_Validating);
            this.txtAddress1.Validated += new System.EventHandler(this.txtAddress1_Validated);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(131, 203);
            this.txtAddress2.MaxLength = 35;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(350, 26);
            this.txtAddress2.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(131, 235);
            this.txtCity.MaxLength = 25;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(250, 26);
            this.txtCity.TabIndex = 5;
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtCity_Validating);
            this.txtCity.Validated += new System.EventHandler(this.txtCity_Validated);
            // 
            // cbbState
            // 
            this.cbbState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbState.FormattingEnabled = true;
            this.cbbState.Items.AddRange(new object[] {
            "AK",
            "AL",
            "AZ",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "IA",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "MA",
            "MD",
            "ME",
            "MI",
            "MN",
            "MO",
            "MS",
            "MT",
            "NC",
            "ND",
            "NE",
            "NH",
            "NJ",
            "NM",
            "NV",
            "NY",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VA",
            "VT",
            "WA",
            "WI",
            "WV",
            "WY"});
            this.cbbState.Location = new System.Drawing.Point(131, 267);
            this.cbbState.MaxDropDownItems = 7;
            this.cbbState.MaxLength = 2;
            this.cbbState.Name = "cbbState";
            this.cbbState.Size = new System.Drawing.Size(50, 26);
            this.cbbState.Sorted = true;
            this.cbbState.TabIndex = 6;
            this.cbbState.Validating += new System.ComponentModel.CancelEventHandler(this.cbbState_Validating);
            this.cbbState.Validated += new System.EventHandler(this.cbbState_Validated);
            // 
            // cbbGender
            // 
            this.cbbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbbGender.Location = new System.Drawing.Point(131, 331);
            this.cbbGender.MaxDropDownItems = 2;
            this.cbbGender.MaxLength = 1;
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(42, 26);
            this.cbbGender.Sorted = true;
            this.cbbGender.TabIndex = 8;
            this.cbbGender.Validating += new System.ComponentModel.CancelEventHandler(this.cbbGender_Validating);
            this.cbbGender.Validated += new System.EventHandler(this.cbbGender_Validated);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 395);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 26);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // cbbProof
            // 
            this.cbbProof.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.cbbProof.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbProof.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbProof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProof.FormattingEnabled = true;
            this.cbbProof.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cbbProof.Location = new System.Drawing.Point(202, 427);
            this.cbbProof.MaxDropDownItems = 2;
            this.cbbProof.MaxLength = 3;
            this.cbbProof.Name = "cbbProof";
            this.cbbProof.Size = new System.Drawing.Size(58, 26);
            this.cbbProof.TabIndex = 11;
            this.cbbProof.Validating += new System.ComponentModel.CancelEventHandler(this.cbbProof_Validating);
            this.cbbProof.Validated += new System.EventHandler(this.cbbProof_Validated);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(406, 455);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCurrentMode
            // 
            this.lblCurrentMode.AutoSize = true;
            this.lblCurrentMode.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.lblCurrentMode.Location = new System.Drawing.Point(16, 12);
            this.lblCurrentMode.Name = "lblCurrentMode";
            this.lblCurrentMode.Size = new System.Drawing.Size(118, 23);
            this.lblCurrentMode.TabIndex = 114;
            this.lblCurrentMode.Text = "Current Mode";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMode.ForeColor = System.Drawing.Color.Blue;
            this.lblMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMode.Location = new System.Drawing.Point(140, 12);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(46, 23);
            this.lblMode.TabIndex = 115;
            this.lblMode.Text = "ADD";
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Enabled = false;
            this.btnModify.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModify.Location = new System.Drawing.Point(568, 455);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 34);
            this.btnModify.TabIndex = 16;
            this.btnModify.Text = "Update";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.CausesValidation = false;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClear.Location = new System.Drawing.Point(487, 455);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.CausesValidation = false;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(730, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.CausesValidation = false;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(857, 455);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblModeSwitch
            // 
            this.lblModeSwitch.AutoSize = true;
            this.lblModeSwitch.Enabled = false;
            this.lblModeSwitch.Location = new System.Drawing.Point(128, 35);
            this.lblModeSwitch.Name = "lblModeSwitch";
            this.lblModeSwitch.Size = new System.Drawing.Size(352, 18);
            this.lblModeSwitch.TabIndex = 116;
            this.lblModeSwitch.Text = "(Select an existing record on the list to enter Edit Mode)";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(131, 299);
            this.txtZip.Mask = "00000-9999";
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(90, 26);
            this.txtZip.TabIndex = 7;
            this.txtZip.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtZip.Validating += new System.ComponentModel.CancelEventHandler(this.txtZip_Validating);
            this.txtZip.Validated += new System.EventHandler(this.txtZip_Validated);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(131, 363);
            this.txtPhone.Mask = "(000) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhone.Size = new System.Drawing.Size(235, 26);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            this.txtPhone.Validated += new System.EventHandler(this.txtPhone_Validated);
            // 
            // dtpDateReceived
            // 
            this.dtpDateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateReceived.Location = new System.Drawing.Point(131, 459);
            this.dtpDateReceived.Name = "dtpDateReceived";
            this.dtpDateReceived.Size = new System.Drawing.Size(129, 26);
            this.dtpDateReceived.TabIndex = 12;
            this.dtpDateReceived.Value = new System.DateTime(2019, 9, 22, 0, 0, 0, 0);
            this.dtpDateReceived.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDateReceived_Validating);
            this.dtpDateReceived.Validated += new System.EventHandler(this.dtpDateReceived_Validated);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiscard.CausesValidation = false;
            this.btnDiscard.Enabled = false;
            this.btnDiscard.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDiscard.Location = new System.Drawing.Point(649, 455);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(75, 34);
            this.btnDiscard.TabIndex = 17;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // erpEP1
            // 
            this.erpEP1.ContainerControl = this;
            // 
            // frmRebate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.dtpDateReceived);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lblModeSwitch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblCurrentMode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbProof);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cbbGender);
            this.Controls.Add(this.cbbState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtMI);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblDateReceived);
            this.Controls.Add(this.lblProof);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblMI);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lsvData);
            this.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRebate";
            this.Text = "Rebate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRebate_FormClosing);
            this.Load += new System.EventHandler(this.frmRebate_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRebate_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.erpEP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvData;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblMI;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblProof;
        private System.Windows.Forms.Label lblDateReceived;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ComboBox cbbState;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbbProof;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCurrentMode;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader clhFName;
        private System.Windows.Forms.ColumnHeader clhMI;
        private System.Windows.Forms.ColumnHeader clhLName;
        private System.Windows.Forms.ColumnHeader clhPhone;
        private System.Windows.Forms.Label lblModeSwitch;
        private System.Windows.Forms.MaskedTextBox txtZip;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpDateReceived;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.ErrorProvider erpEP1;
    }
}

