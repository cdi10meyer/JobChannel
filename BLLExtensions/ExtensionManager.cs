using BLL;
using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extensions
{
    public static class ExtensionManager
    {
        public static bool Update(this OffreManager offreManager, Offre offre)
        {
            OffreDataAccess dataAccess = new OffreDataAccess();
            int rowCount = 0;
            try
            {
                rowCount = dataAccess.Update(offre);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erreur dans la récupérations des données, {e.Message}", "ERREUR", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
            return rowCount > 0;
        }
        public static int Create(this OffreManager offreManager, Offre offre)
        {
            OffreDataAccess dataAccess = new OffreDataAccess();
            int idSociete = 0;
            try
            {
                idSociete = dataAccess.Insert(offre);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erreur dans la récupérations des données, {e.Message}", "ERREUR", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
            return idSociete;
        }
        public static bool Delete(this OffreManager offreManager, Offre offre)
        {
            OffreDataAccess dataAccess = new OffreDataAccess();
            int rowCount = 0;
            try
            {
                rowCount = dataAccess.Delete(offre);
            }
            catch (ExceptionDataAccess e)
            {
                MessageBox.Show($"Erreur dans la récupérations des données, {e.Message}", "ERREUR", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
            return rowCount > 0;
        }
        public static void FillingComboBox(this ConsultationManager consultationManager,Consultation consultation, BindingSource bindingSource, ComboBox comboBox)
        {
            bindingSource.DataSource = consultationManager.RetrieveAll(consultation);
            comboBox.DataSource = bindingSource;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Nom";
        }

        public static void FillingComboBox(this JourManager jourManager, Jour jour, BindingSource bindingSource, ComboBox comboBox)
        {
            bindingSource.DataSource = jourManager.RetrieveAll(jour);
            comboBox.DataSource = bindingSource;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Nom";
        }
    }
}
