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
    public class OffreManager 
    {
        public List<Offre> RetrieveAllOffres()
        {
            OffreDataAccess dataAccess = new OffreDataAccess();

            List<Offre> offres = new List<Offre>();

            DataTable schemaTable = dataAccess.SelectAllOffres();

            foreach (DataRow row in schemaTable.Rows)
            {
                Offre offre = new Offre();

                offre.IdOffre= Convert.ToInt32(row["ID_OFFRE"]);
                offre.DatePublication = Convert.ToDateTime(row["DATE_PUBLICATION"]);
                offre.Description = row["DESCRIPTION"].ToString();
                offre.LienAnnonce = row["LIEN_ANNONCE"].ToString();
                offre.MySociete.IdSociete = Convert.ToInt32(row["ID_SOCIETE"]);
                offre.MySociete.NomSociete = row["NOM_SOCIETE"].ToString();
                offre.MySelection.MyContrat.IdContrat= Convert.ToInt32(row["ID_CONTRAT"]);
                offre.MySelection.MyContrat.TypeContrat = row["TYPE_CONTRAT"].ToString();
                offre.MySelection.MyRegion.IdRegion = Convert.ToInt32(row["ID_REGION"]);
                offre.MySelection.MyRegion.NomRegion= row["NOM_REGION"].ToString();
                offre.MySelection.MyPoste.IdPoste = Convert.ToInt32(row["ID_POSTE"]);
                offre.MySelection.MyPoste.TypePoste= row["TYPE_POSTE"].ToString();

                offres.Add(offre);

            }
            return offres;
        }


    }
}
