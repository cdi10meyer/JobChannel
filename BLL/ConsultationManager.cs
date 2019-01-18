using BO;
using DAL;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public abstract class ConsultationManager : IConsultableManager<Consultation>
    {
        private static string URL_SERVICE = "http://user17.2isa.org/Service.svc";
        private static RestClient Client = new RestClient(URL_SERVICE);

        internal Consultation Consultation { get; set; }
        internal RestRequest Request { get; set; }

        public List<Consultation> RetrieveAll(Consultation consultation)
        {
            List<Consultation> consultations = new List<Consultation>();
            Request.AddParameter("textItem", consultation.Nom, ParameterType.UrlSegment);
            Request.RequestFormat = DataFormat.Json;
            IRestResponse<List<Consultation>> response = Client.Execute<List<Consultation>>(Request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                consultations = response.Data;
            }
            return consultations;
        }
        public void FillingComboBox(Consultation consultation, BindingSource bindingSource, ComboBox comboBox)
        {
            bindingSource.DataSource = this.RetrieveAll(consultation);
            comboBox.DataSource = bindingSource;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Nom";
        }

    }
}
