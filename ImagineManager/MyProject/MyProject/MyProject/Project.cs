using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyProject
{
    class Project
    {
        // Add Project
        public static void addProject(String PID, String PName, String PStartingDate, String PEndDate, String PLeader, String PDescription)
        {

            String cmd = "insert into Project values ('" + PID + "', N'" + PName + "', '" + PStartingDate
                            + "', '" + PEndDate + "', '" + PLeader + "', N'" + PDescription + "')";
           

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



        // Edit Project
        public static void editProject(String currPID, String PID, String PName, String PStartingDate, String PEndDate, String PLeader, String PDescription)
        {


            String cmd = "update Project set PID = '" + PID + "', PName = N'" + PName + "', PStartingDate = '" + PStartingDate + "', PEndDate = '"
                + PEndDate + "', PLeader = '" + PLeader + "', PDescription = N'" + PDescription +  "' where PID = '" + currPID + "'";
            
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

        // Delete Project
        public static void deleteProject(String pid)
        {
            String cmd = "delete from Project where PID = '" + pid + "'";

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
        // Add member to Project
        public static void addinProject(String pid, String mid, String type)
        {
            String cmd = "insert into inProject values ('" + pid + "','" + mid + "', '" + type + "')";
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
        // Remove inProject
        public static void removeInProject(String pid, String mid)
        {
            String cmd = "delete from inProject where PID = '" + pid + "' and  MID = '" + mid + "'";

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
