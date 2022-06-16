using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Dapper;

namespace Shared.Dungeons.DataManager
{
    public class DataManager
    {
        private SqlConnection mySqlConnection;
        private SqlCommand mySqlCommand;

        #region Databasevariables
        private const string Userid = "userid";
        private const string Password = "pwd";
        private const string Server = "localhost";
        private const string TrustedConnection = "yes";
        private const string Database = "main";
        private const int ConnectionTimeout = 10;
        #endregion

        public DataManager()
        {
            mySqlConnection = new SqlConnection($"user id={Userid};" +
                                             $"password={Password};" +
                                             $"server={Server};" +
                                             $"Trusted_Connection={TrustedConnection};" +
                                             $"Datahase={Database};" +
                                             $"Connection Timeout={ConnectionTimeout}");
            try
            {    
                mySqlConnection.Open();
                mySqlCommand = new SqlCommand("", mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Message);
            }
        }
    }
}