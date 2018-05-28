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

namespace MyProject
{
    public partial class checkAdminPermission : Form
    {
        public static Boolean check;
        public static Boolean isEnded;

        public checkAdminPermission()
        {
            InitializeComponent();
            isEnded = false;
        }

        private void btnCOK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = ConnectSQL.getDBConnection();
                conn.Open();

                String str = "select * from Account where mid = '" + cmbAID.Text + "' and password = '" + txtPassword.Text + "'";
                SqlCommand cmd = new SqlCommand(str, conn);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                conn.Close();

                int count = ds.Tables[0].Rows.Count;

                // if count == 1 is success

                if (count == 1)
                {
                    // Login success
                    String typeLogin = ds.Tables[0].Rows[0]["type"].ToString();
                    if (typeLogin == "True")
                    {
                        check = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("You need be a Administrator");
                    }
                }
                else
                {
                    // Login failed
                    MessageBox.Show("failed");
                }

                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);

            }
        }

        private void btnCExit_Click(object sender, EventArgs e)
        {
            isEnded = true;
            this.Close();
           
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnCOK.PerformClick();
            }
        }

        private void checkAdminPermission_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            check = false;
        }
    }
}
