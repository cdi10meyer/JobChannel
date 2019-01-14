using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [DataContract]
    public class SocieteDataAccess : ConsultationDataAccess
    {
        public SocieteDataAccess()
        {
            Procedure = "dbo.P_SELECT_AllSocietes";
        }

        //public DataTable SelectAllSocietes()
        //{
        //    DataTable SchemaTable = new DataTable();
        //    SqlCommand objSelectCommand = Connection.CreateConnection();
        //    objSelectCommand.CommandText = "dbo.P_SELECT_AllSocietes";
        //    objSelectCommand.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
        //    objDataAdapter.Fill(SchemaTable);
        //    return SchemaTable;
        //}

        public int UpdateSociete(int idSociete, string nomSociete)
        {
            SqlCommand objUpdateCommand = Connection.CreateConnection();
            objUpdateCommand.Connection.Open();
            objUpdateCommand.CommandText = "P_UPDATE_Societe";
            objUpdateCommand.CommandType = CommandType.StoredProcedure;
            objUpdateCommand.Parameters.AddWithValue("@I_IdSociete", idSociete);
            objUpdateCommand.Parameters.AddWithValue("@I_NomSociete", nomSociete);
            int rowCount = objUpdateCommand.ExecuteNonQuery();
            objUpdateCommand.Connection.Close();
            return rowCount;
        }
        public int InsertSociete(string nomSociete)
        {
            SqlCommand objInsertCommand = Connection.CreateConnection();
            objInsertCommand.CommandText = "P_INSERT_Societe";
            objInsertCommand.CommandType = CommandType.StoredProcedure;
            objInsertCommand.Parameters.AddWithValue("@I_NomSociete", nomSociete);
            SqlParameter ligne = new SqlParameter("@O_IdSociete", SqlDbType.Int);
            ligne.Direction = ParameterDirection.Output;
            objInsertCommand.Parameters.Add(ligne);
            objInsertCommand.Connection.Open();
            SqlDataReader reader = objInsertCommand.ExecuteReader();
            int idSociete = Convert.ToInt32(ligne.Value);
            objInsertCommand.Connection.Close();
            return idSociete;
        }

        public int DeleteSociete(int idSociete)
        {
            SqlCommand objDeleteCommand = Connection.CreateConnection();
            objDeleteCommand.Connection.Open();
            objDeleteCommand.CommandText = "P_DELETE_Societe";
            objDeleteCommand.CommandType = CommandType.StoredProcedure;
            objDeleteCommand.Parameters.AddWithValue("@I_IdSociete", idSociete);
            int rowCount = objDeleteCommand.ExecuteNonQuery();
            objDeleteCommand.Connection.Close();
            return rowCount;
        }
    }
}
