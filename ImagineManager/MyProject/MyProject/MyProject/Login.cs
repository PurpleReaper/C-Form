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

namespace MyProject
{
    public partial class Login : Form
    {
        public static String idLogin;

        public static String typeLogin;
        public Login()
        {
            InitializeComponent();
            
        }

        // Form Login Load
        private void Login_Load(object sender, EventArgs e)
        {

            this.MaximizeBox = false;
            cmbMID.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {

                SqlConnection conn = ConnectSQL.getDBConnection();
                
                conn.Open();
                String cmd = "select * from Account";
                    
                SqlCommand comm = new SqlCommand(cmd, conn);
                comm.CommandType = CommandType.Text;
                
                SqlDataAdapter da = new SqlDataAdapter(comm); // lấy dữ liệu về
                DataTable dt = new DataTable();     // tạo kho ảo chưa dữ liệu
                da.Fill(dt);
                
                cmbMID.DataSource = dt;
                cmbMID.DisplayMember = "mid";
                cmbMID.ValueMember = "mid";

                conn.Close();


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        // Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = ConnectSQL.getDBConnection();
                conn.Open();

                String str = "select * from Account where mid = '" + cmbMID.Text + "' and password = '" + txtPassword.Text + "'";
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
                    typeLogin = ds.Tables[0].Rows[0]["type"].ToString();
                    idLogin = ds.Tables[0].Rows[0]["mid"].ToString();
                    if (typeLogin == "True")
                    {
                        ManagementForm managementForm = new ManagementForm();
                        managementForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        ManagementForm managementForm = new ManagementForm();
                        managementForm.Show();
                        this.Hide();
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

        // Exit System
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wanna EXIT SYSTEM????", "EXIT SYSTEM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
