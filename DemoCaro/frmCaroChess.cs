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

namespace DemoCaro
{
    public partial class frmCaroChess : Form
    {
        private CaroChess caroChess;
        private Graphics grs;
        private SqlConnection conn;
        private SqlCommand conm;

        public frmCaroChess()
        {
            InitializeComponent();
            btnPvsP.Click += new EventHandler(playerPlayerToolStripMenuItem_Click);
            caroChess = new CaroChess();
            caroChess.TaoMangOCo();
            grs = pnlBanCo.CreateGraphics();

            playerComToolStripMenuItem.Click += new EventHandler(PvsC_Click);
            btnPvsC.Click += new EventHandler(PvsC_Click);
            btnRedo.Click += new EventHandler(redoToolStripMenuItem_Click);
            btnUndo.Click += new EventHandler(undoToolStripMenuItem_Click);
            
        }

        private void BtnPvsP_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrChuChay.Enabled = true;
            pnlPlayer.Hide();
            try
            {
                conn = new SqlConnection("Server = DESKTOP-TSPM74S\\SQLEXPRESS; Initial Catalog = Caro; Integrated Security = true");
                conn.Open();
                conm = new SqlCommand("Select SoLanThang from LuuThang Where Player = 'Player1'", conn);
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }

        private void pnlBanCo_Paint(object sender, PaintEventArgs e)
        {
            caroChess.VeBanCo(grs);
            caroChess.VeLaiQuanCo(grs);

        }

        private void pnlBanCo_MouseClick(object sender, MouseEventArgs e)
        {
            if (!caroChess.SanSang)
                return;
            if(caroChess.DanhCo(grs, e.X, e.Y))
            {
                if (caroChess.CheckWin())
                {
                    caroChess.EndGame();
                    if(caroChess.winner == Winner.Player1)
                    {
                        conm = new SqlCommand("UPDATE LuuThang SET SoLanThang = (SELECT SoLanThang FROM LuuThang WHERE Player = 'Player1') + 1 WHERE Player = 'Player1'", conn);
                        conm.ExecuteNonQuery();
                        conm = new SqlCommand("SELECT SoLanThang FROM LuuThang WHERE Player = 'Player1'", conn);
                        lblTiSo1.Text = Convert.ToString(conm.ExecuteScalar());
                    }
                    if (caroChess.winner == Winner.Player2)
                    {
                        conm = new SqlCommand("UPDATE LuuThang SET SoLanThang = (SELECT SoLanThang FROM LuuThang WHERE Player = 'Player2') + 1 WHERE Player = 'Player2'", conn);
                        conm.ExecuteNonQuery();
                        conm = new SqlCommand("SELECT SoLanThang FROM LuuThang WHERE Player = 'Player2'", conn);
                        lblTiSo2.Text = Convert.ToString(conm.ExecuteScalar());
                    }
                }
                else
                {
                    if (caroChess.CheDoChoi == 2)
                    {

                        caroChess.KhoiDongMay(grs);
                        if (caroChess.CheckWin())
                        {
                            caroChess.EndGame();
                        }
                    }
                }
            }
        }

        private void playerPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlPlayer.Show();
            pctCom.Hide();
            lblCom.Hide();
            pctP2.Show();
            lblPlayer2.Show();
            pnlTiSo.Show();
            grs.Clear(pnlBanCo.BackColor);
            btnRedo.Enabled = true;
            caroChess.StartPvsP(grs);
            txtThongbao.Text = "Player Vs Player";
            
            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caroChess.Undo(grs);
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caroChess.Redo(grs);
        }

        private void PvsC_Click(object sender, EventArgs e)
        {
            pnlPlayer.Show();
            pctCom.Show();
            pctP2.Hide();
            lblPlayer2.Hide();
            lblCom.Show();
            pnlTiSo.Hide();
            grs.Clear(pnlBanCo.BackColor);
            btnRedo.Enabled = false;
            txtThongbao.Text = "Player vs Computer";
            caroChess.StartPvsC(grs);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
                Application.Exit();
            else
                e.Cancel = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            txtThongbao.Location = new Point(txtThongbao.Location.X + 1, txtThongbao.Location.Y);
            if (txtThongbao.Location.X > pnlKhungChuChay.Width)
            {
                txtThongbao.Location = new Point(pnlKhungChuChay.Location.X - txtThongbao.Width, txtThongbao.Location.Y);
            }

        }

        private void txtThongbao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            GioiThieu gt = new GioiThieu();
            gt.Show();
        }

        private void btnClearTiSo_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn clear tỉ số không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(h == DialogResult.Yes)
            {
                conm = new SqlCommand("UPDATE LuuThang SET SoLanThang = 0 WHERE Player = 'Player1'", conn);
                conm.ExecuteNonQuery();
                conm = new SqlCommand("UPDATE LuuThang SET SoLanThang = 0 WHERE Player = 'Player2'", conn);
                conm.ExecuteNonQuery();
                lblTiSo1.Text = "0";
                lblTiSo2.Text = "0";
                MessageBox.Show("Đã clear tỉ số thành công!!!");
                caroChess.SanSang = false;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

        }
    }
}
