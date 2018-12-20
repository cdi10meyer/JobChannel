using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BLL;
using BO;
using DAL;

namespace WebService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service : IService
    {
        public List<Offre> GetAllOffres()
        {
            OffreDataAccess dataAccess = new OffreDataAccess();
            DataTable schemaTable = dataAccess.SelectAllOffres();
            List<Offre> offres = new List<Offre>();

            foreach (DataRow row in schemaTable.Rows)
            {
                Offre offre = new Offre();

                offre.IdOffre = Convert.ToInt32(row["ID_OFFRE"]);
                offre.DatePublication = Convert.ToDateTime(row["DATE_PUBLICATION"]);
                offre.Description = row["DESCRIPTION"].ToString();
                offre.LienAnnonce = row["LIEN_ANNONCE"].ToString();
                offre.MySociete.IdSociete = Convert.ToInt32(row["ID_SOCIETE"]);
                offre.MySociete.NomSociete = row["NOM_SOCIETE"].ToString();
                offre.MySelection.MyContrat.IdContrat = Convert.ToInt32(row["ID_CONTRAT"]);
                offre.MySelection.MyContrat.TypeContrat = row["TYPE_CONTRAT"].ToString();
                offre.MySelection.MyRegion.IdRegion = Convert.ToInt32(row["ID_REGION"]);
                offre.MySelection.MyRegion.NomRegion = row["NOM_REGION"].ToString();
                offre.MySelection.MyPoste.IdPoste = Convert.ToInt32(row["ID_POSTE"]);
                offre.MySelection.MyPoste.TypePoste = row["TYPE_POSTE"].ToString();

                offres.Add(offre);

            }
            return offres;
            
        }
        
    }
}
