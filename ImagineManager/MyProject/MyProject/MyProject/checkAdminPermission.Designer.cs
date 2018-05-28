namespace MyProject
{
    partial class checkAdminPermission
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
            this.cmbAID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCExit = new System.Windows.Forms.Button();
            this.btnCOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAID
            // 
            this.cmbAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAID.FormattingEnabled = true;
            this.cmbAID.Location = new System.Drawing.Point(143, 93);
            this.cmbAID.Name = "cmbAID";
            this.cmbAID.Size = new System.Drawing.Size(168, 28);
            this.cmbAID.TabIndex = 4;
            this.cmbAID.Text = "B1400798";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Admin ID";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(146, 142);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(168, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnCExit
            // 
            this.btnCExit.CausesValidation = false;
            this.btnCExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCExit.Location = new System.Drawing.Point(239, 174);
            this.btnCExit.Name = "btnCExit";
            this.btnCExit.Size = new System.Drawing.Size(75, 34);
            this.btnCExit.TabIndex = 8;
            this.btnCExit.Text = "Exit";
            this.btnCExit.UseVisualStyleBackColor = true;
            this.btnCExit.Click += new System.EventHandler(this.btnCExit_Click);
            // 
            // btnCOK
            // 
            this.btnCOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOK.Location = new System.Drawing.Point(146, 174);
            this.btnCOK.Name = "btnCOK";
            this.btnCOK.Size = new System.Drawing.Size(75, 34);
            this.btnCOK.TabIndex = 3;
            this.btnCOK.Text = "OK";
            this.btnCOK.UseVisualStyleBackColor = true;
            this.btnCOK.Click += new System.EventHandler(this.btnCOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "You need admin permission to continue";
            // 
            // checkAdminPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 240);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCExit);
            this.Controls.Add(this.btnCOK);
            this.Controls.Add(this.cmbAID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Name = "checkAdminPermission";
            this.Text = "Admidistartor Check";
            this.Load += new System.EventHandler(this.checkAdminPermission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCExit;
        private System.Windows.Forms.Button btnCOK;
        private System.Windows.Forms.Label label3;
    }
}