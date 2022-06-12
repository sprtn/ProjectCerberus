using System;
using System.Data.SqlClient;
using Shared.FileHandlers.Logger;
using Shared.FileHandlers.Logger.Models;

namespace Shared.Database.DatabaseConnection
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
                JsonLogger _logger = new JsonLogger();
                LogObject lo = new LogObject(e);
                _logger.LogError(lo);
            }
        }
    }
}
