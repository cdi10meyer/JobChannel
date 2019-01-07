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
    public partial class frmYellow : MetroForm
    {
        private Offre _OldOffre;
        private Offre _NewOffre;
        BO.Region regionNew;
        Contrat contratNew;
        Poste posteNew;
        bool Ok = false;
        public frmYellow(Offre offre)
        {
            InitializeComponent();
            _OldOffre = offre;
            _NewOffre = offre;
            this.DialogResult = DialogResult.Cancel;

            this.FillingComboBox();
            this.FillFormulaire(offre);
            regionNew = new BO.Region();
            contratNew = new Contrat();
            posteNew = new Poste();

            labelTitre.Text = $"Modification de l'offre N°{_OldOffre.IdOffre}";
            labelResultat.Text = String.Empty;

        }
        private void FillingComboBox()
        {

            RegionManager regionManager = new RegionManager();
            bindingSourceRegion.DataSource = regionManager.RetrieveAll();
            comboBoxRegion.DataSource = bindingSourceRegion;
            comboBoxRegion.ValueMember = "IdRegion";
            comboBoxRegion.DisplayMember = "NomRegion";


            ContratManager contratManager = new ContratManager();
            bindingSourceContrat.DataSource = contratManager.RetrieveAllContrats();
            comboBoxContrat.DataSource = bindingSourceContrat;
            comboBoxContrat.ValueMember = "IdContrat";
            comboBoxContrat.DisplayMember = "TypeContrat";

            PosteManager posteManager = new PosteManager();
            bindingSourcePoste.DataSource = posteManager.RetrieveAllPostes();
            comboBoxPoste.DataSource = bindingSourcePoste;
            comboBoxPoste.ValueMember = "IdPoste";
            comboBoxPoste.DisplayMember = "TypePoste";

        }

        private void bindingSourceRegion_CurrentChanged(object sender, EventArgs e)
        {

            if (bindingSourceRegion.Current != null && regionNew != null)
            {

                regionNew = (BO.Region)bindingSourceRegion.Current;
                labelRegionNew.Text = regionNew.NomRegion;
                _NewOffre.MySelection.MyRegion = regionNew;

            }

        }

        private void bindingSourceContrat_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSourceContrat.Current != null && contratNew != null)
            {

                contratNew = (Contrat)bindingSourceContrat.Current;
                labelContratNew.Text = contratNew.TypeContrat;
                _NewOffre.MySelection.MyContrat = contratNew;

            }
        }

        private void bindingSourcePoste_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSourcePoste.Current != null && posteNew != null)
            {

                posteNew = (Poste)bindingSourcePoste.Current;
                labelPosteNew.Text = posteNew.TypePoste;
                _NewOffre.MySelection.MyPoste = posteNew;

            }
        }


        private void FillFormulaire(Offre offre)
        {
            labelDatePublication.Text = offre.DatePublication.ToShortDateString();
            labelSociete.Text = offre.MySociete.NomSociete.ToUpper();
            labelRegionOld.Text = offre.MySelection.MyRegion.NomRegion;
            labelContratOld.Text = offre.MySelection.MyContrat.TypeContrat;
            labelPosteOld.Text = offre.MySelection.MyPoste.TypePoste;
            textBoxDescriptionOld.Text = offre.Description;
            textBoxLienAnnonceOld.Text = offre.LienAnnonce;
            labelRegionNew.Text = String.Empty;
            labelContratNew.Text = String.Empty;
            labelPosteNew.Text = String.Empty;
        }

        private void frmYellow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = Ok?DialogResult.OK:DialogResult.Cancel;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            _NewOffre.MySelection.MyRegion = (labelRegionOld.Text == String.Empty) ? _OldOffre.MySelection.MyRegion : _NewOffre.MySelection.MyRegion;
            _NewOffre.MySelection.MyContrat = (labelContratNew.Text == String.Empty) ? _OldOffre.MySelection.MyContrat : _NewOffre.MySelection.MyContrat;
            _NewOffre.MySelection.MyPoste = (labelPosteNew.Text == String.Empty) ? _OldOffre.MySelection.MyPoste : _NewOffre.MySelection.MyPoste;
            _NewOffre.Description = (textBoxDescriptionNew.Text == String.Empty) ? textBoxDescriptionOld.Text : textBoxDescriptionNew.Text;
            _NewOffre.LienAnnonce = (textBoxLienAnnonceNew.Text == String.Empty) ? textBoxLienAnnonceOld.Text : textBoxLienAnnonceNew.Text;
            OffreManager offreManager = new OffreManager();
            Ok = offreManager.UpdateOffre(_NewOffre);
            if (Ok)
            {
                this.FillFormulaire(_NewOffre);
                labelResultat.Text = $"Offre modifiée";
            }
            else
            {
                labelResultat.Text = $"Offre non modifiée";
                labelResultat.ForeColor = Color.DarkRed;
            }
        }
    }
}
