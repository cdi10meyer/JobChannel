using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;

namespace BLL
{
    public class JourManager : IConsultableManager<Jour>
    {
        public string TextItem { get; set; }
        public JourManager(string textItem)
        {
            TextItem = textItem;
        }
        public List<Jour> RetrieveAll(Jour jour)
        {
            List<Jour> jours = new List<Jour>()
            {
                jour,
                new Jour(8,TextItem),
                new Jour(15, TextItem),
                new Jour(30, TextItem)

            };
            return jours;
        }
        public void FillingComboBox(Jour jour, BindingSource bindingSource, ComboBox comboBox)
        {
            bindingSource.DataSource = this.RetrieveAll(jour);
            comboBox.DataSource = bindingSource;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Nom";
        }
    }
}
