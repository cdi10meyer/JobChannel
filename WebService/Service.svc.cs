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
        public List<Societe> RetrieveAllSocietes(string textItem)
        {
            List<Societe> societes = new List<Societe>();
            SocieteDataAccess dataAccess = new SocieteDataAccess();

            DataTable schemaTable = dataAccess.SelectAll();

            foreach (DataRow row in schemaTable.Rows)
            {
                Societe societe = new Societe
                {
                    Id = Convert.ToInt32(row["ID_SOCIETE"]),
                    Nom = row["NOM_SOCIETE"].ToString().ToUpper()
                };

                societes.Add(societe);

            }
            Societe societeItem = new Societe
            {
                Id = 0,
                Nom = textItem
            };
            societes.Insert(0, societeItem);
            return societes;
        }

        public List<Region> RetrieveAllRegions(string textItem)
        {
            List<Region> regions = new List<Region>();
            RegionDataAccess dataAccess = new RegionDataAccess();
            
            DataTable schemaTable = dataAccess.SelectAll();
            
            foreach (DataRow row in schemaTable.Rows)
            {
                Region region = new Region
                {
                    Id = Convert.ToInt32(row["ID_REGION"]),
                    Nom = row["NOM_REGION"].ToString()
                };

                regions.Add(region);

            }
            Region regionItem = new Region
            {
                Id = 0,
                Nom = textItem
            };
            regions.Insert(0, regionItem);
            return regions;
        }
        public List<Poste> RetrieveAllPostes(string textItem)
        {
            List<Poste> postes = new List<Poste>();
            PosteDataAccess dataAccess = new PosteDataAccess();

            DataTable schemaTable = dataAccess.SelectAll();

            foreach (DataRow row in schemaTable.Rows)
            {
                Poste poste = new Poste
                {
                    Id = Convert.ToInt32(row["ID_POSTE"]),
                    Nom = row["TYPE_POSTE"].ToString()
                };

                postes.Add(poste);

            }
            Poste posteItem = new Poste
            {
                Id = 0,
                Nom = textItem
            };
            postes.Insert(0, posteItem);
            return postes;
        }

        public List<Contrat> RetrieveAllContrats(string textItem)
        {
            List<Contrat> contrats = new List<Contrat>();
            ContratDataAccess dataAccess = new ContratDataAccess();

            DataTable schemaTable = dataAccess.SelectAll();

            foreach (DataRow row in schemaTable.Rows)
            {
                Contrat contrat = new Contrat
                {
                    Id = Convert.ToInt32(row["ID_CONTRAT"]),
                    Nom = row["TYPE_CONTRAT"].ToString()
                };

                contrats.Add(contrat);

            }
            Contrat contratItem = new Contrat
            {
                Id = 0,
                Nom = textItem
            };
            contrats.Insert(0, contratItem);
            return contrats;
        }

        public List<Offre> RetrieveAllOffres()
        {
            OffreDataAccess dataAccess = new OffreDataAccess();
            DataTable schemaTable = dataAccess.SelectAll();
            List<Offre> offres = new List<Offre>();

            foreach (DataRow row in schemaTable.Rows)
            {
                Offre offre = new Offre
                {
                    Id = Convert.ToInt32(row["ID_OFFRE"]),
                    DatePublication = Convert.ToDateTime(row["DATE_PUBLICATION"]),
                    Description = row["DESCRIPTION"].ToString(),
                    LienAnnonce = row["LIEN_ANNONCE"].ToString()
                };
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
            DataTable schemaTable = dataAccess.SelectBySelection(Convert.ToInt32(idSociete), Convert.ToInt32(idRegion), Convert.ToInt32(idPoste), Convert.ToInt32(idContrat), Convert.ToInt32(nbrJour));

            foreach (DataRow row in schemaTable.Rows)
            {
                Offre offre = new Offre
                {
                    Id = Convert.ToInt32(row["ID_OFFRE"]),
                    DatePublication = Convert.ToDateTime(row["DATE_PUBLICATION"]),
                    Description = row["DESCRIPTION"].ToString(),
                    LienAnnonce = row["LIEN_ANNONCE"].ToString()
                };
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
            
        }
        

        
    }
}
