namespace Tictactoe
{
    partial class FormStart
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChoiGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(131, 185);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(252, 54);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChoiGame
            // 
            this.btnChoiGame.Location = new System.Drawing.Point(131, 109);
            this.btnChoiGame.Name = "btnChoiGame";
            this.btnChoiGame.Size = new System.Drawing.Size(252, 54);
            this.btnChoiGame.TabIndex = 3;
            this.btnChoiGame.Text = "Chơi Game";
            this.btnChoiGame.UseVisualStyleBackColor = true;
            this.btnChoiGame.Click += new System.EventHandler(this.btnChoiGame_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 348);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChoiGame);
            this.Name = "FormStart";
            this.Text = "Game TicTacToe";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnChoiGame;
    }
}