using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal static class Connection
    {
        internal static SqlCommand CreateConnection()
        {
            SqlCommand objSqlCommand = new SqlCommand();
            SqlConnection objSqlConnection= new SqlConnection();
            objSqlConnection.ConnectionString = Properties.Resources.ChaineConnection;
            objSqlCommand.Connection = objSqlConnection;
            return objSqlCommand;
        }
    }
}
