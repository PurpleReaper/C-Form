namespace MyProject
{
    partial class BorrowFrom
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
            this.txtMaxAmount = new System.Windows.Forms.TextBox();
            this.txtBDAmount = new System.Windows.Forms.NumericUpDown();
            this.cmbDName = new System.Windows.Forms.ComboBox();
            this.diviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceManagementDataSet = new MyProject.DeviceManagementDataSet();
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
            this.txtBDMember = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.diviceTableAdapter = new MyProject.DeviceManagementDataSetTableAdapters.DiviceTableAdapter();
            this.cmbBDDID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtBDAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaxAmount
            // 
            this.txtMaxAmount.Enabled = false;
            this.txtMaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxAmount.Location = new System.Drawing.Point(261, 215);
            this.txtMaxAmount.Name = "txtMaxAmount";
            this.txtMaxAmount.Size = new System.Drawing.Size(53, 22);
            this.txtMaxAmount.TabIndex = 46;
            // 
            // txtBDAmount
            // 
            this.txtBDAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBDAmount.Location = new System.Drawing.Point(110, 215);
            this.txtBDAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtBDAmount.Name = "txtBDAmount";
            this.txtBDAmount.Size = new System.Drawing.Size(58, 22);
            this.txtBDAmount.TabIndex = 45;
            this.txtBDAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbDName
            // 
            this.cmbDName.DataSource = this.diviceBindingSource;
            this.cmbDName.DisplayMember = "DID";
            this.cmbDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDName.FormattingEnabled = true;
            this.cmbDName.Location = new System.Drawing.Point(108, 132);
            this.cmbDName.Name = "cmbDName";
            this.cmbDName.Size = new System.Drawing.Size(204, 24);
            this.cmbDName.TabIndex = 44;
            this.cmbDName.ValueMember = "DID";
            this.cmbDName.SelectedIndexChanged += new System.EventHandler(this.cmbBDDID_SelectedIndexChanged);
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
            // txtBDManager
            // 
            this.txtBDManager.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBDManager.Enabled = false;
            this.txtBDManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBDManager.Location = new System.Drawing.Point(110, 189);
            this.txtBDManager.Multiline = true;
            this.txtBDManager.Name = "txtBDManager";
            this.txtBDManager.ReadOnly = true;
            this.txtBDManager.Size = new System.Drawing.Size(125, 20);
            this.txtBDManager.TabIndex = 42;
            // 
            // dtpBDStartingDate
            // 
            this.dtpBDStartingDate.CustomFormat = "MM-dd-yyyy";
            this.dtpBDStartingDate.Enabled = false;
            this.dtpBDStartingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBDStartingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBDStartingDate.Location = new System.Drawing.Point(110, 243);
            this.dtpBDStartingDate.Name = "dtpBDStartingDate";
            this.dtpBDStartingDate.Size = new System.Drawing.Size(204, 22);
            this.dtpBDStartingDate.TabIndex = 41;
            this.dtpBDStartingDate.Value = new System.DateTime(2017, 4, 13, 0, 0, 0, 0);
            // 
            // dtpBDEndDate
            // 
            this.dtpBDEndDate.CustomFormat = "MM-dd-yyyy";
            this.dtpBDEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBDEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBDEndDate.Location = new System.Drawing.Point(110, 271);
            this.dtpBDEndDate.Name = "dtpBDEndDate";
            this.dtpBDEndDate.Size = new System.Drawing.Size(204, 22);
            this.dtpBDEndDate.TabIndex = 40;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(16, 192);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 16);
            this.label27.TabIndex = 31;
            this.label27.Text = "Manager";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(16, 276);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 16);
            this.label28.TabIndex = 32;
            this.label28.Text = "End Date";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(19, 248);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(85, 16);
            this.label29.TabIndex = 33;
            this.label29.Text = "Starting Date";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(16, 68);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 16);
            this.label30.TabIndex = 34;
            this.label30.Text = "BD ID";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(16, 166);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(62, 16);
            this.label33.TabIndex = 35;
            this.label33.Text = "Divice ID";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(174, 217);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(81, 16);
            this.label34.TabIndex = 36;
            this.label34.Text = "Max Amount";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(19, 218);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 16);
            this.label31.TabIndex = 37;
            this.label31.Text = "Amount";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(16, 102);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(74, 16);
            this.label32.TabIndex = 38;
            this.label32.Text = "Member ID";
            // 
            // txtBDID
            // 
            this.txtBDID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBDID.Enabled = false;
            this.txtBDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBDID.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtBDID.Location = new System.Drawing.Point(110, 65);
            this.txtBDID.Name = "txtBDID";
            this.txtBDID.ReadOnly = true;
            this.txtBDID.Size = new System.Drawing.Size(204, 22);
            this.txtBDID.TabIndex = 39;
            // 
            // txtBDMember
            // 
            this.txtBDMember.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBDMember.Enabled = false;
            this.txtBDMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBDMember.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtBDMember.Location = new System.Drawing.Point(110, 99);
            this.txtBDMember.Name = "txtBDMember";
            this.txtBDMember.ReadOnly = true;
            this.txtBDMember.Size = new System.Drawing.Size(204, 22);
            this.txtBDMember.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Borrow Ticket Details";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(74, 299);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 32);
            this.btnOK.TabIndex = 48;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(196, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // diviceTableAdapter
            // 
            this.diviceTableAdapter.ClearBeforeFill = true;
            // 
            // cmbBDDID
            // 
            this.cmbBDDID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbBDDID.Enabled = false;
            this.cmbBDDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBDDID.Location = new System.Drawing.Point(110, 162);
            this.cmbBDDID.Multiline = true;
            this.cmbBDDID.Name = "cmbBDDID";
            this.cmbBDDID.ReadOnly = true;
            this.cmbBDDID.Size = new System.Drawing.Size(125, 20);
            this.cmbBDDID.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Divice Name";
            // 
            // BorrowFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 343);
            this.Controls.Add(this.cmbBDDID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBDMember);
            this.Controls.Add(this.txtMaxAmount);
            this.Controls.Add(this.txtBDAmount);
            this.Controls.Add(this.cmbDName);
            this.Controls.Add(this.txtBDManager);
            this.Controls.Add(this.dtpBDStartingDate);
            this.Controls.Add(this.dtpBDEndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.txtBDID);
            this.Name = "BorrowFrom";
            this.Text = "Borrowed Divice";
            this.Load += new System.EventHandler(this.BorrowFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBDAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaxAmount;
        private System.Windows.Forms.NumericUpDown txtBDAmount;
        private System.Windows.Forms.ComboBox cmbDName;
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
        private System.Windows.Forms.TextBox txtBDMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private DeviceManagementDataSet deviceManagementDataSet;
        private System.Windows.Forms.BindingSource diviceBindingSource;
        private DeviceManagementDataSetTableAdapters.DiviceTableAdapter diviceTableAdapter;
        private System.Windows.Forms.TextBox cmbBDDID;
        private System.Windows.Forms.Label label2;
    }
}