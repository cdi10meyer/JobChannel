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
    public class SocieteManager : ConsultationManager, IGerableManager<Societe>
    {
        public SocieteManager()
        {
            Consultation = new Societe();
            Request = new RestRequest("RetrieveAllSocietes/{textItem}");
            //Id = "ID_SOCIETE";
            //Nom = "NOM_SOCIETE";
        }

        public bool Update(Societe societe)
        {
            SocieteDataAccess dataAccess = new SocieteDataAccess();
            int rowCount = dataAccess.UpdateSociete(societe.Id, societe.Nom);
            //int rowCount = dataAccess.UpdateSociete(societe.IdSociete, societe.NomSociete);
            return rowCount > 0;
        }

        public int Create(Societe societe)
        {
            SocieteDataAccess dataAccess = new SocieteDataAccess();
            int idSociete = dataAccess.InsertSociete(societe.Nom);
            //int idSociete = dataAccess.InsertSociete(societe.NomSociete);
            return idSociete;
        }

        public bool Delete(Societe societe)
        {
            SocieteDataAccess dataAccess = new SocieteDataAccess();
            int rowCount = dataAccess.DeleteSociete(societe.Id);
            //int rowCount = dataAccess.DeleteSociete(societe.IdSociete);
            return rowCount > 0;
        }

        //public List<Societe> RetrieveAll(string textItem)
        //{
        //    SocieteDataAccess dataAccess = new SocieteDataAccess();

        //    List<Societe> societes = new List<Societe>();

        //    DataTable schemaTable = dataAccess.SelectAll();

        //    foreach (DataRow row in schemaTable.Rows)
        //    {
        //        Societe societe = new Societe();
        //        societe.Id = Convert.ToInt32(row["ID_SOCIETE"]);
        //        societe.Nom = row["NOM_SOCIETE"].ToString().ToUpper();

        //        societes.Add(societe);

        //    }
        //    Societe societeItem = new Societe();
        //    societeItem.Id = 0;
        //    societeItem.Nom = textItem;
        //    //societeItem.IdSociete = 0;
        //    //societeItem.NomSociete = textItem;
        //    societes.Insert(0, societeItem);
        //    return societes;
        //}

        //public List<Societe> RetrieveAllTous()
        //{
        //    SocieteDataAccess dataAccess = new SocieteDataAccess();

        //    List<Societe> societes = new List<Societe>();

        //    DataTable schemaTable = dataAccess.SelectAllSocietes();

        //    foreach (DataRow row in schemaTable.Rows)
        //    {
        //        Societe societe = new Societe();
        //        societe.IdSociete = Convert.ToInt32(row["ID_SOCIETE"]);
        //        societe.NomSociete = row["NOM_SOCIETE"].ToString().ToUpper();

        //        societes.Add(societe);

        //    }
        //    Societe societeToutes = new Societe();
        //    societeToutes.IdSociete = 0;
        //    societeToutes.NomSociete = "Toutes";
        //    societes.Insert(0, societeToutes);
        //    return societes;
        //}

        //public List<Societe> RetrieveAllSocietes()
        //{
        //    SocieteDataAccess dataAccess = new SocieteDataAccess();

        //    List<Societe> societes = new List<Societe>();

        //    DataTable schemaTable = dataAccess.SelectAllSocietes();

        //    foreach (DataRow row in schemaTable.Rows)
        //    {
        //        Societe societe = new Societe();
        //        societe.IdSociete = Convert.ToInt32(row["ID_SOCIETE"]);
        //        societe.NomSociete = row["NOM_SOCIETE"].ToString().ToUpper();

        //        societes.Add(societe);

        //    }
        //    //societes.Sort();
        //    return societes;
        //}

        //public int CreateSociete(Societe societe)
        //{
        //    SocieteDataAccess dataAccess = new SocieteDataAccess();

        //    int idSociete = dataAccess.InsertSociete(societe.NomSociete);

        //    return idSociete;
        //}

        //public bool UpdateSociete(Societe societe)
        //{
        //    SocieteDataAccess dataAccess = new SocieteDataAccess();

        //    int rowCount = dataAccess.UpdateSociete(societe.IdSociete, societe.NomSociete);

        //    return rowCount > 0;
        //}

        //public bool DeleteSociete(Societe societe)
        //{
        //    SocieteDataAccess dataAccess = new SocieteDataAccess();

        //    int rowCount = dataAccess.DeleteSociete(societe.IdSociete);

        //    return rowCount > 0;
        //}
    }
}
