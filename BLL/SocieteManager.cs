using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SocieteManager
    {
        public List<Societe> RetrieveAllSocietes()
        {
            SocieteDataAccess dataAccess = new SocieteDataAccess();

            List<Societe> societes = new List<Societe>();

            DataTable schemaTable = dataAccess.SelectAllSocietes();
            
            foreach (DataRow row in schemaTable.Rows)
            {
                Societe societe = new Societe();
                societe.IdSociete = Convert.ToInt32(row["ID_SOCIETE"]);
                societe.NomSociete = row["NOM_SOCIETE"].ToString();

                societes.Add(societe);

            }
            return societes;
        }

        public int CreateSociete(string nomSociete)
        {
            SocieteDataAccess dataAccess = new SocieteDataAccess();

            int idSociete = dataAccess.InsertSociete(nomSociete);

            return idSociete;
        }

        public bool UpdateSociete(int idSociete, string nomSociete)
        {
            SocieteDataAccess dataAccess = new SocieteDataAccess();

            int rowCount = dataAccess.UpdateSociete(idSociete,nomSociete);

            return rowCount > 0;
        }

        public bool DeleteSociete(int idSociete)
        {
            SocieteDataAccess dataAccess = new SocieteDataAccess();

            int rowCount = dataAccess.DeleteSociete(idSociete);

            return rowCount > 0;
        }
    }
}
