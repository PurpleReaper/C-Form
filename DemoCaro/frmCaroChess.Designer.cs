namespace DemoCaro
{
    partial class frmCaroChess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaroChess));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerComToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBanCo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtThongbao = new System.Windows.Forms.TextBox();
            this.pnlKhungChuChay = new System.Windows.Forms.Panel();
            this.tmrChuChay = new System.Windows.Forms.Timer(this.components);
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTiSo1 = new System.Windows.Forms.Label();
            this.lblTiSo2 = new System.Windows.Forms.Label();
            this.pctP2 = new System.Windows.Forms.PictureBox();
            this.pctP1 = new System.Windows.Forms.PictureBox();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnPvsC = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pctCom = new System.Windows.Forms.PictureBox();
            this.btnPvsP = new System.Windows.Forms.Button();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.Label();
            this.btnClearTiSo = new System.Windows.Forms.Button();
            this.pnlTiSo = new System.Windows.Forms.Panel();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlKhungChuChay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCom)).BeginInit();
            this.pnlPlayer.SuspendLayout();
            this.pnlTiSo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerPlayerToolStripMenuItem,
            this.playerComToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // playerPlayerToolStripMenuItem
            // 
            this.playerPlayerToolStripMenuItem.Name = "playerPlayerToolStripMenuItem";
            this.playerPlayerToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.playerPlayerToolStripMenuItem.Text = "Player - Player";
            this.playerPlayerToolStripMenuItem.Click += new System.EventHandler(this.playerPlayerToolStripMenuItem_Click);
            // 
            // playerComToolStripMenuItem
            // 
            this.playerComToolStripMenuItem.Name = "playerComToolStripMenuItem";
            this.playerComToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.playerComToolStripMenuItem.Text = "Player - Com";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // pnlBanCo
            // 
            this.pnlBanCo.BackColor = System.Drawing.Color.Khaki;
            this.pnlBanCo.Location = new System.Drawing.Point(245, 67);
            this.pnlBanCo.Name = "pnlBanCo";
            this.pnlBanCo.Size = new System.Drawing.Size(501, 501);
            this.pnlBanCo.TabIndex = 2;
            this.pnlBanCo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBanCo_Paint);
            this.pnlBanCo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBanCo_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DemoCaro.Properties.Resources.Hinhngoai;
            this.pictureBox1.Location = new System.Drawing.Point(15, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 229);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtThongbao
            // 
            this.txtThongbao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtThongbao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThongbao.Enabled = false;
            this.txtThongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThongbao.Location = new System.Drawing.Point(0, 0);
            this.txtThongbao.Name = "txtThongbao";
            this.txtThongbao.ReadOnly = true;
            this.txtThongbao.Size = new System.Drawing.Size(220, 22);
            this.txtThongbao.TabIndex = 8;
            this.txtThongbao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThongbao.TextChanged += new System.EventHandler(this.txtThongbao_TextChanged);
            // 
            // pnlKhungChuChay
            // 
            this.pnlKhungChuChay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlKhungChuChay.Controls.Add(this.txtThongbao);
            this.pnlKhungChuChay.Location = new System.Drawing.Point(245, 30);
            this.pnlKhungChuChay.Name = "pnlKhungChuChay";
            this.pnlKhungChuChay.Size = new System.Drawing.Size(501, 31);
            this.pnlKhungChuChay.TabIndex = 9;
            // 
            // tmrChuChay
            // 
            this.tmrChuChay.Enabled = true;
            this.tmrChuChay.Interval = 10;
            this.tmrChuChay.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPlayer1.Location = new System.Drawing.Point(51, 136);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(91, 25);
            this.lblPlayer1.TabIndex = 14;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPlayer2.Location = new System.Drawing.Point(51, 448);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(91, 25);
            this.lblPlayer2.TabIndex = 14;
            this.lblPlayer2.Text = "Player 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tỉ số : ";
            // 
            // lblTiSo1
            // 
            this.lblTiSo1.AutoSize = true;
            this.lblTiSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTiSo1.Location = new System.Drawing.Point(78, 15);
            this.lblTiSo1.Name = "lblTiSo1";
            this.lblTiSo1.Size = new System.Drawing.Size(24, 25);
            this.lblTiSo1.TabIndex = 15;
            this.lblTiSo1.Text = "0";
            // 
            // lblTiSo2
            // 
            this.lblTiSo2.AutoSize = true;
            this.lblTiSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTiSo2.Location = new System.Drawing.Point(108, 15);
            this.lblTiSo2.Name = "lblTiSo2";
            this.lblTiSo2.Size = new System.Drawing.Size(24, 25);
            this.lblTiSo2.TabIndex = 15;
            this.lblTiSo2.Text = "0";
            // 
            // pctP2
            // 
            this.pctP2.Image = global::DemoCaro.Properties.Resources.nobita;
            this.pctP2.Location = new System.Drawing.Point(29, 313);
            this.pctP2.Name = "pctP2";
            this.pctP2.Size = new System.Drawing.Size(132, 130);
            this.pctP2.TabIndex = 12;
            this.pctP2.TabStop = false;
            // 
            // pctP1
            // 
            this.pctP1.Image = global::DemoCaro.Properties.Resources.dekhi;
            this.pctP1.Location = new System.Drawing.Point(26, 3);
            this.pctP1.Name = "pctP1";
            this.pctP1.Size = new System.Drawing.Size(132, 130);
            this.pctP1.TabIndex = 12;
            this.pctP1.TabStop = false;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackgroundImage = global::DemoCaro.Properties.Resources.button;
            this.btnAboutUs.Font = new System.Drawing.Font("Segoe Script", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAboutUs.Location = new System.Drawing.Point(127, 499);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(113, 61);
            this.btnAboutUs.TabIndex = 10;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Font = new System.Drawing.Font("Segoe Script", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRedo.Image = global::DemoCaro.Properties.Resources.button;
            this.btnRedo.Location = new System.Drawing.Point(128, 434);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(113, 59);
            this.btnRedo.TabIndex = 6;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Segoe Script", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnUndo.Image = global::DemoCaro.Properties.Resources.button;
            this.btnUndo.Location = new System.Drawing.Point(14, 433);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(108, 59);
            this.btnUndo.TabIndex = 6;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnPvsC
            // 
            this.btnPvsC.Font = new System.Drawing.Font("Segoe Script", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPvsC.Image = global::DemoCaro.Properties.Resources.button;
            this.btnPvsC.Location = new System.Drawing.Point(14, 371);
            this.btnPvsC.Name = "btnPvsC";
            this.btnPvsC.Size = new System.Drawing.Size(227, 56);
            this.btnPvsC.TabIndex = 4;
            this.btnPvsC.Text = "Player Vs Com";
            this.btnPvsC.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe Script", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnExit.Image = global::DemoCaro.Properties.Resources.button;
            this.btnExit.Location = new System.Drawing.Point(10, 498);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 61);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pctCom
            // 
            this.pctCom.Image = global::DemoCaro.Properties.Resources.deremon2;
            this.pctCom.Location = new System.Drawing.Point(29, 313);
            this.pctCom.Name = "pctCom";
            this.pctCom.Size = new System.Drawing.Size(132, 130);
            this.pctCom.TabIndex = 16;
            this.pctCom.TabStop = false;
            // 
            // btnPvsP
            // 
            this.btnPvsP.BackColor = System.Drawing.SystemColors.Control;
            this.btnPvsP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPvsP.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPvsP.Font = new System.Drawing.Font("Segoe Script", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPvsP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPvsP.Image = global::DemoCaro.Properties.Resources.button;
            this.btnPvsP.Location = new System.Drawing.Point(14, 309);
            this.btnPvsP.Name = "btnPvsP";
            this.btnPvsP.Size = new System.Drawing.Size(227, 56);
            this.btnPvsP.TabIndex = 3;
            this.btnPvsP.Text = "Player Vs Player";
            this.btnPvsP.UseVisualStyleBackColor = false;
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.Controls.Add(this.pnlTiSo);
            this.pnlPlayer.Controls.Add(this.pctP2);
            this.pnlPlayer.Controls.Add(this.pctCom);
            this.pnlPlayer.Controls.Add(this.pctP1);
            this.pnlPlayer.Controls.Add(this.lblPlayer1);
            this.pnlPlayer.Controls.Add(this.lblCom);
            this.pnlPlayer.Controls.Add(this.lblPlayer2);
            this.pnlPlayer.Location = new System.Drawing.Point(752, 67);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(192, 498);
            this.pnlPlayer.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(97, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = ":";
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCom.Location = new System.Drawing.Point(51, 448);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(106, 25);
            this.lblCom.TabIndex = 14;
            this.lblCom.Text = "Computer";
            // 
            // btnClearTiSo
            // 
            this.btnClearTiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClearTiSo.Location = new System.Drawing.Point(60, 44);
            this.btnClearTiSo.Name = "btnClearTiSo";
            this.btnClearTiSo.Size = new System.Drawing.Size(96, 42);
            this.btnClearTiSo.TabIndex = 17;
            this.btnClearTiSo.Text = "Clear";
            this.btnClearTiSo.UseVisualStyleBackColor = true;
            this.btnClearTiSo.Click += new System.EventHandler(this.btnClearTiSo_Click);
            // 
            // pnlTiSo
            // 
            this.pnlTiSo.Controls.Add(this.lblTiSo2);
            this.pnlTiSo.Controls.Add(this.label3);
            this.pnlTiSo.Controls.Add(this.btnClearTiSo);
            this.pnlTiSo.Controls.Add(this.label2);
            this.pnlTiSo.Controls.Add(this.lblTiSo1);
            this.pnlTiSo.Location = new System.Drawing.Point(26, 190);
            this.pnlTiSo.Name = "pnlTiSo";
            this.pnlTiSo.Size = new System.Drawing.Size(162, 100);
            this.pnlTiSo.TabIndex = 8;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmCaroChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 587);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.pnlPlayer);
            this.Controls.Add(this.pnlKhungChuChay);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnPvsC);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlBanCo);
            this.Controls.Add(this.btnPvsP);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCaroChess";
            this.Text = "Caro Chess";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlKhungChuChay.ResumeLayout(false);
            this.pnlKhungChuChay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCom)).EndInit();
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            this.pnlTiSo.ResumeLayout(false);
            this.pnlTiSo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerComToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Panel pnlBanCo;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Button btnPvsP;
        private System.Windows.Forms.Button btnPvsC;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtThongbao;
        private System.Windows.Forms.Panel pnlKhungChuChay;
        private System.Windows.Forms.Timer tmrChuChay;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.PictureBox pctP1;
        private System.Windows.Forms.PictureBox pctP2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTiSo1;
        private System.Windows.Forms.Label lblTiSo2;
        private System.Windows.Forms.PictureBox pctCom;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearTiSo;
        private System.Windows.Forms.Panel pnlTiSo;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

