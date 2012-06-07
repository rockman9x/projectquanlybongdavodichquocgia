using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace DALayer
{
    public class ConnectToDataBase
    {
        public static SqlConnection _SqlConnection;
        private static string strConnect = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
        static ConnectToDataBase()
        {
           
        }
        public static SqlConnection StartConnection()
        {
            try
            {
                _SqlConnection = new SqlConnection(strConnect);
                return _SqlConnection;
            }
            catch (Exception _ex)
            {
                throw _ex;
            }
        }

        public ConnectToDataBase()
        { }

        public ConnectToDataBase(string strconnect)
        { strConnect = strconnect; }

        public static SqlConnection CloseConnection()
        {
            _SqlConnection.Close();
            return _SqlConnection;
        }
    }
}
