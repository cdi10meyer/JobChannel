using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Extensions;

namespace IHM
{
    public partial class frmRed : MetroForm
    {
        Offre CurrentOffre;
        public frmRed(Offre offre)
        {
            InitializeComponent();
            CurrentOffre = offre;
            labelResultat.Text = "Etes-vous certain de vouloir supprimer cette offre?";
            labelDatePublication.Text = offre.DatePublication.ToShortDateString();
            labelSociete.Text = offre.MySelection.MySociete.Nom.ToUpper();
            labelRegion.Text = offre.MySelection.MyRegion.Nom;
            labelContrat.Text = offre.MySelection.MyContrat.Nom;
            labelPoste.Text = offre.MySelection.MyPoste.Nom;
            labelDescription.Text = offre.Description;
            labelLienAnnonce.Text = offre.LienAnnonce;
        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            OffreManager offreManager = new OffreManager();
            bool deleteOffre = offreManager.Delete(CurrentOffre);
            if (deleteOffre)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}
