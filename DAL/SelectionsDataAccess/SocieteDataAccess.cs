using BO;
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
    public class SocieteDataAccess : ConsultationDataAccess, IGerableDataAccess<Societe>
    {
        
        public SocieteDataAccess()
        {
            Procedure = "dbo.P_SELECT_AllSocietes";
        }

        public int Update(Societe societe)
        {
            SqlCommand objUpdateCommand = ObjSqlCommand;
            objUpdateCommand.Connection.Open();
            objUpdateCommand.CommandText = "P_UPDATE_Societe";
            objUpdateCommand.CommandType = CommandType.StoredProcedure;
            objUpdateCommand.Parameters.AddWithValue("@I_IdSociete", societe.Id);
            objUpdateCommand.Parameters.AddWithValue("@I_NomSociete", societe.Nom);
            int rowCount = objUpdateCommand.ExecuteNonQuery();
            objUpdateCommand.Connection.Close();
            return rowCount;
        }

        public int Insert(Societe societe)
        {
            SqlCommand objInsertCommand = ObjSqlCommand;
            objInsertCommand.CommandText = "P_INSERT_Societe";
            objInsertCommand.CommandType = CommandType.StoredProcedure;
            objInsertCommand.Parameters.AddWithValue("@I_NomSociete", societe.Nom);
            SqlParameter ligne = new SqlParameter("@O_IdSociete", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            objInsertCommand.Parameters.Add(ligne);
            objInsertCommand.Connection.Open();
            SqlDataReader reader = objInsertCommand.ExecuteReader();
            int idSociete = Convert.ToInt32(ligne.Value);
            objInsertCommand.Connection.Close();
            return idSociete;
        }

        public int Delete(Societe societe)
        {
            SqlCommand objDeleteCommand = ObjSqlCommand;
            objDeleteCommand.Connection.Open();
            objDeleteCommand.CommandText = "P_DELETE_Societe";
            objDeleteCommand.CommandType = CommandType.StoredProcedure;
            objDeleteCommand.Parameters.AddWithValue("@I_IdSociete", societe.Id);
            int rowCount = objDeleteCommand.ExecuteNonQuery();
            objDeleteCommand.Connection.Close();
            return rowCount;
        }
        //public int Update(int idSociete, string nomSociete)
        //{
        //    SqlCommand objUpdateCommand = ObjSqlCommand;
        //    objUpdateCommand.Connection.Open();
        //    objUpdateCommand.CommandText = "P_UPDATE_Societe";
        //    objUpdateCommand.CommandType = CommandType.StoredProcedure;
        //    objUpdateCommand.Parameters.AddWithValue("@I_IdSociete", idSociete);
        //    objUpdateCommand.Parameters.AddWithValue("@I_NomSociete", nomSociete);
        //    int rowCount = objUpdateCommand.ExecuteNonQuery();
        //    objUpdateCommand.Connection.Close();
        //    return rowCount;
        //}
        //public int Insert(string nomSociete)
        //{
        //    SqlCommand objInsertCommand = ObjSqlCommand;
        //    objInsertCommand.CommandText = "P_INSERT_Societe";
        //    objInsertCommand.CommandType = CommandType.StoredProcedure;
        //    objInsertCommand.Parameters.AddWithValue("@I_NomSociete", nomSociete);
        //    SqlParameter ligne = new SqlParameter("@O_IdSociete", SqlDbType.Int)
        //    {
        //        Direction = ParameterDirection.Output
        //    };
        //    objInsertCommand.Parameters.Add(ligne);
        //    objInsertCommand.Connection.Open();
        //    SqlDataReader reader = objInsertCommand.ExecuteReader();
        //    int idSociete = Convert.ToInt32(ligne.Value);
        //    objInsertCommand.Connection.Close();
        //    return idSociete;
        //}

        //public int Delete(int idSociete)
        //{
        //    SqlCommand objDeleteCommand = ObjSqlCommand;
        //    objDeleteCommand.Connection.Open();
        //    objDeleteCommand.CommandText = "P_DELETE_Societe";
        //    objDeleteCommand.CommandType = CommandType.StoredProcedure;
        //    objDeleteCommand.Parameters.AddWithValue("@I_IdSociete", idSociete);
        //    int rowCount = objDeleteCommand.ExecuteNonQuery();
        //    objDeleteCommand.Connection.Close();
        //    return rowCount;
        //}
    }
}
