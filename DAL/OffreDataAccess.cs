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
    public class OffreDataAccess
    {
        [DataMember]
        public DataTable SchemaTable { get; set; }
        public DataTable SelectAllOffres()
        {
            SchemaTable = new DataTable();
            SqlCommand objSelectCommand = Connection.CreateConnection();
            objSelectCommand.CommandText = "dbo.P_SELECT_AllOffres";
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
            objDataAdapter.Fill(SchemaTable);
            return SchemaTable;
        }

        public DataTable SelectOffresBySelection(int idRegion, int idPoste, int idContrat, int nbrJour)
        {
            SchemaTable = new DataTable();
            SqlCommand objSelectCommand = Connection.CreateConnection();
            objSelectCommand.CommandText = "dbo.P_SELECT_OffresBySelection";
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            objSelectCommand.Parameters.AddWithValue("@I_IdRegion", idRegion);
            objSelectCommand.Parameters.AddWithValue("@I_IdPoste", idPoste);
            objSelectCommand.Parameters.AddWithValue("@I_IdContrat", idContrat);
            objSelectCommand.Parameters.AddWithValue("@I_NbrJour", nbrJour);
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
            objDataAdapter.Fill(SchemaTable);
            return SchemaTable;
        }

        public int UpdateOffre(int idOffre, int IdContrat, int idPoste, int idSociete, int idRegion, string description, string lienAnnonce)
        {
            SqlCommand objUpdateCommand = Connection.CreateConnection();
            objUpdateCommand.Connection.Open();
            objUpdateCommand.CommandText = "P_UPDATE_Offre";
            objUpdateCommand.CommandType = CommandType.StoredProcedure;
            objUpdateCommand.Parameters.AddWithValue("@I_IdOffre", idOffre);
            objUpdateCommand.Parameters.AddWithValue("@I_IdContrat", IdContrat);
            objUpdateCommand.Parameters.AddWithValue("@I_IdPoste", idPoste);
            objUpdateCommand.Parameters.AddWithValue("@I_IdSociete", idSociete);
            objUpdateCommand.Parameters.AddWithValue("@I_IdRegion", idRegion);
            objUpdateCommand.Parameters.AddWithValue("@I_Description", description);
            objUpdateCommand.Parameters.AddWithValue("@I_LienAnnonce", lienAnnonce);
            int rowCount = objUpdateCommand.ExecuteNonQuery();
            objUpdateCommand.Connection.Close();
            return rowCount;
        }
        public int InsertOffre(int IdContrat, int idPoste, int idSociete, int idRegion, string description, string lienAnnonce)
        {
            SqlCommand objInsertCommand = Connection.CreateConnection();
            objInsertCommand.CommandText = "P_INSERT_Offre";
            objInsertCommand.CommandType = CommandType.StoredProcedure;
            objInsertCommand.Parameters.AddWithValue("@I_IdContrat", IdContrat);
            objInsertCommand.Parameters.AddWithValue("@I_IdPoste", idPoste);
            objInsertCommand.Parameters.AddWithValue("@I_IdSociete", idSociete);
            objInsertCommand.Parameters.AddWithValue("@I_IdRegion", idRegion);
            objInsertCommand.Parameters.AddWithValue("@I_Description", description);
            objInsertCommand.Parameters.AddWithValue("@I_LienAnnonce", lienAnnonce);
            SqlParameter ligne = new SqlParameter("@O_IdOffre", SqlDbType.Int);
            ligne.Direction = ParameterDirection.Output;
            objInsertCommand.Parameters.Add(ligne);
            objInsertCommand.Connection.Open();
            SqlDataReader reader = objInsertCommand.ExecuteReader();
            int idOffre = Convert.ToInt32(ligne.Value);
            objInsertCommand.Connection.Close();
            return idOffre;
        }

        public int DeleteOffre(int idOffre)
        {
            SqlCommand objDeleteCommand = Connection.CreateConnection();
            objDeleteCommand.Connection.Open();
            objDeleteCommand.CommandText = "P_DELETE_Offre";
            objDeleteCommand.CommandType = CommandType.StoredProcedure;
            objDeleteCommand.Parameters.AddWithValue("@I_IdOffre", idOffre);
            int rowCount = objDeleteCommand.ExecuteNonQuery();
            objDeleteCommand.Connection.Close();
            return rowCount;
        }
    }
}
