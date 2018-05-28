using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyProject
{
    class Borrowed
    {
        // Add Borrowed
        public static void addBorrowed(String BDID, String DID, String MID, String StartDate, String EndData, String amount, String manager)
        {

            String cmd = "insert into BorrowedDetails values ('" + BDID + "', '" + DID + "', '" + MID + "', '" + StartDate + "', '" 
                + EndData + "', " + amount + ", '" + manager + "')";
            
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
                MessageBox.Show(cmd);

            }


        }



        // Edit Borrowed
        public static void editBorrowed(String currBDID, String BDID, String DID, String MID, String StartDate, String EndData, String amount, String manager)
        {


            String cmd = "update BorrowedDetails set BDID = '" + BDID + "', DID = '" + DID + "', MID = '" 
                + MID + "', BDStartingDate = '" + StartDate + "', BDEndDate = '" + EndData + "', AmountBorrowed =  "
                + amount + ", BDManager = '" + manager + "' where BDID = '" + currBDID + "'";

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

        // Delete Borrowed
        public static void deleteBorrowed(String bdid)
        {
            String cmd = "delete from BorrowedDetails where BDID = '" + bdid + "'";

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
