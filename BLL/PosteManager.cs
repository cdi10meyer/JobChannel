﻿using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PosteManager
    {
        public List<Poste> RetrieveAllPostes()
        {
            PosteDataAccess dataAccess = new PosteDataAccess();

            List<Poste> postes = new List<Poste>();

            DataTable schemaTable = dataAccess.SelectAllPostes();

            Poste posteTous = new Poste();
            posteTous.IdPoste = 0;
            posteTous.TypePoste = "TOUS";
            postes.Add(posteTous);

            foreach (DataRow row in schemaTable.Rows)
            {
                Poste poste = new Poste();
                poste.IdPoste = Convert.ToInt32(row["ID_POSTE"]);
                poste.TypePoste = row["TYPE_POSTE"].ToString();

                postes.Add(poste);

            }
            return postes;
        }


    }
}
