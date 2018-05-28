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
    public partial class BorrowFrom : Form
    {
        int borrowed;
        public BorrowFrom()
        {
            InitializeComponent();
        }

        private void cmbBDDID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = ConnectSQL.getDBConnection();
                conn.Open();

                String cmd = "select DQuantity, DBorrowed, DID from Divice where dname = N'" + cmbDName.Text + "'";
                SqlCommand comm = new SqlCommand(cmd, conn);
                comm.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(comm); // lấy dữ liệu về
                DataTable dt = new DataTable();     // tạo kho ảo chưa dữ liệu
                da.Fill(dt);

                conn.Close();

                int quantity = Int32.Parse(dt.Rows[0]["dquantity"].ToString());
                borrowed = Int32.Parse(dt.Rows[0]["dborrowed"].ToString());
                int remain = quantity - borrowed;
                txtBDAmount.Maximum = remain;
                txtMaxAmount.Text = remain.ToString();

                cmbBDDID.Text = dt.Rows[0]["did"].ToString();
                txtBDID.Text = txtBDMember.Text + "_" + cmbBDDID.Text;
                
            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
        }
        public void loadDID()
        {
            try
            {
                SqlConnection conn = ConnectSQL.getDBConnection();
                conn.Open();

                String cmd = "select * from Divice";
                SqlCommand comm = new SqlCommand(cmd, conn);
                comm.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(comm); // lấy dữ liệu về
                DataTable dt = new DataTable();     // tạo kho ảo chưa dữ liệu
                da.Fill(dt);

                conn.Close();

                cmbDName.DataSource = dt;
                cmbDName.DisplayMember = "dname";
            }
            catch (Exception ex)
            {

                Console.Write(ex.ToString());
            }
        }

        private void BorrowFrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deviceManagementDataSet.Divice' table. You can move, or remove it, as needed.
            this.MaximizeBox = false;
            loadDID();
            dtpBDStartingDate.GetLifetimeService();
            txtBDMember.Text = Login.idLogin;
            txtBDManager.Text = "B1400798";
            txtBDID.Text = txtBDMember.Text + "_" + cmbDName.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(txtBDAmount.Value.ToString());
            if (amount < 1)
            {
                MessageBox.Show("Số lượng phải lớn hơn 1");
            }
            else
            {
                try
                {

                    Borrowed.addBorrowed(txtBDID.Text, cmbBDDID.Text, txtBDMember.Text, dtpBDStartingDate.Text, dtpBDEndDate.Text, txtBDAmount.Text, txtBDManager.Text);
                    int temp = Int32.Parse(txtBDAmount.Text);
                    Divice.changeBorrowed(cmbBDDID.Text, borrowed + temp);

                    MessageBox.Show("Succes Borrowed");
                    this.Close();

                }
                catch (Exception ex)
                {

                    Console.Write("Error: " + ex);
                }
            }
            
        }
    }
}
