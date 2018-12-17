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
            labelSociete.Text = offre.MySociete.NomSociete.ToUpper();
            labelRegion.Text = offre.MySelection.MyRegion.NomRegion;
            labelContrat.Text = offre.MySelection.MyContrat.TypeContrat;
            labelPoste.Text = offre.MySelection.MyPoste.TypePoste;
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
            bool deleteOffre = offreManager.DeleteOffre(CurrentOffre);
            if (deleteOffre)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}
