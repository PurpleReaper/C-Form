using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tictactoe
{
    public partial class FormStart : Form
    {
        public static int score = 0;
        //public static string name;

        Banco xuly1;
        public FormStart()
        {
            InitializeComponent();
            
        }

        private void FormStart_Load(object sender, EventArgs e)
        {

        }

        private void btnChoiGame_Click(object sender, EventArgs e)
        {

            DialogResult rs = MessageBox.Show("Ban co muon choi tiep van co vua roi khong?", "Choi tiep",MessageBoxButtons.YesNo);
            if (rs == DialogResult.No)
            {
                this.Hide(); ;
                string name = ShowDialog("Player Name", "Nhập tên người chơi!!");

                TicTacToe f1 = new TicTacToe(name);
                f1.Show();
            }
            else if (rs == DialogResult.Yes)
            {
                
            }
            
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 150, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
