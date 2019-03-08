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
    public class ContratManager : ConsultationManager
    {
        public ContratManager()
        {
            Consultation = new Contrat();
            Request = new RestRequest("RetrieveAllContrats/{textItem}");
        }
    }
}
