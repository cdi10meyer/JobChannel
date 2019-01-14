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
        public List<Offre> RetrieveAllOffres()
        {
            OffreDataAccess dataAccess = new OffreDataAccess();
            DataTable schemaTable = dataAccess.SelectAllOffres();
            List<Offre> offres = new List<Offre>();

            foreach (DataRow row in schemaTable.Rows)
            {
                Offre offre = new Offre();

                offre.Id = Convert.ToInt32(row["ID_OFFRE"]);
                offre.DatePublication = Convert.ToDateTime(row["DATE_PUBLICATION"]);
                offre.Description = row["DESCRIPTION"].ToString();
                offre.LienAnnonce = row["LIEN_ANNONCE"].ToString();
                offre.MySelection.MySociete.Id = Convert.ToInt32(row["ID_SOCIETE"]);
                offre.MySelection.MySociete.Nom = row["NOM_SOCIETE"].ToString();
                offre.MySelection.MyContrat.Id = Convert.ToInt32(row["ID_CONTRAT"]);
                offre.MySelection.MyContrat.Nom = row["TYPE_CONTRAT"].ToString();
                offre.MySelection.MyRegion.Id = Convert.ToInt32(row["ID_REGION"]);
                offre.MySelection.MyRegion.Nom = row["NOM_REGION"].ToString();
                offre.MySelection.MyPoste.Id = Convert.ToInt32(row["ID_POSTE"]);
                offre.MySelection.MyPoste.Nom = row["TYPE_POSTE"].ToString();

                offres.Add(offre);

            }
            return offres;
            
        }

        public List<Offre> RetrieveOffresBySelection(string idSociete,string idRegion, string idPoste, string idContrat, string nbrJour)
        {
            OffreDataAccess dataAccess = new OffreDataAccess();

            List<Offre> offres = new List<Offre>();
            //int idSociete = selection.MySociete.Id;
            //int idRegion = selection.MyRegion.Id;
            //int idPoste = selection.MyPoste.Id;
            //int idContrat = selection.MyContrat.Id;
            //int nbrJour = selection.NbrJour;
            DataTable schemaTable = dataAccess.SelectOffresBySelection(Convert.ToInt32(idSociete), Convert.ToInt32(idRegion), Convert.ToInt32(idPoste), Convert.ToInt32(idContrat), Convert.ToInt32(nbrJour));

            foreach (DataRow row in schemaTable.Rows)
            {
                Offre offre = new Offre();

                offre.Id = Convert.ToInt32(row["ID_OFFRE"]);
                offre.DatePublication = Convert.ToDateTime(row["DATE_PUBLICATION"]);
                offre.Description = row["DESCRIPTION"].ToString();
                offre.LienAnnonce = row["LIEN_ANNONCE"].ToString();
                offre.MySelection.MySociete.Id = Convert.ToInt32(row["ID_SOCIETE"]);
                offre.MySelection.MySociete.Nom = row["NOM_SOCIETE"].ToString();
                offre.MySelection.MyContrat.Id = Convert.ToInt32(row["ID_CONTRAT"]);
                offre.MySelection.MyContrat.Nom = row["TYPE_CONTRAT"].ToString();
                offre.MySelection.MyRegion.Id = Convert.ToInt32(row["ID_REGION"]);
                offre.MySelection.MyRegion.Nom = row["NOM_REGION"].ToString();
                offre.MySelection.MyPoste.Id = Convert.ToInt32(row["ID_POSTE"]);
                offre.MySelection.MyPoste.Nom = row["TYPE_POSTE"].ToString();

                offres.Add(offre);

            }
            offres.Sort();
            return offres;
            //OffreDataAccess dataAccess = new OffreDataAccess();
            //DataTable schemaTable = dataAccess.SelectOffresBySelection(Convert.ToInt32(idSociete),Convert.ToInt32(idRegion), Convert.ToInt32(idPoste), Convert.ToInt32(idContrat), Convert.ToInt32(nbrJour));
            //List<Offre> offres = new List<Offre>();

            //foreach (DataRow row in schemaTable.Rows)
            //{
            //    Offre offre = new Offre();

            //    offre.Id = Convert.ToInt32(row["ID_OFFRE"]);
            //    offre.DatePublication = Convert.ToDateTime(row["DATE_PUBLICATION"]);
            //    offre.Description = row["DESCRIPTION"].ToString();
            //    offre.LienAnnonce = row["LIEN_ANNONCE"].ToString();
            //    offre.MySelection.MySociete.Id = Convert.ToInt32(row["ID_SOCIETE"]);
            //    offre.MySelection.MySociete.Nom = row["NOM_SOCIETE"].ToString();
            //    offre.MySelection.MyContrat.Id = Convert.ToInt32(row["ID_CONTRAT"]);
            //    offre.MySelection.MyContrat.Nom = row["TYPE_CONTRAT"].ToString();
            //    offre.MySelection.MyRegion.Id = Convert.ToInt32(row["ID_REGION"]);
            //    offre.MySelection.MyRegion.Nom = row["NOM_REGION"].ToString();
            //    offre.MySelection.MyPoste.Id = Convert.ToInt32(row["ID_POSTE"]);
            //    offre.MySelection.MyPoste.Nom = row["TYPE_POSTE"].ToString();

            //    offres.Add(offre);

            //}

            //return offres;
        }
    }
}
