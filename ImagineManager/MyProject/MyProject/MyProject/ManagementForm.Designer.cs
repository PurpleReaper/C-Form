namespace MyProject
{
    partial class ManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.diviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceManagementDataSet = new MyProject.DeviceManagementDataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new MyProject.DeviceManagementDataSetTableAdapters.MemberTableAdapter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableAdapterManager1 = new MyProject.DeviceManagementDataSetTableAdapters.TableAdapterManager();
            this.tabBorrow = new System.Windows.Forms.TabPage();
            this.dgvYourBorrow = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReimburse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabBorrowed = new System.Windows.Forms.TabPage();
            this.cmbBSearch = new System.Windows.Forms.ComboBox();
            this.txtBSearch = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.dgvBorrowed = new System.Windows.Forms.DataGridView();
            this.BDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDStartingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtMaxAmount = new System.Windows.Forms.TextBox();
            this.txtBDAmount = new System.Windows.Forms.NumericUpDown();
            this.cmbBDDID = new System.Windows.Forms.ComboBox();
            this.cmbBDMID = new System.Windows.Forms.ComboBox();
            this.txtBDManager = new System.Windows.Forms.TextBox();
            this.dtpBDStartingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBDEndDate = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtBDID = new System.Windows.Forms.TextBox();
            this.grpBDButton = new System.Windows.Forms.GroupBox();
            this.btnBDDelete = new System.Windows.Forms.Button();
            this.btnBDCancel = new System.Windows.Forms.Button();
            this.btnBDSave = new System.Windows.Forms.Button();
            this.btnBDAdd = new System.Windows.Forms.Button();
            this.tabSProject = new System.Windows.Forms.TabPage();
            this.cmbSMemberSearch = new System.Windows.Forms.ComboBox();
            this.txtSMSearch = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.cmbPID = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.cmbMID = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.btnRemovefromProject = new System.Windows.Forms.Button();
            this.btnAddtoProject = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.dgvSMember = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.dgvSProject = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProject = new System.Windows.Forms.TabPage();
            this.cmbPSearch = new System.Windows.Forms.ComboBox();
            this.txtPSearch = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PStartingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtpPStart = new System.Windows.Forms.DateTimePicker();
            this.dtpPEnd = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPDescription = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.txtPLeader = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnPEdit = new System.Windows.Forms.Button();
            this.btnPDelete = new System.Windows.Forms.Button();
            this.btnPCancel = new System.Windows.Forms.Button();
            this.btnPSave = new System.Windows.Forms.Button();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.tabMember = new System.Windows.Forms.TabPage();
            this.cmbMSearch = new System.Windows.Forms.ComboBox();
            this.txtMSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.MID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbMGender = new System.Windows.Forms.ComboBox();
            this.dtpMBirth = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMAdress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMID = new System.Windows.Forms.TextBox();
            this.txtMPhone = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.grpMManagement = new System.Windows.Forms.GroupBox();
            this.btnMEdit = new System.Windows.Forms.Button();
            this.btnMDelete = new System.Windows.Forms.Button();
            this.btnMCancel = new System.Windows.Forms.Button();
            this.btnMSave = new System.Windows.Forms.Button();
            this.btnMAdd = new System.Windows.Forms.Button();
            this.grpDivice = new System.Windows.Forms.TabPage();
            this.dgvDivice = new System.Windows.Forms.DataGridView();
            this.DID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDSearch = new System.Windows.Forms.TextBox();
            this.cmbDTypeSearch = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDQuantity = new System.Windows.Forms.TextBox();
            this.txtDBorrowed = new System.Windows.Forms.TextBox();
            this.txtDID = new System.Windows.Forms.TextBox();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.grpDButton = new System.Windows.Forms.GroupBox();
            this.btnDCancel = new System.Windows.Forms.Button();
            this.btnDDelete = new System.Windows.Forms.Button();
            this.btnDSave = new System.Windows.Forms.Button();
            this.btnDAdd = new System.Windows.Forms.Button();
            this.tabInProject = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.tabBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYourBorrow)).BeginInit();
            this.tabBorrowed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowed)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBDAmount)).BeginInit();
            this.grpBDButton.SuspendLayout();
            this.tabSProject.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSMember)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSProject)).BeginInit();
            this.tabProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grpMManagement.SuspendLayout();
            this.grpDivice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivice)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpDButton.SuspendLayout();
            this.tabInProject.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // diviceBindingSource
            // 
            this.diviceBindingSource.DataMember = "Divice";
            this.diviceBindingSource.DataSource = this.deviceManagementDataSet;
            // 
            // deviceManagementDataSet
            // 
            this.deviceManagementDataSet.DataSetName = "DeviceManagementDataSet";
            this.deviceManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.deviceManagementDataSet;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "17547317_1823600271298636_2012264346_o.png");
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AccountTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BorrowedDetailsTableAdapter = null;
            this.tableAdapterManager1.DiviceTableAdapter = null;
            this.tableAdapterManager1.inProjectTableAdapter = null;
            this.tableAdapterManager1.MemberTableAdapter = this.memberTableAdapter;
            this.tableAdapterManager1.ProjectTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = MyProject.DeviceManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabBorrow
            // 
            this.tabBorrow.Controls.Add(this.dgvYourBorrow);
            this.tabBorrow.Controls.Add(this.btnReimburse);
            this.tabBorrow.Controls.Add(this.button1);
            this.tabBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBorrow.Location = new System.Drawing.Point(4, 34);
            this.tabBorrow.Name = "tabBorrow";
            this.tabBorrow.Padding = new System.Windows.Forms.Padding(3);
            this.tabBorrow.Size = new System.Drawing.Size(942, 470);
            this.tabBorrow.TabIndex = 6;
            this.tabBorrow.Text = "Your Borrowed Ticket";
            this.tabBorrow.UseVisualStyleBackColor = true;
            // 
            // dgvYourBorrow
            // 
            this.dgvYourBorrow.AllowUserToAddRows = false;
            this.dgvYourBorrow.AllowUserToDeleteRows = false;
            this.dgvYourBorrow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvYourBorrow.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvYourBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYourBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.amountb,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dgvYourBorrow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvYourBorrow.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvYourBorrow.Location = new System.Drawing.Point(6, 110);
            this.dgvYourBorrow.MultiSelect = false;
            this.dgvYourBorrow.Name = "dgvYourBorrow";
            this.dgvYourBorrow.ReadOnly = true;
            this.dgvYourBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYourBorrow.Size = new System.Drawing.Size(930, 144);
            this.dgvYourBorrow.TabIndex = 3;
            this.dgvYourBorrow.SelectionChanged += new System.EventHandler(this.dgvYourBorrow_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BDID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 46;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Member ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 93;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Divice ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 81;
            // 
            // amountb
            // 
            this.amountb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.amountb.DataPropertyName = "AmountBorrowed";
            this.amountb.HeaderText = "Amount";
            this.amountb.Name = "amountb";
            this.amountb.ReadOnly = true;
            this.amountb.Width = 81;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "BDStartingDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "Starting Date";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 106;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "BDEndDate";
            this.dataGridViewTextBoxColumn12.HeaderText = "End Date";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 85;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "BDManager";
            this.dataGridViewTextBoxColumn13.HeaderText = "Manager";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // btnReimburse
            // 
            this.btnReimburse.Location = new System.Drawing.Point(455, 260);
            this.btnReimburse.Name = "btnReimburse";
            this.btnReimburse.Size = new System.Drawing.Size(154, 34);
            this.btnReimburse.TabIndex = 2;
            this.btnReimburse.Text = "Reimburse";
            this.btnReimburse.UseVisualStyleBackColor = true;
            this.btnReimburse.Click += new System.EventHandler(this.btnReimburse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Borrow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabBorrowed
            // 
            this.tabBorrowed.AutoScroll = true;
            this.tabBorrowed.Controls.Add(this.cmbBSearch);
            this.tabBorrowed.Controls.Add(this.txtBSearch);
            this.tabBorrowed.Controls.Add(this.label26);
            this.tabBorrowed.Controls.Add(this.dgvBorrowed);
            this.tabBorrowed.Controls.Add(this.groupBox9);
            this.tabBorrowed.Controls.Add(this.grpBDButton);
            this.tabBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBorrowed.Location = new System.Drawing.Point(4, 34);
            this.tabBorrowed.Name = "tabBorrowed";
            this.tabBorrowed.Padding = new System.Windows.Forms.Padding(3);
            this.tabBorrowed.Size = new System.Drawing.Size(942, 470);
            this.tabBorrowed.TabIndex = 4;
            this.tabBorrowed.Text = "Borrowed Detail";
            this.tabBorrowed.UseVisualStyleBackColor = true;
            // 
            // cmbBSearch
            // 
            this.cmbBSearch.FormattingEnabled = true;
            this.cmbBSearch.Items.AddRange(new object[] {
            "BD ID",
            "Member ID",
            "Divice ID"});
            this.cmbBSearch.Location = new System.Drawing.Point(514, 169);
            this.cmbBSearch.Name = "cmbBSearch";
            this.cmbBSearch.Size = new System.Drawing.Size(112, 24);
            this.cmbBSearch.TabIndex = 30;
            this.cmbBSearch.Text = "BD ID";
            // 
            // txtBSearch
            // 
            this.txtBSearch.Location = new System.Drawing.Point(333, 170);
            this.txtBSearch.Name = "txtBSearch";
            this.txtBSearch.Size = new System.Drawing.Size(175, 23);
            this.txtBSearch.TabIndex = 29;
            this.txtBSearch.TextChanged += new System.EventHandler(this.txtBSearch_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(274, 173);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 17);
            this.label26.TabIndex = 28;
            this.label26.Text = "Search";
            // 
            // dgvBorrowed
            // 
            this.dgvBorrowed.AllowUserToAddRows = false;
            this.dgvBorrowed.AllowUserToDeleteRows = false;
            this.dgvBorrowed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBorrowed.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BDID,
            this.BDMID,
            this.BDDID,
            this.AB,
            this.BDStartingDate,
            this.BDEndDate,
            this.BDManager});
            this.dgvBorrowed.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvBorrowed.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBorrowed.Location = new System.Drawing.Point(9, 19);
            this.dgvBorrowed.MultiSelect = false;
            this.dgvBorrowed.Name = "dgvBorrowed";
            this.dgvBorrowed.ReadOnly = true;
            this.dgvBorrowed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowed.Size = new System.Drawing.Size(915, 144);
            this.dgvBorrowed.TabIndex = 0;
            this.dgvBorrowed.SelectionChanged += new System.EventHandler(this.dgvBorrowed_SelectionChanged);
            this.dgvBorrowed.Click += new System.EventHandler(this.a);
            // 
            // BDID
            // 
            this.BDID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BDID.DataPropertyName = "BDID";
            this.BDID.HeaderText = "ID";
            this.BDID.Name = "BDID";
            this.BDID.ReadOnly = true;
            this.BDID.Width = 46;
            // 
            // BDMID
            // 
            this.BDMID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BDMID.DataPropertyName = "MID";
            this.BDMID.HeaderText = "Member ID";
            this.BDMID.Name = "BDMID";
            this.BDMID.ReadOnly = true;
            this.BDMID.Width = 93;
            // 
            // BDDID
            // 
            this.BDDID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BDDID.DataPropertyName = "DID";
            this.BDDID.HeaderText = "Divice ID";
            this.BDDID.Name = "BDDID";
            this.BDDID.ReadOnly = true;
            this.BDDID.Width = 81;
            // 
            // AB
            // 
            this.AB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AB.DataPropertyName = "AmountBorrowed";
            this.AB.HeaderText = "Amount";
            this.AB.Name = "AB";
            this.AB.ReadOnly = true;
            this.AB.Width = 81;
            // 
            // BDStartingDate
            // 
            this.BDStartingDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BDStartingDate.DataPropertyName = "BDStartingDate";
            this.BDStartingDate.HeaderText = "Starting Date";
            this.BDStartingDate.Name = "BDStartingDate";
            this.BDStartingDate.ReadOnly = true;
            this.BDStartingDate.Width = 106;
            // 
            // BDEndDate
            // 
            this.BDEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BDEndDate.DataPropertyName = "BDEndDate";
            this.BDEndDate.HeaderText = "End Date";
            this.BDEndDate.Name = "BDEndDate";
            this.BDEndDate.ReadOnly = true;
            this.BDEndDate.Width = 85;
            // 
            // BDManager
            // 
            this.BDManager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BDManager.DataPropertyName = "BDManager";
            this.BDManager.HeaderText = "Manager";
            this.BDManager.Name = "BDManager";
            this.BDManager.ReadOnly = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtMaxAmount);
            this.groupBox9.Controls.Add(this.txtBDAmount);
            this.groupBox9.Controls.Add(this.cmbBDDID);
            this.groupBox9.Controls.Add(this.cmbBDMID);
            this.groupBox9.Controls.Add(this.txtBDManager);
            this.groupBox9.Controls.Add(this.dtpBDStartingDate);
            this.groupBox9.Controls.Add(this.dtpBDEndDate);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.label28);
            this.groupBox9.Controls.Add(this.label29);
            this.groupBox9.Controls.Add(this.label30);
            this.groupBox9.Controls.Add(this.label33);
            this.groupBox9.Controls.Add(this.label34);
            this.groupBox9.Controls.Add(this.label31);
            this.groupBox9.Controls.Add(this.label32);
            this.groupBox9.Controls.Add(this.txtBDID);
            this.groupBox9.Location = new System.Drawing.Point(3, 207);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(505, 246);
            this.groupBox9.TabIndex = 24;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Borrowed Details";
            // 
            // txtMaxAmount
            // 
            this.txtMaxAmount.Enabled = false;
            this.txtMaxAmount.Location = new System.Drawing.Point(292, 132);
            this.txtMaxAmount.Name = "txtMaxAmount";
            this.txtMaxAmount.Size = new System.Drawing.Size(53, 23);
            this.txtMaxAmount.TabIndex = 30;
            // 
            // txtBDAmount
            // 
            this.txtBDAmount.Location = new System.Drawing.Point(103, 135);
            this.txtBDAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtBDAmount.Name = "txtBDAmount";
            this.txtBDAmount.Size = new System.Drawing.Size(58, 23);
            this.txtBDAmount.TabIndex = 29;
            this.txtBDAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbBDDID
            // 
            this.cmbBDDID.DataSource = this.diviceBindingSource;
            this.cmbBDDID.DisplayMember = "DID";
            this.cmbBDDID.Enabled = false;
            this.cmbBDDID.FormattingEnabled = true;
            this.cmbBDDID.Location = new System.Drawing.Point(103, 79);
            this.cmbBDDID.Name = "cmbBDDID";
            this.cmbBDDID.Size = new System.Drawing.Size(106, 24);
            this.cmbBDDID.TabIndex = 28;
            this.cmbBDDID.SelectedIndexChanged += new System.EventHandler(this.cmbBDDID_SelectedIndexChanged);
            // 
            // cmbBDMID
            // 
            this.cmbBDMID.DataSource = this.memberBindingSource;
            this.cmbBDMID.DisplayMember = "MID";
            this.cmbBDMID.Enabled = false;
            this.cmbBDMID.FormattingEnabled = true;
            this.cmbBDMID.Location = new System.Drawing.Point(103, 50);
            this.cmbBDMID.Name = "cmbBDMID";
            this.cmbBDMID.Size = new System.Drawing.Size(106, 24);
            this.cmbBDMID.TabIndex = 27;
            this.cmbBDMID.SelectedIndexChanged += new System.EventHandler(this.cmbBDMID_SelectedIndexChanged);
            // 
            // txtBDManager
            // 
            this.txtBDManager.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBDManager.Location = new System.Drawing.Point(103, 109);
            this.txtBDManager.Multiline = true;
            this.txtBDManager.Name = "txtBDManager";
            this.txtBDManager.ReadOnly = true;
            this.txtBDManager.Size = new System.Drawing.Size(106, 20);
            this.txtBDManager.TabIndex = 9;
            // 
            // dtpBDStartingDate
            // 
            this.dtpBDStartingDate.CustomFormat = "MM-dd-yyyy";
            this.dtpBDStartingDate.Enabled = false;
            this.dtpBDStartingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBDStartingDate.Location = new System.Drawing.Point(103, 168);
            this.dtpBDStartingDate.Name = "dtpBDStartingDate";
            this.dtpBDStartingDate.Size = new System.Drawing.Size(110, 23);
            this.dtpBDStartingDate.TabIndex = 8;
            this.dtpBDStartingDate.Value = new System.DateTime(2017, 4, 13, 0, 0, 0, 0);
            // 
            // dtpBDEndDate
            // 
            this.dtpBDEndDate.CustomFormat = "MM-dd-yyyy";
            this.dtpBDEndDate.Enabled = false;
            this.dtpBDEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBDEndDate.Location = new System.Drawing.Point(292, 169);
            this.dtpBDEndDate.Name = "dtpBDEndDate";
            this.dtpBDEndDate.Size = new System.Drawing.Size(110, 23);
            this.dtpBDEndDate.TabIndex = 4;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 108);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(64, 17);
            this.label27.TabIndex = 1;
            this.label27.Text = "Manager";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(219, 173);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 17);
            this.label28.TabIndex = 1;
            this.label28.Text = "End Date";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 174);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(91, 17);
            this.label29.TabIndex = 1;
            this.label29.Text = "Starting Date";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(9, 22);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(44, 17);
            this.label30.TabIndex = 1;
            this.label30.Text = "BD ID";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(9, 82);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(63, 17);
            this.label33.TabIndex = 1;
            this.label33.Text = "Divice ID";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(211, 135);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(75, 17);
            this.label34.TabIndex = 1;
            this.label34.Text = "Remaining";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(9, 141);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 17);
            this.label31.TabIndex = 1;
            this.label31.Text = "Amount";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(9, 53);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(76, 17);
            this.label32.TabIndex = 1;
            this.label32.Text = "Member ID";
            // 
            // txtBDID
            // 
            this.txtBDID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBDID.Enabled = false;
            this.txtBDID.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtBDID.Location = new System.Drawing.Point(103, 16);
            this.txtBDID.Name = "txtBDID";
            this.txtBDID.ReadOnly = true;
            this.txtBDID.Size = new System.Drawing.Size(304, 23);
            this.txtBDID.TabIndex = 1;
            // 
            // grpBDButton
            // 
            this.grpBDButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBDButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpBDButton.Controls.Add(this.btnBDDelete);
            this.grpBDButton.Controls.Add(this.btnBDCancel);
            this.grpBDButton.Controls.Add(this.btnBDSave);
            this.grpBDButton.Controls.Add(this.btnBDAdd);
            this.grpBDButton.Location = new System.Drawing.Point(514, 207);
            this.grpBDButton.Name = "grpBDButton";
            this.grpBDButton.Size = new System.Drawing.Size(410, 246);
            this.grpBDButton.TabIndex = 23;
            this.grpBDButton.TabStop = false;
            this.grpBDButton.Text = "Borrowed Manament";
            // 
            // btnBDDelete
            // 
            this.btnBDDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnBDDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBDDelete.Location = new System.Drawing.Point(100, 79);
            this.btnBDDelete.Name = "btnBDDelete";
            this.btnBDDelete.Size = new System.Drawing.Size(246, 37);
            this.btnBDDelete.TabIndex = 0;
            this.btnBDDelete.Text = "Delete";
            this.btnBDDelete.UseVisualStyleBackColor = false;
            this.btnBDDelete.Click += new System.EventHandler(this.btnBDDelete_Click);
            // 
            // btnBDCancel
            // 
            this.btnBDCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnBDCancel.Enabled = false;
            this.btnBDCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBDCancel.Location = new System.Drawing.Point(100, 203);
            this.btnBDCancel.Name = "btnBDCancel";
            this.btnBDCancel.Size = new System.Drawing.Size(246, 37);
            this.btnBDCancel.TabIndex = 0;
            this.btnBDCancel.Text = "Cancel";
            this.btnBDCancel.UseVisualStyleBackColor = false;
            this.btnBDCancel.Click += new System.EventHandler(this.btnBDCancel_Click);
            // 
            // btnBDSave
            // 
            this.btnBDSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnBDSave.Enabled = false;
            this.btnBDSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBDSave.Location = new System.Drawing.Point(100, 141);
            this.btnBDSave.Name = "btnBDSave";
            this.btnBDSave.Size = new System.Drawing.Size(246, 37);
            this.btnBDSave.TabIndex = 0;
            this.btnBDSave.Text = "Save";
            this.btnBDSave.UseVisualStyleBackColor = false;
            this.btnBDSave.Click += new System.EventHandler(this.btnBDSave_Click);
            // 
            // btnBDAdd
            // 
            this.btnBDAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnBDAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBDAdd.Location = new System.Drawing.Point(100, 22);
            this.btnBDAdd.Name = "btnBDAdd";
            this.btnBDAdd.Size = new System.Drawing.Size(246, 37);
            this.btnBDAdd.TabIndex = 0;
            this.btnBDAdd.Text = "Add";
            this.btnBDAdd.UseVisualStyleBackColor = false;
            this.btnBDAdd.Click += new System.EventHandler(this.btnBDAdd_Click);
            // 
            // tabSProject
            // 
            this.tabSProject.AutoScroll = true;
            this.tabSProject.Controls.Add(this.cmbSMemberSearch);
            this.tabSProject.Controls.Add(this.txtSMSearch);
            this.tabSProject.Controls.Add(this.groupBox14);
            this.tabSProject.Controls.Add(this.btnRemovefromProject);
            this.tabSProject.Controls.Add(this.btnAddtoProject);
            this.tabSProject.Controls.Add(this.groupBox13);
            this.tabSProject.Controls.Add(this.groupBox12);
            this.tabSProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSProject.Location = new System.Drawing.Point(4, 34);
            this.tabSProject.Name = "tabSProject";
            this.tabSProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabSProject.Size = new System.Drawing.Size(942, 470);
            this.tabSProject.TabIndex = 5;
            this.tabSProject.Text = "YourProject";
            this.tabSProject.UseVisualStyleBackColor = true;
            // 
            // cmbSMemberSearch
            // 
            this.cmbSMemberSearch.FormattingEnabled = true;
            this.cmbSMemberSearch.Items.AddRange(new object[] {
            "Member ID",
            "Member Name"});
            this.cmbSMemberSearch.Location = new System.Drawing.Point(733, 381);
            this.cmbSMemberSearch.Name = "cmbSMemberSearch";
            this.cmbSMemberSearch.Size = new System.Drawing.Size(102, 24);
            this.cmbSMemberSearch.TabIndex = 23;
            this.cmbSMemberSearch.Text = "Member ID";
            // 
            // txtSMSearch
            // 
            this.txtSMSearch.Location = new System.Drawing.Point(552, 381);
            this.txtSMSearch.Name = "txtSMSearch";
            this.txtSMSearch.Size = new System.Drawing.Size(175, 23);
            this.txtSMSearch.TabIndex = 22;
            this.txtSMSearch.TextChanged += new System.EventHandler(this.txtSMSearch_TextChanged);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.cmbPID);
            this.groupBox14.Controls.Add(this.cmbType);
            this.groupBox14.Controls.Add(this.label35);
            this.groupBox14.Controls.Add(this.cmbMID);
            this.groupBox14.Controls.Add(this.label36);
            this.groupBox14.Controls.Add(this.label37);
            this.groupBox14.Location = new System.Drawing.Point(6, 236);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(459, 139);
            this.groupBox14.TabIndex = 20;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Leader Management";
            // 
            // cmbPID
            // 
            this.cmbPID.Enabled = false;
            this.cmbPID.FormattingEnabled = true;
            this.cmbPID.Location = new System.Drawing.Point(191, 28);
            this.cmbPID.Name = "cmbPID";
            this.cmbPID.Size = new System.Drawing.Size(149, 24);
            this.cmbPID.TabIndex = 19;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Leader",
            "Member"});
            this.cmbType.Location = new System.Drawing.Point(191, 88);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 24);
            this.cmbType.TabIndex = 19;
            this.cmbType.Text = "Member";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(106, 31);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(69, 17);
            this.label35.TabIndex = 18;
            this.label35.Text = "Project ID";
            this.label35.Click += new System.EventHandler(this.label35_Click);
            // 
            // cmbMID
            // 
            this.cmbMID.DataSource = this.memberBindingSource;
            this.cmbMID.DisplayMember = "MID";
            this.cmbMID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMID.FormattingEnabled = true;
            this.cmbMID.Location = new System.Drawing.Point(191, 58);
            this.cmbMID.Name = "cmbMID";
            this.cmbMID.Size = new System.Drawing.Size(149, 24);
            this.cmbMID.TabIndex = 19;
            this.cmbMID.ValueMember = "MID";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(106, 61);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(76, 17);
            this.label36.TabIndex = 18;
            this.label36.Text = "Member ID";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(106, 91);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(40, 17);
            this.label37.TabIndex = 18;
            this.label37.Text = "Type";
            // 
            // btnRemovefromProject
            // 
            this.btnRemovefromProject.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemovefromProject.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemovefromProject.Location = new System.Drawing.Point(239, 381);
            this.btnRemovefromProject.Name = "btnRemovefromProject";
            this.btnRemovefromProject.Size = new System.Drawing.Size(197, 37);
            this.btnRemovefromProject.TabIndex = 16;
            this.btnRemovefromProject.Text = "Remove";
            this.btnRemovefromProject.UseVisualStyleBackColor = false;
            this.btnRemovefromProject.Click += new System.EventHandler(this.btnRemovefromProject_Click);
            // 
            // btnAddtoProject
            // 
            this.btnAddtoProject.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddtoProject.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddtoProject.Location = new System.Drawing.Point(36, 381);
            this.btnAddtoProject.Name = "btnAddtoProject";
            this.btnAddtoProject.Size = new System.Drawing.Size(197, 37);
            this.btnAddtoProject.TabIndex = 17;
            this.btnAddtoProject.Text = "Add";
            this.btnAddtoProject.UseVisualStyleBackColor = false;
            this.btnAddtoProject.Click += new System.EventHandler(this.btnAddtoProject_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.dgvSMember);
            this.groupBox13.Location = new System.Drawing.Point(471, 64);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(465, 311);
            this.groupBox13.TabIndex = 15;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "List Member";
            // 
            // dgvSMember
            // 
            this.dgvSMember.AllowUserToAddRows = false;
            this.dgvSMember.AllowUserToDeleteRows = false;
            this.dgvSMember.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn9});
            this.dgvSMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSMember.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvSMember.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSMember.Location = new System.Drawing.Point(3, 19);
            this.dgvSMember.MultiSelect = false;
            this.dgvSMember.Name = "dgvSMember";
            this.dgvSMember.ReadOnly = true;
            this.dgvSMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSMember.Size = new System.Drawing.Size(459, 289);
            this.dgvSMember.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Member ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Member Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn9.HeaderText = "Type";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox12.Controls.Add(this.dgvSProject);
            this.groupBox12.Location = new System.Drawing.Point(3, 64);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(465, 166);
            this.groupBox12.TabIndex = 14;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "List Project";
            // 
            // dgvSProject
            // 
            this.dgvSProject.AllowUserToAddRows = false;
            this.dgvSProject.AllowUserToDeleteRows = false;
            this.dgvSProject.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.dgvSProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSProject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvSProject.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSProject.Location = new System.Drawing.Point(3, 19);
            this.dgvSProject.MultiSelect = false;
            this.dgvSProject.Name = "dgvSProject";
            this.dgvSProject.ReadOnly = true;
            this.dgvSProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSProject.Size = new System.Drawing.Size(459, 144);
            this.dgvSProject.TabIndex = 0;
            this.dgvSProject.SelectionChanged += new System.EventHandler(this.dgvSProject_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Project ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Project Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PLeader";
            this.dataGridViewTextBoxColumn5.HeaderText = "Leader";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // tabProject
            // 
            this.tabProject.AutoScroll = true;
            this.tabProject.Controls.Add(this.cmbPSearch);
            this.tabProject.Controls.Add(this.txtPSearch);
            this.tabProject.Controls.Add(this.label18);
            this.tabProject.Controls.Add(this.dgvProject);
            this.tabProject.Controls.Add(this.groupBox6);
            this.tabProject.Controls.Add(this.groupBox7);
            this.tabProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProject.Location = new System.Drawing.Point(4, 34);
            this.tabProject.Name = "tabProject";
            this.tabProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabProject.Size = new System.Drawing.Size(942, 470);
            this.tabProject.TabIndex = 2;
            this.tabProject.Text = "Project";
            this.tabProject.UseVisualStyleBackColor = true;
            this.tabProject.TextChanged += new System.EventHandler(this.SearchProject);
            // 
            // cmbPSearch
            // 
            this.cmbPSearch.FormattingEnabled = true;
            this.cmbPSearch.Items.AddRange(new object[] {
            "Project ID",
            "Project Name"});
            this.cmbPSearch.Location = new System.Drawing.Point(490, 174);
            this.cmbPSearch.Name = "cmbPSearch";
            this.cmbPSearch.Size = new System.Drawing.Size(102, 24);
            this.cmbPSearch.TabIndex = 23;
            this.cmbPSearch.Text = "Project ID";
            // 
            // txtPSearch
            // 
            this.txtPSearch.Location = new System.Drawing.Point(309, 175);
            this.txtPSearch.Name = "txtPSearch";
            this.txtPSearch.Size = new System.Drawing.Size(175, 23);
            this.txtPSearch.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(250, 177);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 17);
            this.label18.TabIndex = 21;
            this.label18.Text = "Search";
            // 
            // dgvProject
            // 
            this.dgvProject.AllowUserToAddRows = false;
            this.dgvProject.AllowUserToDeleteRows = false;
            this.dgvProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProject.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.PName,
            this.PStartingDate,
            this.PEndDate,
            this.PLeader,
            this.PDescription});
            this.dgvProject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvProject.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProject.Location = new System.Drawing.Point(9, 25);
            this.dgvProject.MultiSelect = false;
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.ReadOnly = true;
            this.dgvProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProject.Size = new System.Drawing.Size(924, 144);
            this.dgvProject.TabIndex = 0;
            this.dgvProject.SelectionChanged += new System.EventHandler(this.dgvProject_SelectionChanged);
            // 
            // PID
            // 
            this.PID.DataPropertyName = "PID";
            this.PID.HeaderText = "Project ID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "PName";
            this.PName.HeaderText = "Project Name";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Width = 150;
            // 
            // PStartingDate
            // 
            this.PStartingDate.DataPropertyName = "PStartingDate";
            this.PStartingDate.HeaderText = "Starting Date";
            this.PStartingDate.Name = "PStartingDate";
            this.PStartingDate.ReadOnly = true;
            this.PStartingDate.Width = 125;
            // 
            // PEndDate
            // 
            this.PEndDate.DataPropertyName = "PEndDate";
            this.PEndDate.HeaderText = "End Date";
            this.PEndDate.Name = "PEndDate";
            this.PEndDate.ReadOnly = true;
            // 
            // PLeader
            // 
            this.PLeader.DataPropertyName = "PLeader";
            this.PLeader.HeaderText = "Leader";
            this.PLeader.Name = "PLeader";
            this.PLeader.ReadOnly = true;
            // 
            // PDescription
            // 
            this.PDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PDescription.DataPropertyName = "PDescription";
            this.PDescription.HeaderText = "Description";
            this.PDescription.Name = "PDescription";
            this.PDescription.ReadOnly = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtpPStart);
            this.groupBox6.Controls.Add(this.dtpPEnd);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.txtPDescription);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.txtPID);
            this.groupBox6.Controls.Add(this.txtPLeader);
            this.groupBox6.Controls.Add(this.txtPName);
            this.groupBox6.Location = new System.Drawing.Point(3, 207);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(505, 244);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Project Detail";
            // 
            // dtpPStart
            // 
            this.dtpPStart.CustomFormat = "MM-dd-yyyy";
            this.dtpPStart.Enabled = false;
            this.dtpPStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPStart.Location = new System.Drawing.Point(128, 81);
            this.dtpPStart.Name = "dtpPStart";
            this.dtpPStart.Size = new System.Drawing.Size(304, 23);
            this.dtpPStart.TabIndex = 8;
            this.dtpPStart.Value = new System.DateTime(2017, 4, 13, 0, 0, 0, 0);
            // 
            // dtpPEnd
            // 
            this.dtpPEnd.CustomFormat = "MM-dd-yyyy";
            this.dtpPEnd.Enabled = false;
            this.dtpPEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPEnd.Location = new System.Drawing.Point(128, 110);
            this.dtpPEnd.Name = "dtpPEnd";
            this.dtpPEnd.Size = new System.Drawing.Size(304, 23);
            this.dtpPEnd.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 137);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Leader";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 110);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 17);
            this.label20.TabIndex = 1;
            this.label20.Text = "End Date";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 84);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 17);
            this.label21.TabIndex = 1;
            this.label21.Text = "Starting Date";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 29);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 17);
            this.label22.TabIndex = 1;
            this.label22.Text = "Project ID";
            // 
            // txtPDescription
            // 
            this.txtPDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPDescription.Location = new System.Drawing.Point(128, 175);
            this.txtPDescription.Multiline = true;
            this.txtPDescription.Name = "txtPDescription";
            this.txtPDescription.ReadOnly = true;
            this.txtPDescription.Size = new System.Drawing.Size(304, 53);
            this.txtPDescription.TabIndex = 7;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 171);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 17);
            this.label24.TabIndex = 1;
            this.label24.Text = "Description";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 55);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(93, 17);
            this.label25.TabIndex = 1;
            this.label25.Text = "Project Name";
            // 
            // txtPID
            // 
            this.txtPID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPID.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPID.Location = new System.Drawing.Point(128, 22);
            this.txtPID.Name = "txtPID";
            this.txtPID.ReadOnly = true;
            this.txtPID.Size = new System.Drawing.Size(304, 23);
            this.txtPID.TabIndex = 1;
            // 
            // txtPLeader
            // 
            this.txtPLeader.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPLeader.Location = new System.Drawing.Point(128, 141);
            this.txtPLeader.Multiline = true;
            this.txtPLeader.Name = "txtPLeader";
            this.txtPLeader.ReadOnly = true;
            this.txtPLeader.Size = new System.Drawing.Size(304, 28);
            this.txtPLeader.TabIndex = 5;
            // 
            // txtPName
            // 
            this.txtPName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPName.Location = new System.Drawing.Point(128, 52);
            this.txtPName.Multiline = true;
            this.txtPName.Name = "txtPName";
            this.txtPName.ReadOnly = true;
            this.txtPName.Size = new System.Drawing.Size(304, 20);
            this.txtPName.TabIndex = 2;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox7.Controls.Add(this.btnPEdit);
            this.groupBox7.Controls.Add(this.btnPDelete);
            this.groupBox7.Controls.Add(this.btnPCancel);
            this.groupBox7.Controls.Add(this.btnPSave);
            this.groupBox7.Controls.Add(this.btnPAdd);
            this.groupBox7.Location = new System.Drawing.Point(514, 207);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(419, 244);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Project Management";
            // 
            // btnPEdit
            // 
            this.btnPEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnPEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPEdit.Location = new System.Drawing.Point(41, 62);
            this.btnPEdit.Name = "btnPEdit";
            this.btnPEdit.Size = new System.Drawing.Size(246, 37);
            this.btnPEdit.TabIndex = 0;
            this.btnPEdit.Text = "Edit";
            this.btnPEdit.UseVisualStyleBackColor = false;
            this.btnPEdit.Click += new System.EventHandler(this.btnPEdit_Click);
            // 
            // btnPDelete
            // 
            this.btnPDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnPDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPDelete.Location = new System.Drawing.Point(41, 105);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(246, 37);
            this.btnPDelete.TabIndex = 0;
            this.btnPDelete.Text = "Delete";
            this.btnPDelete.UseVisualStyleBackColor = false;
            this.btnPDelete.Click += new System.EventHandler(this.btnPDelete_Click);
            // 
            // btnPCancel
            // 
            this.btnPCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnPCancel.Enabled = false;
            this.btnPCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPCancel.Location = new System.Drawing.Point(41, 191);
            this.btnPCancel.Name = "btnPCancel";
            this.btnPCancel.Size = new System.Drawing.Size(246, 37);
            this.btnPCancel.TabIndex = 0;
            this.btnPCancel.Text = "Cancel";
            this.btnPCancel.UseVisualStyleBackColor = false;
            this.btnPCancel.Click += new System.EventHandler(this.btnPCancel_Click);
            // 
            // btnPSave
            // 
            this.btnPSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnPSave.Enabled = false;
            this.btnPSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPSave.Location = new System.Drawing.Point(41, 148);
            this.btnPSave.Name = "btnPSave";
            this.btnPSave.Size = new System.Drawing.Size(246, 37);
            this.btnPSave.TabIndex = 0;
            this.btnPSave.Text = "Save";
            this.btnPSave.UseVisualStyleBackColor = false;
            this.btnPSave.Click += new System.EventHandler(this.btnPSave_Click);
            // 
            // btnPAdd
            // 
            this.btnPAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnPAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPAdd.Location = new System.Drawing.Point(41, 19);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(246, 37);
            this.btnPAdd.TabIndex = 0;
            this.btnPAdd.Text = "Add";
            this.btnPAdd.UseVisualStyleBackColor = false;
            this.btnPAdd.Click += new System.EventHandler(this.btnPAdd_Click);
            // 
            // tabMember
            // 
            this.tabMember.AutoScroll = true;
            this.tabMember.Controls.Add(this.cmbMSearch);
            this.tabMember.Controls.Add(this.txtMSearch);
            this.tabMember.Controls.Add(this.label9);
            this.tabMember.Controls.Add(this.dgvMember);
            this.tabMember.Controls.Add(this.groupBox3);
            this.tabMember.Controls.Add(this.grpMManagement);
            this.tabMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMember.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tabMember.Location = new System.Drawing.Point(4, 34);
            this.tabMember.Name = "tabMember";
            this.tabMember.Padding = new System.Windows.Forms.Padding(3);
            this.tabMember.Size = new System.Drawing.Size(942, 470);
            this.tabMember.TabIndex = 1;
            this.tabMember.Text = "Member";
            this.tabMember.UseVisualStyleBackColor = true;
            // 
            // cmbMSearch
            // 
            this.cmbMSearch.FormattingEnabled = true;
            this.cmbMSearch.Items.AddRange(new object[] {
            "Member ID",
            "Member Name"});
            this.cmbMSearch.Location = new System.Drawing.Point(474, 171);
            this.cmbMSearch.Name = "cmbMSearch";
            this.cmbMSearch.Size = new System.Drawing.Size(102, 24);
            this.cmbMSearch.TabIndex = 16;
            this.cmbMSearch.Text = "Member ID";
            // 
            // txtMSearch
            // 
            this.txtMSearch.Location = new System.Drawing.Point(293, 171);
            this.txtMSearch.Name = "txtMSearch";
            this.txtMSearch.Size = new System.Drawing.Size(175, 23);
            this.txtMSearch.TabIndex = 15;
            this.txtMSearch.TextChanged += new System.EventHandler(this.SearchMember);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Search";
            // 
            // dgvMember
            // 
            this.dgvMember.AllowUserToAddRows = false;
            this.dgvMember.AllowUserToDeleteRows = false;
            this.dgvMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMember.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MID,
            this.MName,
            this.MGender,
            this.MBirth,
            this.MPhone,
            this.MEmail,
            this.MAdress});
            this.dgvMember.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvMember.GridColor = System.Drawing.SystemColors.Control;
            this.dgvMember.Location = new System.Drawing.Point(6, 21);
            this.dgvMember.MultiSelect = false;
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.ReadOnly = true;
            this.dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMember.Size = new System.Drawing.Size(930, 144);
            this.dgvMember.TabIndex = 0;
            this.dgvMember.SelectionChanged += new System.EventHandler(this.dgvMember_SelectionChanged);
            // 
            // MID
            // 
            this.MID.DataPropertyName = "MID";
            this.MID.HeaderText = "Member ID";
            this.MID.Name = "MID";
            this.MID.ReadOnly = true;
            // 
            // MName
            // 
            this.MName.DataPropertyName = "MName";
            this.MName.HeaderText = "Member Name";
            this.MName.Name = "MName";
            this.MName.ReadOnly = true;
            this.MName.Width = 150;
            // 
            // MGender
            // 
            this.MGender.DataPropertyName = "MGender";
            this.MGender.HeaderText = "Gender";
            this.MGender.Name = "MGender";
            this.MGender.ReadOnly = true;
            // 
            // MBirth
            // 
            this.MBirth.DataPropertyName = "MBirth";
            this.MBirth.HeaderText = "Birth";
            this.MBirth.Name = "MBirth";
            this.MBirth.ReadOnly = true;
            // 
            // MPhone
            // 
            this.MPhone.DataPropertyName = "MPhone";
            this.MPhone.HeaderText = "Phone";
            this.MPhone.Name = "MPhone";
            this.MPhone.ReadOnly = true;
            // 
            // MEmail
            // 
            this.MEmail.DataPropertyName = "MEmail";
            this.MEmail.HeaderText = "Email";
            this.MEmail.Name = "MEmail";
            this.MEmail.ReadOnly = true;
            // 
            // MAdress
            // 
            this.MAdress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAdress.DataPropertyName = "MAdress";
            this.MAdress.HeaderText = "Adress";
            this.MAdress.Name = "MAdress";
            this.MAdress.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox3.Controls.Add(this.cmbMGender);
            this.groupBox3.Controls.Add(this.dtpMBirth);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtMEmail);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtMAdress);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtMID);
            this.groupBox3.Controls.Add(this.txtMPhone);
            this.groupBox3.Controls.Add(this.txtMName);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(6, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 268);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Member Details";
            // 
            // cmbMGender
            // 
            this.cmbMGender.Enabled = false;
            this.cmbMGender.FormattingEnabled = true;
            this.cmbMGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbMGender.Location = new System.Drawing.Point(128, 78);
            this.cmbMGender.Name = "cmbMGender";
            this.cmbMGender.Size = new System.Drawing.Size(209, 24);
            this.cmbMGender.TabIndex = 3;
            this.cmbMGender.Text = "Male";
            // 
            // dtpMBirth
            // 
            this.dtpMBirth.CustomFormat = "MM-dd-yyyy";
            this.dtpMBirth.Enabled = false;
            this.dtpMBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMBirth.Location = new System.Drawing.Point(128, 110);
            this.dtpMBirth.Name = "dtpMBirth";
            this.dtpMBirth.Size = new System.Drawing.Size(304, 23);
            this.dtpMBirth.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Phone";
            // 
            // txtMEmail
            // 
            this.txtMEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMEmail.Location = new System.Drawing.Point(128, 175);
            this.txtMEmail.Multiline = true;
            this.txtMEmail.Name = "txtMEmail";
            this.txtMEmail.ReadOnly = true;
            this.txtMEmail.Size = new System.Drawing.Size(304, 29);
            this.txtMEmail.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Birth";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Gender";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Member ID";
            // 
            // txtMAdress
            // 
            this.txtMAdress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMAdress.Location = new System.Drawing.Point(128, 210);
            this.txtMAdress.Multiline = true;
            this.txtMAdress.Name = "txtMAdress";
            this.txtMAdress.ReadOnly = true;
            this.txtMAdress.Size = new System.Drawing.Size(304, 52);
            this.txtMAdress.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Adress";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "EMail";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Member Name";
            // 
            // txtMID
            // 
            this.txtMID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMID.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtMID.Location = new System.Drawing.Point(128, 22);
            this.txtMID.Name = "txtMID";
            this.txtMID.ReadOnly = true;
            this.txtMID.Size = new System.Drawing.Size(304, 23);
            this.txtMID.TabIndex = 1;
            // 
            // txtMPhone
            // 
            this.txtMPhone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMPhone.Location = new System.Drawing.Point(128, 141);
            this.txtMPhone.Multiline = true;
            this.txtMPhone.Name = "txtMPhone";
            this.txtMPhone.ReadOnly = true;
            this.txtMPhone.Size = new System.Drawing.Size(304, 28);
            this.txtMPhone.TabIndex = 5;
            // 
            // txtMName
            // 
            this.txtMName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMName.Location = new System.Drawing.Point(128, 52);
            this.txtMName.Multiline = true;
            this.txtMName.Name = "txtMName";
            this.txtMName.ReadOnly = true;
            this.txtMName.Size = new System.Drawing.Size(304, 20);
            this.txtMName.TabIndex = 2;
            // 
            // grpMManagement
            // 
            this.grpMManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMManagement.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpMManagement.Controls.Add(this.btnMEdit);
            this.grpMManagement.Controls.Add(this.btnMDelete);
            this.grpMManagement.Controls.Add(this.btnMCancel);
            this.grpMManagement.Controls.Add(this.btnMSave);
            this.grpMManagement.Controls.Add(this.btnMAdd);
            this.grpMManagement.Location = new System.Drawing.Point(518, 201);
            this.grpMManagement.Name = "grpMManagement";
            this.grpMManagement.Size = new System.Drawing.Size(424, 268);
            this.grpMManagement.TabIndex = 9;
            this.grpMManagement.TabStop = false;
            this.grpMManagement.Text = "Member Manament";
            // 
            // btnMEdit
            // 
            this.btnMEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnMEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMEdit.Location = new System.Drawing.Point(59, 62);
            this.btnMEdit.Name = "btnMEdit";
            this.btnMEdit.Size = new System.Drawing.Size(246, 37);
            this.btnMEdit.TabIndex = 0;
            this.btnMEdit.Text = "Edit";
            this.btnMEdit.UseVisualStyleBackColor = false;
            this.btnMEdit.Click += new System.EventHandler(this.btnMEdit_Click);
            // 
            // btnMDelete
            // 
            this.btnMDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnMDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMDelete.Location = new System.Drawing.Point(59, 105);
            this.btnMDelete.Name = "btnMDelete";
            this.btnMDelete.Size = new System.Drawing.Size(246, 37);
            this.btnMDelete.TabIndex = 0;
            this.btnMDelete.Text = "Delete";
            this.btnMDelete.UseVisualStyleBackColor = false;
            this.btnMDelete.Click += new System.EventHandler(this.btnMDelete_Click);
            // 
            // btnMCancel
            // 
            this.btnMCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnMCancel.Enabled = false;
            this.btnMCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMCancel.Location = new System.Drawing.Point(59, 191);
            this.btnMCancel.Name = "btnMCancel";
            this.btnMCancel.Size = new System.Drawing.Size(246, 37);
            this.btnMCancel.TabIndex = 0;
            this.btnMCancel.Text = "Cancel";
            this.btnMCancel.UseVisualStyleBackColor = false;
            this.btnMCancel.Click += new System.EventHandler(this.btnMCancel_Click);
            // 
            // btnMSave
            // 
            this.btnMSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnMSave.Enabled = false;
            this.btnMSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMSave.Location = new System.Drawing.Point(59, 148);
            this.btnMSave.Name = "btnMSave";
            this.btnMSave.Size = new System.Drawing.Size(246, 37);
            this.btnMSave.TabIndex = 0;
            this.btnMSave.Text = "Save";
            this.btnMSave.UseVisualStyleBackColor = false;
            this.btnMSave.Click += new System.EventHandler(this.btnMSave_Click);
            // 
            // btnMAdd
            // 
            this.btnMAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnMAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMAdd.ImageIndex = 0;
            this.btnMAdd.ImageList = this.imageList1;
            this.btnMAdd.Location = new System.Drawing.Point(59, 15);
            this.btnMAdd.Name = "btnMAdd";
            this.btnMAdd.Size = new System.Drawing.Size(246, 37);
            this.btnMAdd.TabIndex = 0;
            this.btnMAdd.Text = "Add";
            this.btnMAdd.UseVisualStyleBackColor = false;
            this.btnMAdd.Click += new System.EventHandler(this.btnMAdd_Click);
            // 
            // grpDivice
            // 
            this.grpDivice.AutoScroll = true;
            this.grpDivice.Controls.Add(this.dgvDivice);
            this.grpDivice.Controls.Add(this.label7);
            this.grpDivice.Controls.Add(this.txtDSearch);
            this.grpDivice.Controls.Add(this.cmbDTypeSearch);
            this.grpDivice.Controls.Add(this.groupBox2);
            this.grpDivice.Controls.Add(this.grpDButton);
            this.grpDivice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDivice.Location = new System.Drawing.Point(4, 34);
            this.grpDivice.Name = "grpDivice";
            this.grpDivice.Padding = new System.Windows.Forms.Padding(3);
            this.grpDivice.Size = new System.Drawing.Size(942, 470);
            this.grpDivice.TabIndex = 0;
            this.grpDivice.Text = "Divice";
            this.grpDivice.UseVisualStyleBackColor = true;
            // 
            // dgvDivice
            // 
            this.dgvDivice.AllowUserToAddRows = false;
            this.dgvDivice.AllowUserToDeleteRows = false;
            this.dgvDivice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDivice.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDivice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDivice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DID,
            this.DName,
            this.DQuantity,
            this.DBorrowed,
            this.DDescription});
            this.dgvDivice.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvDivice.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDivice.Location = new System.Drawing.Point(6, 22);
            this.dgvDivice.MultiSelect = false;
            this.dgvDivice.Name = "dgvDivice";
            this.dgvDivice.ReadOnly = true;
            this.dgvDivice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDivice.Size = new System.Drawing.Size(906, 144);
            this.dgvDivice.TabIndex = 0;
            this.dgvDivice.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // DID
            // 
            this.DID.DataPropertyName = "DID";
            this.DID.HeaderText = "Divice ID";
            this.DID.Name = "DID";
            this.DID.ReadOnly = true;
            // 
            // DName
            // 
            this.DName.DataPropertyName = "DName";
            this.DName.HeaderText = "Divice Name";
            this.DName.Name = "DName";
            this.DName.ReadOnly = true;
            this.DName.Width = 150;
            // 
            // DQuantity
            // 
            this.DQuantity.DataPropertyName = "DQuantity";
            this.DQuantity.HeaderText = "Quantity";
            this.DQuantity.Name = "DQuantity";
            this.DQuantity.ReadOnly = true;
            this.DQuantity.Width = 75;
            // 
            // DBorrowed
            // 
            this.DBorrowed.DataPropertyName = "DBorrowed";
            this.DBorrowed.HeaderText = "Borrowed";
            this.DBorrowed.Name = "DBorrowed";
            this.DBorrowed.ReadOnly = true;
            this.DBorrowed.Width = 75;
            // 
            // DDescription
            // 
            this.DDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DDescription.DataPropertyName = "DDescription";
            this.DDescription.HeaderText = "Description";
            this.DDescription.Name = "DDescription";
            this.DDescription.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Search";
            // 
            // txtDSearch
            // 
            this.txtDSearch.Location = new System.Drawing.Point(301, 188);
            this.txtDSearch.Name = "txtDSearch";
            this.txtDSearch.Size = new System.Drawing.Size(175, 22);
            this.txtDSearch.TabIndex = 3;
            this.txtDSearch.TextChanged += new System.EventHandler(this.SearchDivice);
            // 
            // cmbDTypeSearch
            // 
            this.cmbDTypeSearch.FormattingEnabled = true;
            this.cmbDTypeSearch.Items.AddRange(new object[] {
            "Divice ID",
            "Divice Name"});
            this.cmbDTypeSearch.Location = new System.Drawing.Point(482, 187);
            this.cmbDTypeSearch.Name = "cmbDTypeSearch";
            this.cmbDTypeSearch.Size = new System.Drawing.Size(104, 24);
            this.cmbDTypeSearch.TabIndex = 5;
            this.cmbDTypeSearch.Text = "Divice ID";
            this.cmbDTypeSearch.TextChanged += new System.EventHandler(this.SearchDivice);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtRemaining);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDDescription);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDQuantity);
            this.groupBox2.Controls.Add(this.txtDBorrowed);
            this.groupBox2.Controls.Add(this.txtDID);
            this.groupBox2.Controls.Add(this.txtDName);
            this.groupBox2.Location = new System.Drawing.Point(9, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Divice Management";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Device Remaining";
            // 
            // txtRemaining
            // 
            this.txtRemaining.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRemaining.Enabled = false;
            this.txtRemaining.Location = new System.Drawing.Point(346, 81);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.ReadOnly = true;
            this.txtRemaining.Size = new System.Drawing.Size(48, 22);
            this.txtRemaining.TabIndex = 8;
            this.txtRemaining.Text = "0";
            this.txtRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Device Borrowed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Divice Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Divice ID";
            // 
            // txtDDescription
            // 
            this.txtDDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDDescription.Location = new System.Drawing.Point(128, 139);
            this.txtDDescription.Multiline = true;
            this.txtDDescription.Name = "txtDDescription";
            this.txtDDescription.ReadOnly = true;
            this.txtDDescription.Size = new System.Drawing.Size(266, 89);
            this.txtDDescription.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Divice Name";
            // 
            // txtDQuantity
            // 
            this.txtDQuantity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDQuantity.Location = new System.Drawing.Point(128, 81);
            this.txtDQuantity.Multiline = true;
            this.txtDQuantity.Name = "txtDQuantity";
            this.txtDQuantity.ReadOnly = true;
            this.txtDQuantity.Size = new System.Drawing.Size(41, 23);
            this.txtDQuantity.TabIndex = 4;
            this.txtDQuantity.Text = "0";
            this.txtDQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDBorrowed
            // 
            this.txtDBorrowed.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDBorrowed.Location = new System.Drawing.Point(128, 110);
            this.txtDBorrowed.Name = "txtDBorrowed";
            this.txtDBorrowed.ReadOnly = true;
            this.txtDBorrowed.Size = new System.Drawing.Size(41, 22);
            this.txtDBorrowed.TabIndex = 5;
            this.txtDBorrowed.Text = "0";
            this.txtDBorrowed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDID
            // 
            this.txtDID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDID.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtDID.Location = new System.Drawing.Point(128, 22);
            this.txtDID.Name = "txtDID";
            this.txtDID.ReadOnly = true;
            this.txtDID.Size = new System.Drawing.Size(266, 22);
            this.txtDID.TabIndex = 2;
            // 
            // txtDName
            // 
            this.txtDName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDName.Location = new System.Drawing.Point(128, 52);
            this.txtDName.Multiline = true;
            this.txtDName.Name = "txtDName";
            this.txtDName.ReadOnly = true;
            this.txtDName.Size = new System.Drawing.Size(266, 20);
            this.txtDName.TabIndex = 3;
            // 
            // grpDButton
            // 
            this.grpDButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpDButton.Controls.Add(this.btnDCancel);
            this.grpDButton.Controls.Add(this.btnDEdit);
            this.grpDButton.Controls.Add(this.btnDDelete);
            this.grpDButton.Controls.Add(this.btnDSave);
            this.grpDButton.Controls.Add(this.btnDAdd);
            this.grpDButton.Location = new System.Drawing.Point(520, 222);
            this.grpDButton.Name = "grpDButton";
            this.grpDButton.Size = new System.Drawing.Size(383, 241);
            this.grpDButton.TabIndex = 1;
            this.grpDButton.TabStop = false;
            this.grpDButton.Text = "Divice Manament";
            // 
            // btnDCancel
            // 
            this.btnDCancel.Enabled = false;
            this.btnDCancel.Location = new System.Drawing.Point(41, 191);
            this.btnDCancel.Name = "btnDCancel";
            this.btnDCancel.Size = new System.Drawing.Size(246, 37);
            this.btnDCancel.TabIndex = 1;
            this.btnDCancel.Text = "Cancel";
            this.btnDCancel.UseVisualStyleBackColor = true;
            this.btnDCancel.Click += new System.EventHandler(this.btnDCancel_Click_1);
            // 
            // btnDDelete
            // 
            this.btnDDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDDelete.Location = new System.Drawing.Point(41, 105);
            this.btnDDelete.Name = "btnDDelete";
            this.btnDDelete.Size = new System.Drawing.Size(246, 37);
            this.btnDDelete.TabIndex = 0;
            this.btnDDelete.Text = "Delete";
            this.btnDDelete.UseVisualStyleBackColor = false;
            this.btnDDelete.Click += new System.EventHandler(this.btnDDelete_Click);
            // 
            // btnDSave
            // 
            this.btnDSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnDSave.Enabled = false;
            this.btnDSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDSave.Location = new System.Drawing.Point(41, 148);
            this.btnDSave.Name = "btnDSave";
            this.btnDSave.Size = new System.Drawing.Size(246, 37);
            this.btnDSave.TabIndex = 0;
            this.btnDSave.Text = "Save";
            this.btnDSave.UseVisualStyleBackColor = false;
            this.btnDSave.Click += new System.EventHandler(this.btnDSave_Click);
            // 
            // btnDAdd
            // 
            this.btnDAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnDAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDAdd.Location = new System.Drawing.Point(41, 19);
            this.btnDAdd.Name = "btnDAdd";
            this.btnDAdd.Size = new System.Drawing.Size(246, 37);
            this.btnDAdd.TabIndex = 0;
            this.btnDAdd.Text = "Add";
            this.btnDAdd.UseVisualStyleBackColor = false;
            this.btnDAdd.Click += new System.EventHandler(this.btnDAdd_Click);
            // 
            // tabInProject
            // 
            this.tabInProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabInProject.Controls.Add(this.grpDivice);
            this.tabInProject.Controls.Add(this.tabMember);
            this.tabInProject.Controls.Add(this.tabProject);
            this.tabInProject.Controls.Add(this.tabSProject);
            this.tabInProject.Controls.Add(this.tabBorrowed);
            this.tabInProject.Controls.Add(this.tabBorrow);
            this.tabInProject.Controls.Add(this.tabPage1);
            this.tabInProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInProject.ImageList = this.imageList1;
            this.tabInProject.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.tabInProject.Location = new System.Drawing.Point(12, -2);
            this.tabInProject.Name = "tabInProject";
            this.tabInProject.RightToLeftLayout = true;
            this.tabInProject.SelectedIndex = 0;
            this.tabInProject.Size = new System.Drawing.Size(950, 508);
            this.tabInProject.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(942, 470);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "LogOut";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(452, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 55);
            this.button3.TabIndex = 0;
            this.button3.Text = "Exit System";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 55);
            this.button2.TabIndex = 0;
            this.button2.Text = "Switch User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDEdit
            // 
            this.btnDEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnDEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDEdit.Location = new System.Drawing.Point(41, 62);
            this.btnDEdit.Name = "btnDEdit";
            this.btnDEdit.Size = new System.Drawing.Size(246, 37);
            this.btnDEdit.TabIndex = 0;
            this.btnDEdit.Text = "Edit";
            this.btnDEdit.UseVisualStyleBackColor = false;
            this.btnDEdit.Click += new System.EventHandler(this.btnDEdit_Click);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(961, 518);
            this.Controls.Add(this.tabInProject);
            this.Name = "ManagementForm";
            this.Text = "Embedded Divice Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagementForm_FormClosing);
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.tabBorrow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYourBorrow)).EndInit();
            this.tabBorrowed.ResumeLayout(false);
            this.tabBorrowed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowed)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBDAmount)).EndInit();
            this.grpBDButton.ResumeLayout(false);
            this.tabSProject.ResumeLayout(false);
            this.tabSProject.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSMember)).EndInit();
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSProject)).EndInit();
            this.tabProject.ResumeLayout(false);
            this.tabProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tabMember.ResumeLayout(false);
            this.tabMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpMManagement.ResumeLayout(false);
            this.grpDivice.ResumeLayout(false);
            this.grpDivice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpDButton.ResumeLayout(false);
            this.tabInProject.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DeviceManagementDataSet deviceManagementDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private DeviceManagementDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.BindingSource diviceBindingSource;
        private System.Windows.Forms.ImageList imageList1;
        private DeviceManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TabPage tabBorrow;
        private System.Windows.Forms.DataGridView dgvYourBorrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Button btnReimburse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabBorrowed;
        private System.Windows.Forms.ComboBox cmbBSearch;
        private System.Windows.Forms.TextBox txtBSearch;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView dgvBorrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AB;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDStartingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDManager;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtMaxAmount;
        private System.Windows.Forms.NumericUpDown txtBDAmount;
        private System.Windows.Forms.ComboBox cmbBDDID;
        private System.Windows.Forms.ComboBox cmbBDMID;
        private System.Windows.Forms.TextBox txtBDManager;
        private System.Windows.Forms.DateTimePicker dtpBDStartingDate;
        private System.Windows.Forms.DateTimePicker dtpBDEndDate;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtBDID;
        private System.Windows.Forms.GroupBox grpBDButton;
        private System.Windows.Forms.Button btnBDDelete;
        private System.Windows.Forms.Button btnBDCancel;
        private System.Windows.Forms.Button btnBDSave;
        private System.Windows.Forms.Button btnBDAdd;
        private System.Windows.Forms.TabPage tabSProject;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.ComboBox cmbPID;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox cmbMID;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnRemovefromProject;
        private System.Windows.Forms.Button btnAddtoProject;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.DataGridView dgvSMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.DataGridView dgvSProject;
        private System.Windows.Forms.TabPage tabProject;
        private System.Windows.Forms.ComboBox cmbPSearch;
        private System.Windows.Forms.TextBox txtPSearch;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PStartingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDescription;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dtpPStart;
        private System.Windows.Forms.DateTimePicker dtpPEnd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPDescription;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.TextBox txtPLeader;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnPEdit;
        private System.Windows.Forms.Button btnPDelete;
        private System.Windows.Forms.Button btnPCancel;
        private System.Windows.Forms.Button btnPSave;
        private System.Windows.Forms.Button btnPAdd;
        private System.Windows.Forms.TabPage tabMember;
        private System.Windows.Forms.ComboBox cmbMSearch;
        private System.Windows.Forms.TextBox txtMSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn MID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn MBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn MPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAdress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbMGender;
        private System.Windows.Forms.DateTimePicker dtpMBirth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMAdress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMID;
        private System.Windows.Forms.TextBox txtMPhone;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.GroupBox grpMManagement;
        private System.Windows.Forms.Button btnMEdit;
        private System.Windows.Forms.Button btnMDelete;
        private System.Windows.Forms.Button btnMCancel;
        private System.Windows.Forms.Button btnMSave;
        private System.Windows.Forms.Button btnMAdd;
        private System.Windows.Forms.TabPage grpDivice;
        private System.Windows.Forms.DataGridView dgvDivice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBorrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDSearch;
        private System.Windows.Forms.ComboBox cmbDTypeSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemaining;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDQuantity;
        private System.Windows.Forms.TextBox txtDBorrowed;
        private System.Windows.Forms.TextBox txtDID;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.GroupBox grpDButton;
        private System.Windows.Forms.Button btnDCancel;
        private System.Windows.Forms.Button btnDDelete;
        private System.Windows.Forms.Button btnDSave;
        private System.Windows.Forms.Button btnDAdd;
        private System.Windows.Forms.TabControl tabInProject;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbSMemberSearch;
        private System.Windows.Forms.TextBox txtSMSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnDEdit;
    }
}