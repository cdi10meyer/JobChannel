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
    public class ContratManager : ConsultationManager
    {
        public ContratManager()
        {
            Id = "ID_CONTRAT";
            Nom = "TYPE_CONTRAT";
        }

        //public List<Contrat> RetrieveAll(string textItem)
        //{
        //    ContratDataAccess dataAccess = new ContratDataAccess();

        //    List<Contrat> contrats = new List<Contrat>();

        //    DataTable schemaTable = dataAccess.SelectAll();


        //    foreach (DataRow row in schemaTable.Rows)
        //    {
        //        Contrat contrat = new Contrat();
        //        contrat.Id = Convert.ToInt32(row["ID_CONTRAT"]);
        //        contrat.Nom = row["TYPE_CONTRAT"].ToString();

        //        contrats.Add(contrat);

        //    }
        //    Contrat contratItem = new Contrat();
        //    contratItem.Id = 0;
        //    contratItem.Nom = textItem;
        //    contrats.Insert(0, contratItem);
        //    return contrats;
        //}

        //public List<Contrat> RetrieveAllTous()
        //{
        //    ContratDataAccess dataAccess = new ContratDataAccess();

        //    List<Contrat> contrats = new List<Contrat>();

        //    DataTable schemaTable = dataAccess.SelectAllContrats();

        //    foreach (DataRow row in schemaTable.Rows)
        //    {
        //        Contrat contrat = new Contrat();
        //        contrat.IdContrat = Convert.ToInt32(row["ID_CONTRAT"]);
        //        contrat.TypeContrat = row["TYPE_CONTRAT"].ToString();

        //        contrats.Add(contrat);
        //    }
        //    //contrats.Sort();
        //    Contrat contratTous = new Contrat();
        //    contratTous.IdContrat = 0;
        //    contratTous.TypeContrat = "Tous";
        //    contrats.Insert(0, contratTous);
        //    //Contrat contratAutre = new Contrat();
        //    //contratAutre= contrats.Find(a => a.TypeContrat == "..Autre");
        //    //contrats.Remove(contratAutre);
        //    //contrats.Add(contratAutre);

        //    return contrats;
        //}
        //public List<Contrat> RetrieveAllContratsTous()
        //{
        //    ContratDataAccess dataAccess = new ContratDataAccess();

        //    List<Contrat> contrats = new List<Contrat>();

        //    DataTable schemaTable = dataAccess.SelectAllContrats();

        //    foreach (DataRow row in schemaTable.Rows)
        //    {
        //        Contrat contrat = new Contrat();
        //        contrat.IdContrat = Convert.ToInt32(row["ID_CONTRAT"]);
        //        contrat.TypeContrat = row["TYPE_CONTRAT"].ToString();

        //        contrats.Add(contrat);
        //    }
        //    //contrats.Sort();
        //    Contrat contratTous = new Contrat();
        //    contratTous.IdContrat = 0;
        //    contratTous.TypeContrat = "Tous";
        //    contrats.Insert(0,contratTous);
        //    return contrats;
        //}
        //public List<Contrat> RetrieveAllContrats()
        //{
        //    ContratDataAccess dataAccess = new ContratDataAccess();

        //    List<Contrat> contrats = new List<Contrat>();

        //    DataTable schemaTable = dataAccess.SelectAllContrats();


        //    foreach (DataRow row in schemaTable.Rows)
        //    {
        //        Contrat contrat = new Contrat();
        //        contrat.IdContrat = Convert.ToInt32(row["ID_CONTRAT"]);
        //        contrat.TypeContrat = row["TYPE_CONTRAT"].ToString();

        //        contrats.Add(contrat);

        //    }
        //    //contrats.Sort();
        //    return contrats;
        //}

    }
}
