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

        //#region "Offre"

        [OperationContract]
        [WebGet(UriTemplate = "Offres", ResponseFormat = WebMessageFormat.Json)]
        List<Offre> GetAllOffres();

        //[OperationContract]
        //[WebInvoke(UriTemplate = "GetOffresBySelection", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        //List<Offre> GetOffresBySelection(Selection selection);

        //[OperationContract]
        //int SetOffre(Offre offre);

        //[OperationContract]
        //bool ModifyOffre(Offre offre);

        //[OperationContract]
        //bool EraseOffre(Offre offre);

        //#endregion "Offre"

        //#region "Selection"
        //[OperationContract]
        //List<Region> GetAllRegions();

        //[OperationContract]
        //List<Contrat> GetAllContrats();

        //[OperationContract]
        //List<Poste> GetAllPostes();
        //#endregion "Selection"

        //#region "Societe"
        //[OperationContract]
        //List<Societe> GetAllSocietes();

        //[OperationContract]
        //int SetSociete(string nomSociete);

        //[OperationContract]
        //bool ModifySociete(Societe societe);

        //[OperationContract]
        //bool EraseSociete(Societe societe);
        //#endregion "Societe"
    }
}
