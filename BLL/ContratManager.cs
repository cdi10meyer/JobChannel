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
    public class ContratManager
    {
        public List<Contrat> RetrieveAllContrats()
        {
            ContratDataAccess dataAccess = new ContratDataAccess();

            List<Contrat> contrats = new List<Contrat>();

            DataTable schemaTable = dataAccess.SelectAllContrats();

            foreach (DataRow row in schemaTable.Rows)
            {
                Contrat contrat = new Contrat();
                contrat.IdContrat = Convert.ToInt32(row["ID_CONTRAT"]);
                contrat.TypeContrat = row["TYPE_CONTRAT"].ToString();

                contrats.Add(contrat);

            }
            return contrats;
        }

    }
}
