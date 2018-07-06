using System;
using System.Data.SqlClient;
using ToolLibrary.Logger;
using ToolLibrary.Logger.Models;

namespace ToolLibrary.Database.DatabaseConnection
{
    public static class DatabaseConnectionHandler
    {
        private const string CONNECTIONSTRING = "localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        private static JsonLogger _logger = new JsonLogger();

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
                Logger.JsonLogger _logger = new Logger.JsonLogger();
                LogObject lo = new LogObject(e);
                _logger.LogError(lo);
            }
        }
    }
}
