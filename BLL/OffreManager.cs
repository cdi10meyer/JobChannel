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
    public class OffreManager :  IConsultableManager<Offre>, ISelectionableManager<Offre>, IGerableManager<Offre>
    {
        #region "Connection"
        private static string URL_SERVICE = "http://user17.2isa.org/Service.svc";
        private static RestClient Client = new RestClient(URL_SERVICE);
        #endregion "Connection"

        public bool Update(Offre offre)
        {
            OffreDataAccess dataAccess = new OffreDataAccess();
            int rowCount = dataAccess.Update(offre);
            return rowCount > 0;
        }

        public int Create(Offre offre)
        {
            OffreDataAccess dataAccess = new OffreDataAccess();
            int idSociete = dataAccess.Insert(offre);
            return idSociete;
        }

        public bool Delete(Offre offre)
        {
            OffreDataAccess dataAccess = new OffreDataAccess();

            int rowCount = dataAccess.Delete(offre);

            return rowCount > 0;
        }

        public List<Offre> RetrieveAll(Offre offre)
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
        }
        public List<Offre> RetrieveAll()
        {
            return RetrieveAll(null);
        }

        public List<Offre> RetrieveBySelection(Selection selection)
        {
            string idSociete = selection.MySociete.Id.ToString();
            string idRegion = selection.MyRegion.Id.ToString();
            string idPoste = selection.MyPoste.Id.ToString();
            string idContrat = selection.MyContrat.Id.ToString();
            string nbrJour = selection.NbrJour.Id.ToString();
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
        }
    }
}
