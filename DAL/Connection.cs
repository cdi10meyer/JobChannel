using System;
using System.Collections.Generic;
using System.Configuration;
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
            try
            {
                SqlCommand objSqlCommand = new SqlCommand();
                SqlConnection objSqlConnection = new SqlConnection();
                objSqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
                objSqlCommand.Connection = objSqlConnection;
                return objSqlCommand;
            }
            catch(SqlException ex)
            {
                throw new DALException("Probléme de connexion", ex);
            }
        }
    }
}
