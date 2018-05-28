using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    class Divice
    {


        #region Database Communicate
        // Add divice into Database - Thêm thiết bị vào CSDL
        public static void addDivice(String DID, String DName, String DQuantity, String DBorrowed, String DDescription)
        {
            String cmd = "insert into Divice values ('" + DID + "', N'" + DName + "', " + DQuantity
                            + ", " + DBorrowed + ", N'" + DDescription + "')";

            // Chưa thực thi - cần thêm Connection
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

        // Update divice info into Databasse - Sữa thông tin thiết bị
        public static void editDivice(String currentDID, String DID, String DName, String DQuantity, String DBorrowed, String DDescription)
        {
            String cmd = "update Divice set DID = '" + DID + "', DName = '" + DName + "', DQuantity = " + DQuantity + ", DBorrowed = "
                + DBorrowed + ", DDescription = N'" + DDescription + "' where DID = '" + currentDID + "'";

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

        // Delete divice out database - Xóa thiết bị
        public static void deleteDivice(String did)
        {
            String cmd = "delete from Divice where DID = '" + did + "'";

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
                MessageBox.Show("This divice has been borrowed, you can't delete it!!!");

            }
        }


        // When borrow divice
        public static void changeBorrowed(String did, int borrowed)
        {
            String cmd = "update Divice set dborrowed = '" + borrowed + "' where DID = '" + did + "'";

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

        #endregion

    }
}
