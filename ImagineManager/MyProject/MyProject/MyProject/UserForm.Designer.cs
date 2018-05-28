namespace MyProject
{
    partial class UserForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDivice = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deviceManagementDataSet = new MyProject.DeviceManagementDataSet();
            this.deviceManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diviceTableAdapter = new MyProject.DeviceManagementDataSetTableAdapters.DiviceTableAdapter();
            this.dgvDivice = new System.Windows.Forms.DataGridView();
            this.DID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabDivice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivice)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDivice);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDivice
            // 
            this.tabDivice.Controls.Add(this.btnBorrow);
            this.tabDivice.Controls.Add(this.dgvDivice);
            this.tabDivice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDivice.Location = new System.Drawing.Point(4, 29);
            this.tabDivice.Name = "tabDivice";
            this.tabDivice.Padding = new System.Windows.Forms.Padding(3);
            this.tabDivice.Size = new System.Drawing.Size(915, 459);
            this.tabDivice.TabIndex = 0;
            this.tabDivice.Text = "Divice";
            this.tabDivice.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(915, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deviceManagementDataSet
            // 
            this.deviceManagementDataSet.DataSetName = "DeviceManagementDataSet";
            this.deviceManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deviceManagementDataSetBindingSource
            // 
            this.deviceManagementDataSetBindingSource.DataSource = this.deviceManagementDataSet;
            this.deviceManagementDataSetBindingSource.Position = 0;
            // 
            // diviceBindingSource
            // 
            this.diviceBindingSource.DataMember = "Divice";
            this.diviceBindingSource.DataSource = this.deviceManagementDataSetBindingSource;
            // 
            // diviceTableAdapter
            // 
            this.diviceTableAdapter.ClearBeforeFill = true;
            // 
            // dgvDivice
            // 
            this.dgvDivice.AllowUserToAddRows = false;
            this.dgvDivice.AllowUserToDeleteRows = false;
            this.dgvDivice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDivice.AutoGenerateColumns = false;
            this.dgvDivice.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDivice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDivice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DID,
            this.DName,
            this.DQuantity,
            this.DBorrowed,
            this.DDescription});
            this.dgvDivice.DataSource = this.diviceBindingSource;
            this.dgvDivice.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvDivice.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDivice.Location = new System.Drawing.Point(17, 60);
            this.dgvDivice.MultiSelect = false;
            this.dgvDivice.Name = "dgvDivice";
            this.dgvDivice.ReadOnly = true;
            this.dgvDivice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDivice.Size = new System.Drawing.Size(863, 144);
            this.dgvDivice.TabIndex = 1;
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
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(314, 269);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(130, 34);
            this.btnBorrow.TabIndex = 2;
            this.btnBorrow.Text = "Borrow Divice";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 543);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDivice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deviceManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDivice;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource deviceManagementDataSetBindingSource;
        private DeviceManagementDataSet deviceManagementDataSet;
        private System.Windows.Forms.BindingSource diviceBindingSource;
        private DeviceManagementDataSetTableAdapters.DiviceTableAdapter diviceTableAdapter;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.DataGridView dgvDivice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBorrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDescription;
    }
}