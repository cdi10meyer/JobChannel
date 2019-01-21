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
    public class OffreDataAccess : ConsultationDataAccess, IGerableDataAccess<Offre>, ISelectionableDataAccess
    {
        
        public OffreDataAccess()
        {
            Procedure = "dbo.P_SELECT_AllOffres";
        }

        public DataTable SelectBySelection(int idSociete, int idRegion, int idPoste, int idContrat, int nbrJour)
        {
            SchemaTable = new DataTable();
            SqlCommand objSelectCommand = ObjSqlCommand;
            objSelectCommand.CommandText = "dbo.P_SELECT_OffresBySelection";
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            objSelectCommand.Parameters.AddWithValue("@I_IdSociete", idSociete);
            objSelectCommand.Parameters.AddWithValue("@I_IdRegion", idRegion);
            objSelectCommand.Parameters.AddWithValue("@I_IdPoste", idPoste);
            objSelectCommand.Parameters.AddWithValue("@I_IdContrat", idContrat);
            objSelectCommand.Parameters.AddWithValue("@I_NbrJour", nbrJour);
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
            objDataAdapter.Fill(SchemaTable);
            return SchemaTable;
        }
        public int Update(Offre offre)
        {
            SqlCommand objUpdateCommand = ObjSqlCommand;
            objUpdateCommand.Connection.Open();
            objUpdateCommand.CommandText = "P_UPDATE_Offre";
            objUpdateCommand.CommandType = CommandType.StoredProcedure;
            objUpdateCommand.Parameters.AddWithValue("@I_IdOffre", offre.Id);
            objUpdateCommand.Parameters.AddWithValue("@I_IdContrat", offre.MySelection.MyContrat.Id);
            objUpdateCommand.Parameters.AddWithValue("@I_IdPoste", offre.MySelection.MyPoste.Id);
            objUpdateCommand.Parameters.AddWithValue("@I_IdSociete", offre.MySelection.MySociete.Id);
            objUpdateCommand.Parameters.AddWithValue("@I_IdRegion", offre.MySelection.MyRegion.Id);
            objUpdateCommand.Parameters.AddWithValue("@I_Description", offre.Description);
            objUpdateCommand.Parameters.AddWithValue("@I_LienAnnonce", offre.LienAnnonce);
            int rowCount = objUpdateCommand.ExecuteNonQuery();
            objUpdateCommand.Connection.Close();
            return rowCount;
        }

        public int Insert(Offre offre)
        {
            SqlCommand objInsertCommand = ObjSqlCommand;
            objInsertCommand.CommandText = "P_INSERT_Offre";
            objInsertCommand.CommandType = CommandType.StoredProcedure;
            objInsertCommand.Parameters.AddWithValue("@I_IdContrat", offre.MySelection.MyContrat.Id);
            objInsertCommand.Parameters.AddWithValue("@I_IdPoste", offre.MySelection.MyPoste.Id);
            objInsertCommand.Parameters.AddWithValue("@I_IdSociete", offre.MySelection.MySociete.Id);
            objInsertCommand.Parameters.AddWithValue("@I_IdRegion", offre.MySelection.MyRegion.Id);
            objInsertCommand.Parameters.AddWithValue("@I_Description", offre.Description);
            objInsertCommand.Parameters.AddWithValue("@I_LienAnnonce", offre.LienAnnonce);
            SqlParameter ligne = new SqlParameter("@O_IdOffre", SqlDbType.Int);
            ligne.Direction = ParameterDirection.Output;
            objInsertCommand.Parameters.Add(ligne);
            objInsertCommand.Connection.Open();
            SqlDataReader reader = objInsertCommand.ExecuteReader();
            int idOffre = Convert.ToInt32(ligne.Value);
            objInsertCommand.Connection.Close();
            return idOffre;
        }

        public int Delete(Offre offre)
        {
            SqlCommand objDeleteCommand = ObjSqlCommand;
            objDeleteCommand.Connection.Open();
            objDeleteCommand.CommandText = "P_DELETE_Offre";
            objDeleteCommand.CommandType = CommandType.StoredProcedure;
            objDeleteCommand.Parameters.AddWithValue("@I_IdOffre", offre.Id);
            int rowCount = objDeleteCommand.ExecuteNonQuery();
            objDeleteCommand.Connection.Close();
            return rowCount;
        }
    }
}
