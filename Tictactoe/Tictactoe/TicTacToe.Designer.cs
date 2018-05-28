namespace Tictactoe
{
    partial class TicTacToe
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
            this.pnlBanCo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ttt = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChoiLai = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBanCo
            // 
            this.pnlBanCo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBanCo.Location = new System.Drawing.Point(12, 12);
            this.pnlBanCo.Name = "pnlBanCo";
            this.pnlBanCo.Size = new System.Drawing.Size(468, 457);
            this.pnlBanCo.TabIndex = 0;
            this.pnlBanCo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBanCo_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.ttt);
            this.panel2.Controls.Add(this.avatar);
            this.panel2.Location = new System.Drawing.Point(503, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 288);
            this.panel2.TabIndex = 1;
            // 
            // ttt
            // 
            this.ttt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ttt.Image = global::Tictactoe.Properties.Resources.tttmarqlrg;
            this.ttt.Location = new System.Drawing.Point(0, 0);
            this.ttt.Name = "ttt";
            this.ttt.Size = new System.Drawing.Size(255, 87);
            this.ttt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ttt.TabIndex = 1;
            this.ttt.TabStop = false;
            // 
            // avatar
            // 
            this.avatar.Image = global::Tictactoe.Properties.Resources.unnamed;
            this.avatar.Location = new System.Drawing.Point(0, 84);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(255, 204);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.lblDiem);
            this.panel3.Controls.Add(this.lblTen);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.btnChoiLai);
            this.panel3.Location = new System.Drawing.Point(503, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 163);
            this.panel3.TabIndex = 2;
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiem.Location = new System.Drawing.Point(216, 17);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(15, 16);
            this.lblDiem.TabIndex = 3;
            this.lblDiem.Text = "0";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTen.Location = new System.Drawing.Point(56, 17);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(0, 16);
            this.lblTen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(163, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = " Điểm";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(0, 109);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(252, 54);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.Location = new System.Drawing.Point(0, 49);
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.Size = new System.Drawing.Size(252, 54);
            this.btnChoiLai.TabIndex = 1;
            this.btnChoiLai.Text = "Chơi Lại";
            this.btnChoiLai.UseVisualStyleBackColor = true;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiGame_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 510);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBanCo);
            this.Name = "TicTacToe";
            this.Text = "Bàn Cờ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TicTacToe_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ttt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanCo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ttt;
        private System.Windows.Forms.Button btnChoiLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label label3;
    }
}

