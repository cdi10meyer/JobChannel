using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    [ServiceContract]
    public interface IService
    {

        #region "Listes Offres"

        [OperationContract]
        [WebGet(UriTemplate = "RetrieveAllOffres", ResponseFormat = WebMessageFormat.Json)]
        List<Offre> RetrieveAllOffres();

        [OperationContract]
        [WebGet(UriTemplate = "RetrieveOffresBySelection/{idSociete}/{idRegion}/{idPoste}/{idContrat}/{nbrJour}", ResponseFormat = WebMessageFormat.Json)]
        List<Offre> RetrieveOffresBySelection(string idSociete, string idRegion, string idPoste, string idContrat, string nbrJour);

        //[OperationContract]
        //[WebInvoke(UriTemplate = "GetOffresBySelection", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        //List<Offre> GetOffresBySelection(Selection selection);

        //[OperationContract]
        //int SetOffre(Offre offre);

        //[OperationContract]
        //bool ModifyOffre(Offre offre);

        //[OperationContract]
        //bool EraseOffre(Offre offre);

        #endregion "Listes Offres"

        #region "Listes Consultations"
        [OperationContract]
        [WebGet(UriTemplate = "RetrieveAllSocietes/{textItem}", ResponseFormat = WebMessageFormat.Json)]
        List<Societe> RetrieveAllSocietes(string textItem);

        [OperationContract]
        [WebGet(UriTemplate = "RetrieveAllRegions/{textItem}", ResponseFormat = WebMessageFormat.Json)]
        List<Region> RetrieveAllRegions(string textItem);

        [OperationContract]
        [WebGet(UriTemplate = "RetrieveAllPostes/{textItem}", ResponseFormat = WebMessageFormat.Json)]
        List<Poste> RetrieveAllPostes(string textItem);

        [OperationContract]
        [WebGet(UriTemplate = "RetrieveAllContrats/{textItem}", ResponseFormat = WebMessageFormat.Json)]
        List<Contrat> RetrieveAllContrats(string textItem);

        #endregion "Listes Consultations"

    }

}
