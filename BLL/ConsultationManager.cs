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
    public abstract class ConsultationManager : IConsultable<Consultation>
    {
        public string Id { get; set; }
        public string Nom { get; set; }

        public List<Consultation> RetrieveAll(string textItem, Consultation consultation)
        {
            ConsultationDataAccess dataAccess;
            List<Consultation> consultations;
            Consultation consultationItem;
            if (consultation is Region)
            {
                dataAccess = new RegionDataAccess();
                consultationItem = new Region();

            }
            else if (consultation is Societe)
            {
                dataAccess = new SocieteDataAccess();
                consultationItem = new Societe();
            }
            else if (consultation is Poste)
            {
                dataAccess = new PosteDataAccess();
                consultationItem = new Poste();
            }
            else
            {
                dataAccess = new ContratDataAccess();
                consultationItem = new Contrat();
            }

            consultations = new List<Consultation>();
            DataTable schemaTable = dataAccess.SelectAll();


            foreach (DataRow row in schemaTable.Rows)
            {
                consultation = new Consultation();
                consultation.Id = Convert.ToInt32(row[Id]);
                consultation.Nom = row[Nom].ToString();

                consultations.Add(consultation);

            }
            //Consultation consultationItem = new Consultation();
            consultationItem.Id = 0;
            consultationItem.Nom = textItem;
            consultations.Insert(0, consultationItem);
            return consultations;
        }
        
    }
}
