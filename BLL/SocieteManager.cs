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
                societe.NomSociete = row["NOM_SOCIETE"].ToString().ToUpper();

                societes.Add(societe);

            }
            //societes.Sort();
            return societes;
        }

        public int CreateSociete(Societe societe)
        {
            SocieteDataAccess dataAccess = new SocieteDataAccess();

            int idSociete = dataAccess.InsertSociete(societe.NomSociete);

            return idSociete;
        }

        public bool UpdateSociete(Societe societe)
        {
            SocieteDataAccess dataAccess = new SocieteDataAccess();

            int rowCount = dataAccess.UpdateSociete(societe.IdSociete,societe.NomSociete);

            return rowCount > 0;
        }

        public bool DeleteSociete(Societe societe)
        {
            SocieteDataAccess dataAccess = new SocieteDataAccess();

            int rowCount = dataAccess.DeleteSociete(societe.IdSociete);

            return rowCount > 0;
        }
    }
}
