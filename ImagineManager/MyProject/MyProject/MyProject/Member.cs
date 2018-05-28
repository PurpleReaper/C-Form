using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    class Member
    {
        // Add member
        public static void addMember(String MID, String MName, String Gender, String Birth, String Adress, String Phone, String Email)
        {

            String cmd = "insert into Member values ('" + MID + "', N'" + MName + "', '" + Gender
                            + "', '" + Birth + "', N'" + Adress + "', '" + Phone + "', '" + Email + "')";
      

            try
            {
                SqlConnection conn = ConnectSQL.getDBConnection();
                conn.Open();
                SqlCommand comm = new SqlCommand(cmd, conn);

                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }


        }



        // Edit Member
        public static void editMember(String currMID, String MID, String MName, String Gender, String Birth, String Adress, String Phone, String Email)
        {


            String cmd = "update Member set MID = '" + MID + "', MName = N'" + MName + "', MGender = '" + Gender + "', MBirth = '"
                + Birth + "', MAdress = N'" + Adress + "', MPhone = '" + Phone + "', MEmail = '" + Email + "' where MID = '" + currMID + "'";

            try
            {
                SqlConnection conn = ConnectSQL.getDBConnection();
                conn.Open();
                SqlCommand comm = new SqlCommand(cmd, conn);

                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }

        }

        // Delete Member
        public static void deleteMember(String mid)
        {
            String cmd = "delete from Member where MID = '" + mid + "'";

            try
            {
                SqlConnection conn = ConnectSQL.getDBConnection();
                conn.Open();
                SqlCommand comm = new SqlCommand(cmd, conn);

                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This member has joined Project, remove from Project before Delete member");

            }
        }
        // Add Account
        public static void addAccount(String AID, String MID, String Pass, String Type)
        {

            String cmd = "insert into Account values ('" + AID + "', '" + MID + "', '" + Pass + "', " + Type + ")";
            MessageBox.Show("Add member success!!!");


            try
            {
                SqlConnection conn = ConnectSQL.getDBConnection();
                conn.Open();
                SqlCommand comm = new SqlCommand(cmd, conn);

                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }


        }
    }
}


