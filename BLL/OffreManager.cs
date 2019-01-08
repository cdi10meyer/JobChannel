using BO;
using DAL;
using RestSharp;
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
        #region "Connection"
        private static string URL_SERVICE = "http://user17.2isa.org/Service.svc";
        private static RestClient Client = new RestClient(URL_SERVICE);
        #endregion "Connection"

        public List<Offre> RetrieveAllOffres()
        {
            List<Offre> offres = new List<Offre>();
            RestRequest request = new RestRequest("RetrieveAllOffres", Method.GET);
            request.RequestFormat = DataFormat.Json;
            IRestResponse<List<Offre>> response = Client.Execute<List<Offre>>(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                offres = response.Data;
            }
            offres.Sort();
            return offres;
            //List<Offre> offres = new List<Offre>();

            //OffreDataAccess dataAccess = new OffreDataAccess();
            //DataTable schemaTable = dataAccess.SelectAllOffres();
            //foreach (DataRow row in schemaTable.Rows)
            //{
            //    Offre offre = new Offre();

            //    offre.IdOffre = Convert.ToInt32(row["ID_OFFRE"]);
            //    offre.DatePublication = Convert.ToDateTime(row["DATE_PUBLICATION"]);
            //    offre.Description = row["DESCRIPTION"].ToString();
            //    offre.LienAnnonce = row["LIEN_ANNONCE"].ToString();
            //    offre.MySociete.IdSociete = Convert.ToInt32(row["ID_SOCIETE"]);
            //    offre.MySociete.NomSociete = row["NOM_SOCIETE"].ToString();
            //    offre.MySelection.MyContrat.IdContrat = Convert.ToInt32(row["ID_CONTRAT"]);
            //    offre.MySelection.MyContrat.TypeContrat = row["TYPE_CONTRAT"].ToString();
            //    offre.MySelection.MyRegion.IdRegion = Convert.ToInt32(row["ID_REGION"]);
            //    offre.MySelection.MyRegion.NomRegion = row["NOM_REGION"].ToString();
            //    offre.MySelection.MyPoste.IdPoste = Convert.ToInt32(row["ID_POSTE"]);
            //    offre.MySelection.MyPoste.TypePoste = row["TYPE_POSTE"].ToString();

            //    offres.Add(offre);

            //}
            //offres.Sort();
            //return offres;
        }
        public List<Offre> RetrieveOffresBySelection(Selection selection)
        {
            string idSociete = selection.MySociete.IdSociete.ToString();
            string idRegion = selection.MyRegion.IdRegion.ToString();
            string idPoste = selection.MyPoste.IdPoste.ToString();
            string idContrat = selection.MyContrat.IdContrat.ToString();
            string nbrJour = selection.NbrJour.ToString();
            List<Offre> offres = new List<Offre>();
            RestRequest request = new RestRequest("RetrieveOffresBySelection/{idSociete}/{idRegion}/{idPoste}/{idContrat}/{nbrJour}", Method.GET);
            request.AddParameter("idSociete", idSociete, ParameterType.UrlSegment);
            request.AddParameter("idRegion", idRegion, ParameterType.UrlSegment);
            request.AddParameter("idPoste", idPoste, ParameterType.UrlSegment);
            request.AddParameter("idContrat", idContrat, ParameterType.UrlSegment);
            request.AddParameter("nbrJour", nbrJour, ParameterType.UrlSegment);
            request.RequestFormat = DataFormat.Json;
            IRestResponse<List<Offre>> response = Client.Execute<List<Offre>>(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                offres = response.Data;
            }
            offres.Sort();
            return offres;
            //OffreDataAccess dataAccess = new OffreDataAccess();

            //List<Offre> offres = new List<Offre>();
            //int idRegion = selection.MyRegion.IdRegion;
            //int idPoste = selection.MyPoste.IdPoste;
            //int idContrat = selection.MyContrat.IdContrat;
            //int nbrJour = selection.NbrJour;
            //DataTable schemaTable = dataAccess.SelectOffresBySelection(idRegion, idPoste, idContrat, nbrJour);

            //foreach (DataRow row in schemaTable.Rows)
            //{
            //    Offre offre = new Offre();

            //    offre.IdOffre = Convert.ToInt32(row["ID_OFFRE"]);
            //    offre.DatePublication = Convert.ToDateTime(row["DATE_PUBLICATION"]);
            //    offre.Description = row["DESCRIPTION"].ToString();
            //    offre.LienAnnonce = row["LIEN_ANNONCE"].ToString();
            //    offre.MySociete.IdSociete = Convert.ToInt32(row["ID_SOCIETE"]);
            //    offre.MySociete.NomSociete = row["NOM_SOCIETE"].ToString();
            //    offre.MySelection.MyContrat.IdContrat = Convert.ToInt32(row["ID_CONTRAT"]);
            //    offre.MySelection.MyContrat.TypeContrat = row["TYPE_CONTRAT"].ToString();
            //    offre.MySelection.MyRegion.IdRegion = Convert.ToInt32(row["ID_REGION"]);
            //    offre.MySelection.MyRegion.NomRegion = row["NOM_REGION"].ToString();
            //    offre.MySelection.MyPoste.IdPoste = Convert.ToInt32(row["ID_POSTE"]);
            //    offre.MySelection.MyPoste.TypePoste = row["TYPE_POSTE"].ToString();

            //    offres.Add(offre);

            //}
            //offres.Sort();
            //return offres;
        }

        public int CreateOffre(Offre offre)
        {
            OffreDataAccess dataAccess = new OffreDataAccess();

            int idSociete = dataAccess.InsertOffre(offre.MySelection.MyContrat.IdContrat, offre.MySelection.MyPoste.IdPoste, offre.MySelection.MySociete.IdSociete, offre.MySelection.MyRegion.IdRegion, offre.Description, offre.LienAnnonce);
            return idSociete;
        }

        public bool UpdateOffre(Offre offre)
        {
            OffreDataAccess dataAccess = new OffreDataAccess();

            int rowCount = dataAccess.UpdateOffre(offre.IdOffre, offre.MySelection.MyContrat.IdContrat, offre.MySelection.MyPoste.IdPoste, offre.MySelection.MySociete.IdSociete, offre.MySelection.MyRegion.IdRegion, offre.Description, offre.LienAnnonce);
            return rowCount > 0;
        }

        public bool DeleteOffre(Offre offre)
        {
            OffreDataAccess dataAccess = new OffreDataAccess();

            int rowCount = dataAccess.DeleteOffre(offre.IdOffre);

            return rowCount > 0;
        }


    }
}
