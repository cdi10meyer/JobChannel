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
    public class PosteManager : ConsultationManager
    {
        public PosteManager()
        {
            Id = "ID_POSTE";
            Nom = "TYPE_POSTE";
        }

        //public List<Poste> RetrieveAll(string textItem, ConsultationDataAccess dataAccess, List<Consultation> consultations, Consultation consultation)
        //{
        //    //PosteDataAccess dataAccess = new PosteDataAccess();

        //    List<Poste> postes = new List<Poste>();

        //    DataTable schemaTable = dataAccess.SelectAll();


        //    foreach (DataRow row in schemaTable.Rows)
        //    {
        //        Poste poste = new Poste();
        //        poste.Id = Convert.ToInt32(row["ID_POSTE"]);
        //        poste.Nom = row["TYPE_POSTE"].ToString();

        //        postes.Add(poste);

        //    }
        //    Poste posteItem = new Poste();
        //    posteItem.Id = 0;
        //    posteItem.Nom = textItem;
        //    postes.Insert(0, posteItem);
        //    //Poste posteAutre = new Poste();
        //    //posteAutre = postes.Find(a => a.TypePoste == "..Autre");
        //    //postes.Remove(posteAutre);
        //    //postes.Add(posteAutre);
        //    return postes;
        //}

        //public List<Poste> RetrieveAllTous()
        //{
        //    PosteDataAccess dataAccess = new PosteDataAccess();

        //    List<Poste> postes = new List<Poste>();

        //    DataTable schemaTable = dataAccess.SelectAllPostes();

        //    foreach (DataRow row in schemaTable.Rows)
        //    {
        //        Poste poste = new Poste();
        //        poste.IdPoste = Convert.ToInt32(row["ID_POSTE"]);
        //        poste.TypePoste = row["TYPE_POSTE"].ToString();

        //        postes.Add(poste);

        //    }
        //    Poste posteTous = new Poste();
        //    posteTous.IdPoste = 0;
        //    posteTous.TypePoste = "Tous";
        //    postes.Insert(0, posteTous);
        //    //Poste posteAutre = new Poste();
        //    //posteAutre = postes.Find(a => a.TypePoste == "..Autre");
        //    //postes.Remove(posteAutre);
        //    //postes.Add(posteAutre);
        //    return postes;
        //}
        //public List<Poste> RetrieveAllPostesTous()
        //{
        //    PosteDataAccess dataAccess = new PosteDataAccess();

        //    List<Poste> postes = new List<Poste>();

        //    DataTable schemaTable = dataAccess.SelectAllPostes();

        //    foreach (DataRow row in schemaTable.Rows)
        //    {
        //        Poste poste = new Poste();
        //        poste.IdPoste = Convert.ToInt32(row["ID_POSTE"]);
        //        poste.TypePoste = row["TYPE_POSTE"].ToString();

        //        postes.Add(poste);

        //    }
        //    //postes.Sort();
        //    Poste posteTous = new Poste();
        //    posteTous.IdPoste = 0;
        //    posteTous.TypePoste = "Tous";
        //    postes.Insert(0, posteTous);
        //    return postes;
        //}

        //public List<Poste> RetrieveAllPostes()
        //{
        //    PosteDataAccess dataAccess = new PosteDataAccess();

        //    List<Poste> postes = new List<Poste>();

        //    DataTable schemaTable = dataAccess.SelectAllPostes();


        //    foreach (DataRow row in schemaTable.Rows)
        //    {
        //        Poste poste = new Poste();
        //        poste.IdPoste = Convert.ToInt32(row["ID_POSTE"]);
        //        poste.TypePoste = row["TYPE_POSTE"].ToString();

        //        postes.Add(poste);

        //    }
        //    Poste posteAutre = new Poste();
        //    posteAutre = postes.Find(a => a.TypePoste == "..Autre");
        //    postes.Remove(posteAutre);
        //    postes.Add(posteAutre);
        //    //postes.Sort();
        //    return postes;
        //}

    }
}
