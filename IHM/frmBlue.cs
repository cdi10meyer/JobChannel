using BO;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM
{
    public partial class frmBlue : MetroForm
    {
        public frmBlue(Offre offre)
        {
            InitializeComponent();

            labelTitre.Text = $"Détails de l'offre N°{offre.IdOffre}";
            labelDatePublication.Text = offre.DatePublication.ToShortDateString();
            labelSociete.Text = offre.MySelection.MySociete.NomSociete.ToUpper();
            labelRegion.Text = offre.MySelection.MyRegion.NomRegion;
            labelContrat.Text = offre.MySelection.MyContrat.TypeContrat;
            labelPoste.Text = offre.MySelection.MyPoste.TypePoste;
            labelDescription.Text = offre.Description;
            labelLienAnnonce.Text = offre.LienAnnonce;

        }

        
    }
}
