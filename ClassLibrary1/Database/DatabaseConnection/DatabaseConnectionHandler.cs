using System;
using System.Data.SqlClient;

namespace ToolLibrary.Database.DatabaseConnection
{
    public static class DatabaseConnectionHandler
    {
        private const string CONNECTIONSTRING = "localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";

        public static void TestConnection()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {

                }
            }
            catch (Exception e)
            {
                Logger.Logger.ErrorLog(e);
            }
        }
    }
}
