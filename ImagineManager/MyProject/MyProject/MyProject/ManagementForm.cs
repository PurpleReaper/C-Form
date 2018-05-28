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
    public partial class ManagementForm : Form
    {
        static int remain, borrowed, quantity;
        private Boolean isAddDivice, isEditDivice;
        private enum Mode
        {
            Edit,
            Add
        }
        
        private Mode mode;


        public ManagementForm()
        {
            InitializeComponent();

        }
        // When Member Login
        private void memberLogin()
        {
            grpDButton.Enabled = false;
            grpMManagement.Enabled = false;
            grpBDButton.Enabled = false;
            
        }

        // When Admin Login
        private void adminLogin()
        {
            grpDButton.Enabled = true;
            grpMManagement.Enabled = true;
            grpBDButton.Enabled = true;
        }



        // Form Load
        private void ManagementForm_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'deviceManagementDataSet.Divice' table. You can move, or remove it, as needed.
            // this.diviceTableAdapter.Fill(this.deviceManagementDataSet.Divice);
            // TODO: This line of code loads data into the 'deviceManagementDataSet.Member' table. You can move, or remove it, as needed.
            //this.memberTableAdapter.Fill(this.deviceManagementDataSet.Member);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            cmbBSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDTypeSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPSearch.DropDownStyle = ComboBoxStyle.DropDownList;
           // lblIDLOGIN.Text = Login.idLogin;
            if(Login.typeLogin == "True")
            {
                adminLogin();
                
            }
            else
            {
                memberLogin();
            }

            // load Data
            loadDiviceData();
            loadMemberData();
            loadProjectData();
            loadBorrowedDetailsData();
            loadSProject();
            loadYourBorrow();
        }
        // Exit system
        private void ManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            // Đóng tất cả ứng dụng
            Application.Exit();
        }



        #region Load Data
        //  Load Divice data function
        public void loadDiviceData()
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

                dgvDivice.DataSource = dt;
                cmbBDDID.DataSource = dt;
                cmbBDDID.DisplayMember = "did";
                cmbBDDID.ValueMember = "did";
            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
        }

        // Load Member data
        public void loadMemberData()
        {

            try
            {

                SqlConnection conn = ConnectSQL.getDBConnection();
                conn.Open();

                String cmd = "select * from Member";
                SqlCommand comm = new SqlCommand(cmd, conn);
                comm.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(comm); // lấy dữ liệu về
                DataTable dt = new DataTable();     // tạo kho ảo chưa dữ liệu
                da.Fill(dt);

                conn.Close();

                dgvMember.DataSource = dt;

                dgvMember.Columns["mbirth"].DefaultCellStyle.Format = "MM-dd-yyyy";
                cmbBDMID.DataSource = dt;
                cmbBDMID.DisplayMember = "mid";


                cmbMID.DataSource = dt;
                cmbMID.DisplayMember = "mid";
                cmbMID.ValueMember = "mid";
            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
        }

        // Load Project data
        public void loadProjectData()
        {

            try
            {

                SqlConnection conn = ConnectSQL.getDBConnection();
                conn.Open();

                String cmd = "select * from Project";
                SqlCommand comm = new SqlCommand(cmd, conn);
                comm.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(comm); // lấy dữ liệu về
                DataTable dt = new DataTable();     // tạo kho ảo chưa dữ liệu
                da.Fill(dt);

                conn.Close();

                dgvProject.DataSource = dt;

              
            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
        }
        // Load BorrowedDetails data
        public void loadBorrowedDetailsData()
        {
            try
            {

                SqlConnection conn = ConnectSQL.getDBConnection();
                conn.Open();

                String cmd = "select * from BorrowedDetails";
                SqlCommand comm = new SqlCommand(cmd, conn);
                comm.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(comm); // lấy dữ liệu về
                DataTable dt = new DataTable();     // tạo kho ảo chưa dữ liệu
                da.Fill(dt);


                dgvBorrowed.DataSource = dt;

                dgvBorrowed.Columns["bdstartingdate"].DefaultCellStyle.Format = "MM-dd-yyyy";
                dgvBorrowed.Columns["bdenddate"].DefaultCellStyle.Format = "MM-dd-yyyy";
                cmbBDDID.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbBDMID.DropDownStyle = ComboBoxStyle.DropDownList;

                conn.Close();

            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
        }
        // Load your borrowed
        private void loadYourBorrow()
        {
            try
            {

                SqlConnection conn = ConnectSQL.getDBConnection();
                conn.Open();

                String cmd = "select * from BorrowedDetails where mid = '" + Login.idLogin + "'";
                SqlCommand comm = new SqlCommand(cmd, conn);
                comm.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(comm); // lấy dữ liệu về
                DataTable dt = new DataTable();     // tạo kho ảo chưa dữ liệu
                da.Fill(dt);


                dgvYourBorrow.DataSource = dt;

                dgvYourBorrow.Columns["bdstartingdate"].DefaultCellStyle.Format = "MM-dd-yyyy";
                dgvYourBorrow.Columns["bdenddate"].DefaultCellStyle.Format = "MM-dd-yyyy";

                conn.Close();

            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
        }
        // Load project inProject
        private void loadSProject()
        {
            try
            {

                SqlConnection conn = ConnectSQL.getDBConnection();
                conn.Open();

                String cmd = "select PID, PNAME, PLEADER from Project";
                SqlCommand comm = new SqlCommand(cmd, conn);
                comm.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(comm); // lấy dữ liệu về
                DataTable dt = new DataTable();     // tạo kho ảo chưa dữ liệu
                da.Fill(dt);

                conn.Close();

                dgvSProject.DataSource = dt;

            }
            catch (Exception ex)
            {
                Console.Write(ex);
                
            }

            
        }
        // Load member inProject
        private void loadSMember()
        {
            try
            {

                SqlConnection conn = ConnectSQL.getDBConnection();
                conn.Open();
                String temppid = dgvSProject.CurrentRow.Cells[0].Value.ToString();
                String cmd = "select M.mid, M.mname, inP.Type from Member M, inProject inP where M.mid = inP.mid and inp.PID = '" + temppid + "'" ;
                SqlCommand comm = new SqlCommand(cmd, conn);
                comm.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(comm); // lấy dữ liệu về
                DataTable dt = new DataTable();     // tạo kho ảo chưa dữ liệu
                da.Fill(dt);

                conn.Close();

                dgvSMember.DataSource = dt;
               
            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
        }


        #endregion

        #region Divice Management Tab

        private void readOnlyDivice_False()
        {
            txtDID.ReadOnly = false;
            txtDName.ReadOnly = false;
            txtDDescription.ReadOnly = false;
            txtDBorrowed.ReadOnly = false;
            txtDQuantity.ReadOnly = false;

        }

        private void readOnlyDivice_True()
        {
            txtDID.ReadOnly = true;
            txtDName.ReadOnly = true;
            txtDDescription.ReadOnly = true;
            txtDBorrowed.ReadOnly = true;
            txtDQuantity.ReadOnly = true;

        }

        // Clear text trong Tab Divice
        private void clearDiviceText()
        {
            txtDBorrowed.Clear();
            txtDID.Clear();
            txtDName.Clear();
            txtDDescription.Clear();
            txtDQuantity.Clear();
        }

        // Get Value for grpDiviceText
        private void getValueForText()
        {
            try
            {
                txtDID.Text = dgvDivice.CurrentRow.Cells["did"].Value.ToString();
                txtDName.Text = dgvDivice.CurrentRow.Cells["dname"].Value.ToString();
                txtDQuantity.Text = dgvDivice.CurrentRow.Cells["dquantity"].Value.ToString();
                txtDBorrowed.Text = dgvDivice.CurrentRow.Cells["dborrowed"].Value.ToString();
                txtDDescription.Text = dgvDivice.CurrentRow.Cells["ddescription"].Value.ToString();
            }
            catch (Exception ex)
            {

                Console.Write(ex);
            }

        }
     
        private void showDSaveButton()   // Whhen click Add or Edit button
        {
            btnDSave.Enabled = true;
            btnDCancel.Enabled = true;
            btnDAdd.Enabled = false;
            btnDEdit.Enabled = false;
            btnDDelete.Enabled = false;


        }

        private void hideDSaveButton()   // When click Save or Clear button
        {
            btnDSave.Enabled = false;
            btnDCancel.Enabled = false;
            btnDAdd.Enabled = true;
            btnDEdit.Enabled = true;
            btnDDelete.Enabled = true;


        }


        // Add Divice
        private void btnDAdd_Click(object sender, EventArgs e)
        {
            dgvDivice.Enabled = false;  // can't click to Datagridview
            dgvDivice.ClearSelection();
            

            clearDiviceText();
            readOnlyDivice_False();
            txtDID.Focus();
            txtDBorrowed.Text = "0";
            txtDBorrowed.Enabled = false;
            
            mode = Mode.Add;
            showDSaveButton();
            
        }

        // Check Divice ID, couldn't exist on database
        private Boolean isExistedDID()
        {

            switch (mode)
            {
                case Mode.Edit:
                    {
                        for (int i = 0; i < dgvDivice.RowCount; i++)
                        {

                            try
                            {
                                if (dgvDivice.Rows[i].Cells[0].Value.ToString() == txtDID.Text && dgvDivice.CurrentRow != dgvDivice.Rows[i])
                                {

                                    return true;    // has existed
                                }
                            }
                            catch (Exception ex)
                            {

                                Console.Write("Error");
                            }
                        }

                        break;
                    }
                case Mode.Add:
                    {
                        for (int i = 0; i < dgvDivice.RowCount; i++)
                        {

                            try
                            {
                                if (dgvDivice.Rows[i].Cells[0].Value.ToString() == txtDID.Text)
                                {

                                    return true;    // has existed
                                }
                            }
                            catch (Exception ex)
                            {

                                Console.Write("Error");
                            }
                        }

                        break;
                        
                    }
            }

            return false;

        }

        // Save Add or Edit divice
        private void btnDSave_Click(object sender, EventArgs e)
        {
            Boolean check = isExistedDID();

            switch (mode)
            {
                case Mode.Edit:
                    {
                        if (!check)
                        {


                            try
                            {
                                if (Int32.Parse(txtDQuantity.Text) > 0)
                                {
                                    String currDID = dgvDivice.CurrentRow.Cells["did"].Value.ToString();
                                    Divice.editDivice(currDID, txtDID.Text, txtDName.Text, txtDQuantity.Text, txtDBorrowed.Text, txtDDescription.Text);

                                    loadDiviceData();

                                    hideDSaveButton();
                                    readOnlyDivice_True();
                                    txtDBorrowed.Enabled = true;
                                    dgvDivice.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("Quantity can't less than 0, please!!!");
                                }
                            }
                            catch (Exception ex)
                            {

                                Console.Write("Error: " + ex);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Divice ID has existed, please get a new one!!!");
                        }

                        break;
                    }
                case Mode.Add:
                    {
                        if (!check)
                        {


                            try
                            {
                                if (Int32.Parse(txtDQuantity.Text) > 0)
                                {
                                    Divice.addDivice(txtDID.Text, txtDName.Text, txtDQuantity.Text, txtDBorrowed.Text, txtDDescription.Text);

                                    loadDiviceData();

                                    hideDSaveButton();
                                    readOnlyDivice_True();
                                    txtDBorrowed.Enabled = true;
                                    dgvDivice.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("Quantity can't less than 0, please!!!");
                                }
                            }
                            catch (Exception ex)
                            {

                                Console.Write("Error: " + ex);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Divice ID has existed, please get a new one!!!");
                        }

                        break;
                    }
            }


        }

        
        // Show to TextBox
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            getValueForText();
            int quan = Int32.Parse(txtDQuantity.Text);
            int borr = Int32.Parse(txtDBorrowed.Text);
            txtRemaining.Text = (quan - borr).ToString();
        }

        // Delete Divice
        private void btnDDelete_Click(object sender, EventArgs e)
        {
            String str = "Do you wanna delete divice '" + txtDName.Text + "' ???";
            DialogResult result = MessageBox.Show(str, "Delete Question", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(result == DialogResult.Yes)
            {
                String id = dgvDivice.CurrentRow.Cells["did"].Value.ToString();
                
                Divice.deleteDivice(id);

                loadDiviceData();
            }
            
        }

        // Edit Divice
        private void btnDEdit_Click(object sender, EventArgs e)
        {
            readOnlyDivice_False();
            txtDID.Focus();
            dgvDivice.Enabled = false;

            mode = Mode.Edit;
            showDSaveButton();
        }

        

        //  When Search Divice
        private void SearchDivice(object sender, EventArgs e)
        {
            // Search by ID
            if (txtDSearch.Text == "")
            {
                loadDiviceData();

            }
            else if (cmbDTypeSearch.Text == "Divice ID")
            {
                SqlConnection conn = ConnectSQL.getDBConnection();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Divice where DID like '" + txtDSearch.Text + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvDivice.DataSource = dt;

            }
            else if (cmbDTypeSearch.Text == "Divice Name")
            {
                SqlConnection conn = ConnectSQL.getDBConnection();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Divice where DName like '" + txtDSearch.Text + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvDivice.DataSource = dt;
            }


        }

        // Cancel Add or Edit Divice
        private void btnDCancel_Click_1(object sender, EventArgs e)
        {
            loadDiviceData();

            hideDSaveButton();
            readOnlyDivice_True();
            txtDBorrowed.Enabled = true;
            dgvDivice.Enabled = true;
        }

        





        #endregion

        #region Member Management Tab

        // Show to Text data from DataGridView
        private void dgvMember_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMID.Text =  dgvMember.CurrentRow.Cells["mid"].Value.ToString();
                txtMName.Text = dgvMember.CurrentRow.Cells["mname"].Value.ToString();
                txtMAdress.Text = dgvMember.CurrentRow.Cells["madress"].Value.ToString();
                txtMEmail.Text = dgvMember.CurrentRow.Cells["memail"].Value.ToString();
                txtMPhone.Text = dgvMember.CurrentRow.Cells["mphone"].Value.ToString();
                dtpMBirth.Value = DateTime.Parse(dgvMember.CurrentRow.Cells["mbirth"].Value.ToString());
                dtpMBirth.CustomFormat = "MM-dd-yyyy";
            }
            catch (Exception ex)
            {

                Console.Write("Error: " + ex);
            }
        }

        // clear Text Member
        private void clearMemberText()
        {
            txtMAdress.Clear();
            txtMEmail.Clear();
            txtMID.Clear();
            txtMName.Clear();
            txtMPhone.Clear();
            dtpMBirth.GetLifetimeService();

        }
        // readOnly Member Text
        private void readOnlyMember_False()
        {
            txtMAdress.ReadOnly = false;
            txtMEmail.ReadOnly = false;
            txtMID.ReadOnly = false;
            txtMName.ReadOnly = false;
            txtMPhone.ReadOnly = false;
            cmbMGender.Enabled = true;
            dtpMBirth.Enabled = true;
        }
        // readOnly Member Text  false
        private void readOnlyMember_True()
        {
            txtMAdress.ReadOnly = true;
            txtMEmail.ReadOnly = true;
            txtMID.ReadOnly = true;
            txtMName.ReadOnly = true;
            txtMPhone.ReadOnly = true;
            cmbMGender.Enabled = false;
            dtpMBirth.Enabled = false;
        }

        // show Member Save and Cancel 
        private void showMSaveButton()   // Whhen click Add or Edit button
        {
            btnMSave.Enabled = true;
            btnMCancel.Enabled = true;
            btnMAdd.Enabled = false;
            btnMEdit.Enabled = false;
            btnMDelete.Enabled = false;
        }

        // Delete Member
        private void btnMDelete_Click(object sender, EventArgs e)
        {
            String str = "Do you wanna delete member '" + txtMName.Text + "' ???";
            DialogResult result = MessageBox.Show(str, "Delete Question", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                String id = dgvMember.CurrentRow.Cells["mid"].Value.ToString();
                Member.deleteMember(id);

                loadMemberData();
            }
        }

        // Cancel Add or Edit member
        private void btnMCancel_Click(object sender, EventArgs e)
        {
            loadMemberData();

            hideMSaveButton();
            readOnlyMember_True();

            dgvMember.Enabled = true;
            hideMSaveButton();
        }

        // Add member
        private void btnMAdd_Click(object sender, EventArgs e)
        {
            dgvMember.Enabled = false;  // Can't click to Datagridview
            dgvMember.ClearSelection();

            clearMemberText();  // Clear Text 
            readOnlyMember_False();
            txtMID.Focus();


            mode = Mode.Add;
            showMSaveButton();

        }

        // Edit member
        private void btnMEdit_Click(object sender, EventArgs e)
        {
            readOnlyMember_False();
            txtMID.Focus();

            mode = Mode.Edit;
            showMSaveButton();
        }

        // Save Add or Delete member
        private void btnMSave_Click(object sender, EventArgs e)
        {
            Boolean check = isExistedMID();
            
            switch (mode)
            {   
                case Mode.Edit:
                    {
                        if (!check)
                        {
                            // Save when Edit mode
                            String currMID = dgvMember.CurrentRow.Cells["mid"].Value.ToString();
                            Member.editMember(currMID, txtMID.Text, txtMName.Text, cmbMGender.Text, dtpMBirth.Text, txtMAdress.Text, txtMPhone.Text, txtMEmail.Text);
                            loadMemberData();

                            hideMSaveButton();
                            readOnlyMember_True();
                            
                            dgvMember.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("Member ID has existed, please get a new one!!!");
                        }

                        break;
                    }
                case Mode.Add:
                    {
                        if (!check)
                        {
                            // Save when Add Member
                            Member.addMember(txtMID.Text, txtMName.Text, cmbMGender.Text, dtpMBirth.Text, txtMAdress.Text, txtMPhone.Text, txtMEmail.Text);
                            String AID = "Member_" + txtMID.Text;
                            String Pass = txtMID.Text + txtMPhone.Text;
                            Member.addAccount(AID, txtMID.Text, Pass, "0");
                            loadMemberData();

                            hideMSaveButton();
                            readOnlyDivice_True();
                            dgvMember.Enabled = true;
                            

                        }
                        else
                        {
                            MessageBox.Show("Member ID has existed, please get a new one!!!");
                        }

                        break;
                    }
            }
        }

        // hide Member Save and Cancel
        private void hideMSaveButton()   // Whhen click Add or Edit button
        {
            btnMSave.Enabled = false;
            btnMCancel.Enabled = false;
            btnMAdd.Enabled = true;
            btnMEdit.Enabled = true;
            btnMDelete.Enabled = true;


        }

        // Search Member
        private void SearchMember(object sender, EventArgs e)
        {
            // Search by ID
            if (txtMSearch.Text == "")
            {
                loadMemberData();

            }
            else if (cmbMSearch.Text == "Member ID")
            {
                SqlConnection conn = ConnectSQL.getDBConnection();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Member where MID like '" + txtMSearch.Text + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvMember.DataSource = dt;

            }
            else if (cmbMSearch.Text == "Member Name")
            {
                SqlConnection conn = ConnectSQL.getDBConnection();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Member where MName like '" + txtMSearch.Text + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvMember.DataSource = dt;
            }
        }


        // check MID
        private Boolean isExistedMID()
        {
            switch(mode)
            {
                case Mode.Edit:
                    {
                    for (int i = 0; i < dgvMember.RowCount; i++)
                    {

                        try
                        {
                            if (dgvMember.Rows[i].Cells[0].Value.ToString() == txtMID.Text && dgvMember.CurrentRow != dgvMember.Rows[i])
                            {

                                return true;    // has existed
                            }
                        }
                        catch (Exception ex)
                        {

                            Console.Write("Error");
                        }
                    }

                    break;
                }
                case Mode.Add:
                    {
                    for (int i = 0; i < dgvMember.RowCount; i++)
                    {

                        try
                        {
                            if (dgvMember.Rows[i].Cells[0].Value.ToString() == txtMID.Text)
                            {

                                return true;    // has existed
                            }
                        }
                        catch (Exception ex)
                        {

                            Console.Write("Error");
                        }
                    }

                    break;

                }
            }

            return false;
        }

        #endregion

        #region Project Management Tab

        // change text to ReadOnly mode
        private void readOnlyProject_True()
        {
            txtPID.ReadOnly = true;
            txtPDescription.ReadOnly = true;
            txtPLeader.ReadOnly = true;
            txtPName.ReadOnly = true;
            dtpPEnd.Enabled = false;
            dtpPStart.Enabled = false;
        }
        // Load data to Textbox
        private void dgvProject_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtPID.Text = dgvProject.CurrentRow.Cells["pid"].Value.ToString();
                txtPDescription.Text = dgvProject.CurrentRow.Cells["pdescription"].Value.ToString();
                txtPName.Text = dgvProject.CurrentRow.Cells["pname"].Value.ToString();
                txtPLeader.Text = dgvProject.CurrentRow.Cells["pleader"].Value.ToString();
                dtpPStart.Value = DateTime.Parse(dgvProject.CurrentRow.Cells["PStartingDate"].Value.ToString());
                dtpPEnd.Value = DateTime.Parse(dgvProject.CurrentRow.Cells["PEndDate"].Value.ToString());
                dtpPStart.CustomFormat = "MM-dd-yyyy";
                dtpPEnd.CustomFormat = "MM-dd-yyyy";
            }
            catch (Exception ex)
            {

                //MessageBox.Show(dgvProject.CurrentRow.Cells["PEndDate"].Value.ToString());
            }
        }
        // change textbox out ReadOnly mode
        private void readOnlyProject_False()
        {
            txtPName.ReadOnly = false;
            txtPID.ReadOnly = false;
            txtPDescription.ReadOnly = false;
            dtpPStart.Enabled = true;
            dtpPEnd.Enabled = true;
        }
        // Clear textbox
        private void clearProjectText()
        {
            txtPDescription.Clear();
            txtPID.Clear();
            txtPName.Clear();
            txtPLeader.Clear();
        }
        // Show Save button
        private void showPSaveButton()
        {
            btnPSave.Enabled = true;
            btnPCancel.Enabled = true;
            btnPAdd.Enabled = false;
            btnPEdit.Enabled = false;
            btnPDelete.Enabled = false;
        }
        // Hide Save button
        private void hidePSaveButton()
        {
            btnPSave.Enabled = false;
            btnPCancel.Enabled = false;
            btnPAdd.Enabled = true;
            btnPEdit.Enabled = true;
            btnPDelete.Enabled = true;
        }
        // Add project
        private void btnPAdd_Click(object sender, EventArgs e)
        {
            
            dgvProject.Enabled = false;  // can't click to Datagridview
            dgvProject.ClearSelection();

            clearProjectText();
            readOnlyProject_False();
            txtPID.Focus();
            txtPLeader.Text = Login.idLogin;

            mode = Mode.Add;
            showPSaveButton();
        }
        
        // Edit Project - Only Leader
        private void btnPEdit_Click(object sender, EventArgs e)
        {
            if(txtPLeader.Text == Login.idLogin)
            {
                readOnlyProject_False();
                txtPID.Focus();

                mode = Mode.Edit;
                showPSaveButton();
            }
            else
            {
                MessageBox.Show("Only Leader must edit their project");
            }
        }
        // Delete Project - Only Leader
        private void btnPDelete_Click(object sender, EventArgs e)
        {
            if(txtPLeader.Text == Login.idLogin)
            {
                String str = "Do you wanna delete Project: " + txtPName.Text  + "?";
                DialogResult dr = MessageBox.Show(str, "Delete Project", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if(dr == DialogResult.Yes)
                {
                    Project.deleteProject(txtPID.Text);
                    loadProjectData();
                }
                
            }
            else
            {
                MessageBox.Show("Only Leader must delete their project, please!!!");
            }
        }
        // Check PID 
        private Boolean isExistedPID()
        {

            switch (mode)
            {
                case Mode.Edit:
                    {
                        for (int i = 0; i < dgvProject.RowCount; i++)
                        {

                            try
                            {
                                if (dgvProject.Rows[i].Cells[0].Value.ToString() == txtPID.Text && dgvProject.CurrentRow != dgvProject.Rows[i])
                                {

                                    return true;    // has existed
                                }
                            }
                            catch (Exception ex)
                            {

                                Console.Write("Error");
                            }
                        }

                        break;
                    }
                case Mode.Add:
                    {
                        for (int i = 0; i < dgvProject.RowCount; i++)
                        {

                            try
                            {
                                if (dgvProject.Rows[i].Cells[0].Value.ToString() == txtPID.Text)
                                {

                                    return true;    // has existed
                                }
                            }
                            catch (Exception ex)
                            {

                                Console.Write("Error");
                            }
                        }

                        break;

                    }
            }

            return false;

        }
        // Save Add or Edit Project
        private void btnPSave_Click(object sender, EventArgs e)
        {
            Boolean check = isExistedPID();

            if(dtpPStart.Value < dtpPEnd.Value)
            {
                switch (mode)
                {
                    case Mode.Edit:
                        {
                            if (!check)
                            {
                                try
                                {
                                    String currPID = dgvProject.CurrentRow.Cells["pid"].Value.ToString();
                                    Project.editProject(currPID, txtPID.Text, txtPName.Text, dtpPStart.Text, dtpPEnd.Text, txtPLeader.Text, txtPDescription.Text);
                                    loadProjectData();
                                    //loadinProject();

                                    hidePSaveButton();
                                    readOnlyProject_True();
                                    dgvProject.Enabled = true;

                                }
                                catch (Exception ex)
                                {

                                    Console.Write("Error: " + ex);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Project ID has existed, please get a new one!!!");
                            }

                            break;
                        }
                    case Mode.Add:
                        {
                            if (!check)
                            {


                                try
                                {

                                    Project.addProject(txtPID.Text, txtPName.Text, dtpPStart.Text, dtpPEnd.Text, txtPLeader.Text, txtPDescription.Text);
                                    Project.addinProject(txtPID.Text, Login.idLogin, "Leader");

                                    loadProjectData();
                                    loadSProject();

                                    hidePSaveButton();
                                    readOnlyProject_True();
                                    dgvProject.Enabled = true;

                                }
                                catch (Exception ex)
                                {

                                    Console.Write("Error: " + ex);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Divice ID has existed, please get a new one!!!");
                            }

                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Starting Date can't less than End Date");
                dtpPStart.Focus();
            }
        }
        // Cancel Add or Edit Project
        private void btnPCancel_Click(object sender, EventArgs e)
        {
            loadProjectData();

            hidePSaveButton();
            readOnlyProject_True();
            dgvProject.Enabled = true;
        }


        // Search Project
        private void SearchProject(object sender, EventArgs e)
        {
            // Search by ID
            if (txtPSearch.Text == "")
            {
                loadProjectData();

            }
            else if (cmbPSearch.Text == "Project ID")
            {
                SqlConnection conn = ConnectSQL.getDBConnection();  
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Project where PID like '" + txtPSearch.Text + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvProject.DataSource = dt;

            }
            else if (cmbPSearch.Text == "Project Name")
            {
                SqlConnection conn = ConnectSQL.getDBConnection();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Project where PName like '" + txtPSearch.Text + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvProject.DataSource = dt;
            }
        }


        #endregion


        #region Borrowed Detail Management
        // change text to ReadOnly mode
        private void readOnlyBorrowed_True()
        {
            cmbBDDID.Enabled = false;
            txtBDManager.ReadOnly = true;
            cmbBDMID.Enabled = false;
            txtBDID.ReadOnly = true;
            txtBDAmount.ReadOnly = true;
            dtpBDEndDate.Enabled = false;
            dtpBDStartingDate.Enabled = false;
        }

        // change textbox out ReadOnly mode
        private void readOnlyBorrowed_False()
        {
            cmbBDDID.Enabled = true;
            //txtBDManager.ReadOnly = false;
            cmbBDMID.Enabled = true;
            txtBDID.ReadOnly = false;
            txtBDAmount.ReadOnly = false;
            dtpBDEndDate.Enabled = true;
            dtpBDStartingDate.Enabled = true;
        }
        // Clear textbox
        private void clearBorrowedText()
        {
            txtBDManager.Clear();
            txtBDID.Clear();
        }
        // Show Save button
        private void showBDSaveButton()
        {
            btnBDSave.Enabled = true;
            btnBDCancel.Enabled = true;
            btnBDAdd.Enabled = false;
            //btnBDEdit.Enabled = false;
            btnBDDelete.Enabled = false;
        }
        // Hide Save button
        private void hideBDSaveButton()
        {
            btnBDSave.Enabled = false;
            btnBDCancel.Enabled = false;
            btnBDAdd.Enabled = true;
           // btnBDEdit.Enabled = true;
            btnBDDelete.Enabled = true;
        }
        // Show to textbox
        private void dgvBorrowed_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtBDID.Text = dgvBorrowed.CurrentRow.Cells["bdid"].Value.ToString();
                cmbBDDID.Text = dgvBorrowed.CurrentRow.Cells["bddid"].Value.ToString();
                cmbBDMID.Text = dgvBorrowed.CurrentRow.Cells["bdmid"].Value.ToString();
                txtBDAmount.Text = dgvBorrowed.CurrentRow.Cells["ab"].Value.ToString();
                txtBDManager.Text = dgvBorrowed.CurrentRow.Cells["bdmanager"].Value.ToString();
                dtpBDStartingDate.Value = DateTime.Parse(dgvBorrowed.CurrentRow.Cells["BDStartingDate"].Value.ToString());
                dtpBDEndDate.Value = DateTime.Parse(dgvBorrowed.CurrentRow.Cells["BDEndDate"].Value.ToString());
                dtpBDStartingDate.CustomFormat = "MM-dd-yyyy";
                dtpBDEndDate.CustomFormat = "MM-dd-yyyy";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        // Add Borrowed Ticket
        private void btnBDAdd_Click(object sender, EventArgs e)
        {
            dgvBorrowed.Enabled = false;  // can't click to Datagridview
            dgvBorrowed.ClearSelection();
            clearBorrowedText();
            txtBDID.Text = cmbBDMID.Text + "_" + cmbBDDID.Text;
            dtpBDStartingDate.GetLifetimeService();

            readOnlyBorrowed_False();
            txtBDID.Focus();
            txtBDManager.Text = Login.idLogin;
            dtpBDStartingDate.GetLifetimeService();

            mode = Mode.Add;
            showBDSaveButton();
        }
        // Edit Borrowed Ticket
        private void btnBDEdit_Click(object sender, EventArgs e)
        {
            if (txtBDManager.Text == Login.idLogin)
            {
                readOnlyBorrowed_False();
                txtBDID.Focus();
                
                mode = Mode.Edit;
                showBDSaveButton();
            }
            else
            {
                MessageBox.Show("Only Manager must edit their project");
            }
        }
        // Delete Borrowed Ticket
        private void btnBDDelete_Click(object sender, EventArgs e)
        {
            if(txtBDManager.Text == Login.idLogin)
            {
                String str = "Do you wanna delete Borrowed Ticket: " + txtBDID.Text + "?";
                DialogResult dr = MessageBox.Show(str, "Delete Borrowed Ticket", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    Borrowed.deleteBorrowed(txtBDID.Text);
                    Divice.changeBorrowed(cmbBDDID.Text, borrowed + 1);

                    loadBorrowedDetailsData();
                    loadYourBorrow();
                    loadDiviceData();
                }
            }
            else
            {
                MessageBox.Show("Only Manager must delele borrowed ticket which is managed by them!!!");
            }
        }
        // Check BDID 
        private Boolean isExistedBDID()
        {

            switch (mode)
            {
                case Mode.Edit:
                    {
                        for (int i = 0; i < dgvBorrowed.RowCount; i++)
                        {

                            try
                            {
                                if (dgvBorrowed.Rows[i].Cells[0].Value.ToString() == txtBDID.Text && dgvBorrowed.CurrentRow != dgvBorrowed.Rows[i])
                                {

                                    return true;    // has existed
                                }
                            }
                            catch (Exception ex)
                            {

                                Console.Write("Error");
                            }
                        }

                        break;
                    }
                case Mode.Add:
                    {
                        for (int i = 0; i < dgvBorrowed.RowCount; i++)
                        {

                            try
                            {
                                if (dgvBorrowed.Rows[i].Cells[0].Value.ToString() == txtBDID.Text)
                                {

                                    return true;    // has existed
                                }
                            }
                            catch (Exception ex)
                            {

                                Console.Write("Error");
                            }
                        }

                        break;

                    }
            }

            return false;

        }
        // Save add or edit
        private void btnBDSave_Click(object sender, EventArgs e)
        {
            Boolean check = isExistedBDID();

            if (dtpBDStartingDate.Value < dtpBDEndDate.Value)
            {
                switch (mode)
                {
                    case Mode.Edit:
                        {
                            if (!check)
                            {
                                try
                                {
                                    String currBDID = dgvBorrowed.CurrentRow.Cells["bdid"].Value.ToString();
                                    Borrowed.editBorrowed(currBDID, txtBDID.Text, cmbBDDID.Text, cmbBDMID.Text, dtpBDStartingDate.Text, dtpBDEndDate.Text, txtBDAmount.Text, txtBDManager.Text);
                                    loadBorrowedDetailsData();
                                    loadYourBorrow();
                                    loadDiviceData();

                                    hideBDSaveButton();
                                    readOnlyBorrowed_True();
                                    dgvBorrowed.Enabled = true;

                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.ToString());
                                }

                            }
                            else
                            {
                                MessageBox.Show("Borrowed ID has existed, please get a new one!!!");
                            }

                            break;
                        }
                    case Mode.Add:
                        {
                            if (!check)
                            {


                                try
                                {

                                    Borrowed.addBorrowed(txtBDID.Text, cmbBDDID.Text, cmbBDMID.Text, dtpBDStartingDate.Text, dtpBDEndDate.Text, txtBDAmount.Text, txtBDManager.Text);
                                    int temp = Int32.Parse(txtBDAmount.Text);
                                    Divice.changeBorrowed(cmbBDDID.Text, borrowed + temp);
                                    loadBorrowedDetailsData();
                                    loadDiviceData();
                                    loadYourBorrow();

                                    hideBDSaveButton();
                                    readOnlyBorrowed_True();
                                    dgvBorrowed.Enabled = true;

                                }
                                catch (Exception ex)
                                {

                                    Console.Write("Error: " + ex);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Borrowed ID has existed, please get a new one!!!");
                            }

                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Starting Date can't less than End Date");
                dtpPStart.Focus();
            }
        }
        // Cancel add or edit
        private void btnBDCancel_Click(object sender, EventArgs e)
        {
            loadBorrowedDetailsData();

            hideBDSaveButton();
            readOnlyBorrowed_True();
            dgvBorrowed.Enabled = true;
        }


        #endregion


        #region Borrow - Reimburse
        private void dgvYourProject_SelectionChanged(object sender, EventArgs e)
        {
           // loadinProject();
        }

        private void cmbBDDID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = ConnectSQL.getDBConnection();
                conn.Open();

                String cmd = "select DQuantity, DBorrowed from Divice where did = '" + cmbBDDID.Text + "'";
                SqlCommand comm = new SqlCommand(cmd, conn);
                comm.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(comm); // lấy dữ liệu về
                DataTable dt = new DataTable();     // tạo kho ảo chưa dữ liệu
                da.Fill(dt);

                conn.Close();

                 quantity = Int32.Parse(dt.Rows[0]["dquantity"].ToString());
                 borrowed = Int32.Parse(dt.Rows[0]["dborrowed"].ToString());
                remain = quantity - borrowed;
                txtBDAmount.Maximum = remain;
                txtMaxAmount.Text = remain.ToString();
                txtBDID.Text = cmbBDMID.Text + "_" + cmbBDDID.Text;

            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
        }

        private void dgvSProject_SelectionChanged(object sender, EventArgs e)
        {
            loadSMember();
            cmbPID.Text = dgvSProject.CurrentRow.Cells[0].Value.ToString();
            //cmbMID.Text = dgvSMember.CurrentRow.Cells[0].Value.ToString();
        }

        private Boolean isExistinProject()
        {
            for (int i = 0; i < dgvSMember.RowCount; i++)
            {

                try
                {
                    if (dgvSMember.Rows[i].Cells[0].Value.ToString() == cmbMID.Text )
                    {

                        return true;    // has existed
                    }
                }
                catch (Exception ex)
                {

                    Console.Write("Error");
                }
            }
            return false;
        }

        private void btnAddtoProject_Click(object sender, EventArgs e)
        {
            if(!isExistinProject())
            {
                if (Login.idLogin == dgvSProject.CurrentRow.Cells[2].Value.ToString())
                {
                    Project.addinProject(cmbPID.Text, cmbMID.Text, cmbType.Text);
                    loadSProject();
                }
                else
                {
                    MessageBox.Show("You aren't leader of this project");
                }
            }
            else
            {
                MessageBox.Show("Member has existed in this Project");
            }
        }

        private void btnRemovefromProject_Click(object sender, EventArgs e)
        {
            if (Login.idLogin == dgvSProject.CurrentRow.Cells[2].Value.ToString())
            {
                Project.removeInProject(cmbPID.Text, cmbMID.Text);
                loadSProject();
            }
            else
            {
                MessageBox.Show("You aren't leader of this project");
            }
        }

        private void txtBSearch_TextChanged(object sender, EventArgs e)
        {
            // Search by ID
            if (txtBSearch.Text == "")
            {
                loadBorrowedDetailsData();

            }
            else if (cmbBSearch.Text == "BD ID")
            {
                SqlConnection conn = ConnectSQL.getDBConnection();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from BorrowedDetails where BDID like '" + txtBSearch.Text + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvBorrowed.DataSource = dt;

            }
            else if (cmbBSearch.Text == "Divice ID")
            {
                SqlConnection conn = ConnectSQL.getDBConnection();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from BorrowedDetails where DID like '" + txtBSearch.Text + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvBorrowed.DataSource = dt;
            }
            else if (cmbBSearch.Text == "Member ID")
            {
                SqlConnection conn = ConnectSQL.getDBConnection();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from BorrowedDetails where MID like '" + txtBSearch.Text + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvBorrowed.DataSource = dt;
            }
        }

        // Button Borrow
        private void button1_Click(object sender, EventArgs e)
        {
            checkAdminPermission checkForm = new checkAdminPermission();
            checkForm.ShowDialog();
            if(checkAdminPermission.check == true)
            {
                BorrowFrom borrowform = new BorrowFrom();
                borrowform.ShowDialog();

                loadBorrowedDetailsData();
                loadDiviceData();
                loadYourBorrow();
            }
        }

        private void btnReimburse_Click(object sender, EventArgs e)
        {
            checkAdminPermission checkForm = new checkAdminPermission();
            checkForm.ShowDialog();
            if (checkAdminPermission.check == true)
            {
                    String str = "Do you wanna delete Borrowed Ticket: " + dgvYourBorrow.CurrentRow.Cells[0].Value.ToString() + "?";
                    DialogResult dr = MessageBox.Show(str, "Delete Borrowed Ticket", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.Yes)
                    {
                        int temp = Int32.Parse(dgvYourBorrow.CurrentRow.Cells["amountb"].Value.ToString());
                        Borrowed.deleteBorrowed(dgvYourBorrow.CurrentRow.Cells[0].Value.ToString());
                        
                        Divice.changeBorrowed(cmbBDDID.Text, borrowed - temp);

                        loadBorrowedDetailsData();
                        loadYourBorrow();
                        loadDiviceData();
                    }

                loadBorrowedDetailsData();
                loadYourBorrow();
                loadDiviceData();
            }

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void txtSMSearch_TextChanged(object sender, EventArgs e)
        {
            // Search by ID
            if (txtSMSearch.Text == "")
            {
                loadSMember();

            }
            else if (cmbSMemberSearch.Text == "Member ID")
            {
                String temppid = dgvSProject.CurrentRow.Cells[0].Value.ToString();
                String comm = "select M.mid, M.mname, inP.Type from Member M, inProject inP where M.mid = inP.mid and M.mid like '" + txtSMSearch.Text + "%' and inP.pid = '" + temppid + "'";
                SqlConnection conn = ConnectSQL.getDBConnection();
                SqlDataAdapter sda = new SqlDataAdapter(comm, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvSMember.DataSource = dt;

            }
            else if (cmbSMemberSearch.Text == "Member Name")
            {
               
                String temppid = dgvSProject.CurrentRow.Cells[0].Value.ToString();
                String comm = "select M.mid, M.mname, inP.Type from Member M, inProject inP where M.mid = inP.mid and M.mname like '" + txtSMSearch.Text + "%' and inP.pid = '" + temppid + "'";

                SqlConnection conn = ConnectSQL.getDBConnection();
                SqlDataAdapter sda = new SqlDataAdapter(comm, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvSMember.DataSource = dt;
            }
        }

        private void cmbBDMID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBDID.Text = cmbBDMID.Text + "_" + cmbBDDID.Text;
        }

        private void a(object sender, EventArgs e)
        {

        }

        private void dgvYourBorrow_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = ConnectSQL.getDBConnection();
                conn.Open();

                String cmd = "select DQuantity, DBorrowed from Divice where did = '" + dgvYourBorrow.CurrentRow.Cells[2].Value.ToString() + "'";
                SqlCommand comm = new SqlCommand(cmd, conn);
                comm.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(comm); // lấy dữ liệu về
                DataTable dt = new DataTable();     // tạo kho ảo chưa dữ liệu
                da.Fill(dt);

                conn.Close();

                quantity = Int32.Parse(dt.Rows[0]["dquantity"].ToString());
                borrowed = Int32.Parse(dt.Rows[0]["dborrowed"].ToString());
                remain = quantity - borrowed;

            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wanna SWITCH USER????", "SWICH USER", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(dr == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wanna EXIT SYSTEM????", "EXIT SYSTEM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



    }
}
