using BLL;
using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLLExtension
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

        public static bool Update(this SocieteManager societeManager, Societe societe)
        {
            SocieteDataAccess dataAccess = new SocieteDataAccess();
            int rowCount = dataAccess.Update(societe);
            return rowCount > 0;
        }

        public static int Create(SocieteManager societeManager, Societe societe)
        {
            SocieteDataAccess dataAccess = new SocieteDataAccess();
            int idSociete = dataAccess.Insert(societe);
            return idSociete;
        }

        public static bool Delete(SocieteManager societeManager, Societe societe)
        {
            SocieteDataAccess dataAccess = new SocieteDataAccess();
            int rowCount = dataAccess.Delete(societe);
            return rowCount > 0;
        }
    }
}
