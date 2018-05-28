using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Tictactoe
{
    public partial class TicTacToe : Form {

        public string name;
        #region Properties
        Banco Xuly1;
        #endregion
        public TicTacToe(string name)
        {
            InitializeComponent();
            Xuly1 = new Banco(this, pnlBanCo);
            Xuly1.VeBanCo();
            Xuly1.xuLy();
            this.name = name;
           // this.FormClosing += TicTacToe_FormClosing;
        }


       

        private List<Player> player;

        public List<Player> Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }

        public Dictionary<string, object> _gamedata { get; private set; }

        private void lb1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnChoiGame_Click(object sender, EventArgs e)
        {
            new TicTacToe(name).Show();
            this.Dispose();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pnlBanCo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            lblTen.Text = name;
            lblDiem.Text = FormStart.score.ToString();

        }
        
        public void PlusScore()
        {
            FormStart.score++;
            lblTen.Text = name;
            lblDiem.Text = FormStart.score.ToString();
        }
        

        private void TicTacToe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Xuly1.xuLy())
            {
                DialogResult rs = MessageBox.Show(" Bạn có muốn lưu trạng thái chơi hay không??", "Thoát trò chơi", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    
                
                }
                
            }
            else if (e.CloseReason == CloseReason.ApplicationExitCall || e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult rs = MessageBox.Show("    Bạn có muốn lưu điểm không??", "Thoát trò chơi", MessageBoxButtons.YesNoCancel);

                if (rs == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=DESKTOP-CL8IMRN\\SQLEXPRESS;Initial Catalog=LuuDiem;Integrated Security=True";
                    conn.Open();
                    string str = "select COUNT(*) dem from Luudiem";

                    SqlCommand cmd = new SqlCommand(str, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0) + 1;
                        string query = "insert into LuuDiem values(" + id + ", '" + name + "', " + FormStart.score + ")";
                        SqlConnection conn1 = new SqlConnection();
                        conn1.ConnectionString = "Data Source=DESKTOP-CL8IMRN\\SQLEXPRESS;Initial Catalog=LuuDiem;Integrated Security=True";
                        conn1.Open();
                        SqlCommand cmd1 = new SqlCommand(query, conn1);
                        cmd1.ExecuteNonQuery();
                    }


                }

                else if(rs == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

         public bool button11()
         {
             Stream mystream;
             if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "data.txt"))
             {
                 mystream = File.Create(AppDomain.CurrentDomain.BaseDirectory + "data.txt");
             }
             else
             {
                 mystream = File.OpenWrite(AppDomain.CurrentDomain.BaseDirectory + "data.txt");
             }
             if (mystream != null)
             {
                 IFormatter format = new BinaryFormatter();
                 _gamedata = (Dictionary<string, object>)format.Deserialize(mystream);
                 mystream.Close();
             }
             return true;
         }
        public bool button22()
        {
            if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + "data.txt"))
            {
                Stream mystream;
                mystream = File.OpenRead(AppDomain.CurrentDomain.BaseDirectory + "data.txt");
                IFormatter format = new BinaryFormatter();
                
            }
            return true;
        }
    }
}
