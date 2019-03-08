using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ExtensionDataAccess
    {
        /// <summary>
        /// Méthode d'extension de la classe SqlCommand permettant de créer une connexion
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <returns>SqlCommand</returns>
        public static SqlCommand CreateConnection(this SqlCommand sqlCommand)
        {
            try
            {
                SqlCommand objSqlCommand = new SqlCommand();
                SqlConnection objSqlConnection = new SqlConnection();
                objSqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
                objSqlCommand.Connection = objSqlConnection;
                return objSqlCommand;
            }
            catch (SqlException ex)
            {
                throw new ExceptionDataAccess("Probléme de connexion", ex);
            }
        }
    }
}
