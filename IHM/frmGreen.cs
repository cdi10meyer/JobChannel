using BLL;
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
    public partial class frmGreen : MetroForm
    {
        private Offre _NewOffre;
        private BO.Region _RegionNew;
        private Contrat _ContratNew;
        private Poste _PosteNew;
        private Societe _SocieteNew;
        private Color _ColorEmpty = Color.Snow;
        private Color _ColorClair = Color.Honeydew;
        private Color _ColorFonce = Color.OliveDrab;
        //private const string CHAMPS = "*Champs obligatoire*";
        private bool Ok = false;

        public frmGreen()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            _NewOffre = new Offre();

            this.FillingComboBox();

            this.FillFormulaire();

            buttonInsert.Visible = this.EnabledInsertion();

            _RegionNew = new BO.Region();
            _ContratNew = new Contrat();
            _PosteNew = new Poste();
            _SocieteNew = new Societe();

            labelTitre.Text = "Création d'une nouvelle Offre";
            labelInsert.Text = "Veuillez remplir les champs obligatoires";
            labelInsert.ForeColor = Color.DarkRed;
        }


        private void FillFormulaire()
        {
            labelDatePublication.Text = DateTime.Now.ToShortDateString();

            labelSociete.Text = String.Empty;
            labelRegion.Text = String.Empty;
            labelPoste.Text = String.Empty;
            labelContrat.Text = String.Empty;
            textBoxDescription.Text = String.Empty;
            textBoxLienAnnonce.Text = String.Empty;

            panelSociete.BackColor = _ColorEmpty;
            panelRegion.BackColor = _ColorEmpty;
            panelPoste.BackColor = _ColorEmpty;
            labelPoste.BackColor = _ColorEmpty;
            panelContrat.BackColor = _ColorEmpty;
            labelContrat.BackColor = _ColorEmpty;
            panelDescription.BackColor = _ColorEmpty;
            textBoxDescription.BackColor = _ColorEmpty;
        }
        private void FillingComboBox()
        {
            SocieteManager societeManager = new SocieteManager();
            bindingSourceSociete.DataSource = societeManager.RetrieveAll("Selectionner une société...", new Societe());
            comboBoxSociete.DataSource = bindingSourceSociete;
            comboBoxSociete.ValueMember = "Id";
            comboBoxSociete.DisplayMember = "Nom";

            RegionManager regionManager = new RegionManager();
            bindingSourceRegion.DataSource = regionManager.RetrieveAll("Selectionner une région...", new BO.Region());
            comboBoxRegion.DataSource = bindingSourceRegion;
            comboBoxRegion.ValueMember = "Id";
            comboBoxRegion.DisplayMember = "Nom";


            ContratManager contratManager = new ContratManager();
            bindingSourceContrat.DataSource = contratManager.RetrieveAll("Selectionner un contrat...", new Contrat());
            comboBoxContrat.DataSource = bindingSourceContrat;
            comboBoxContrat.ValueMember = "Id";
            comboBoxContrat.DisplayMember = "Nom";

            PosteManager posteManager = new PosteManager();
            bindingSourcePoste.DataSource = posteManager.RetrieveAll("Selectionner un poste...", new Poste());
            comboBoxPoste.DataSource = bindingSourcePoste;
            comboBoxPoste.ValueMember = "Id";
            comboBoxPoste.DisplayMember = "Nom";

        }
        private void bindingSourceSociete_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceSociete.Current != null && _SocieteNew != null)
            {
                _SocieteNew = (Societe)bindingSourceSociete.Current;

                labelSociete.Text = (_SocieteNew.Id != 0) ? _SocieteNew.Nom : String.Empty;
                _NewOffre.MySelection.MySociete = (_SocieteNew.Id != 0) ? _SocieteNew : null;
                panelSociete.BackColor = (_SocieteNew.Id != 0) ? _ColorClair : _ColorEmpty;
                labelSociete.ForeColor = (_SocieteNew.Id != 0) ? _ColorFonce : _ColorEmpty;
                buttonInsert.Visible = EnabledInsertion();
            }
        }

        private void bindingSourceRegion_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceRegion.Current != null && _RegionNew != null)
            {
                _RegionNew = (BO.Region)bindingSourceRegion.Current;

                labelRegion.Text = (_RegionNew.Id !=0)?_RegionNew.Nom : String.Empty;
                _NewOffre.MySelection.MyRegion = (_RegionNew.Id != 0) ? _RegionNew : null;
                panelRegion.BackColor = (_RegionNew.Id != 0) ? _ColorFonce : _ColorEmpty;
                labelRegion.ForeColor = (_RegionNew.Id != 0) ? _ColorClair : _ColorEmpty;
                buttonInsert.Visible = EnabledInsertion();
            }
        }

        private void bindingSourceContrat_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceContrat.Current != null && _ContratNew != null)
            {
                _ContratNew = (Contrat)bindingSourceContrat.Current;

                labelContrat.Text =(_ContratNew.Id!=0)? _ContratNew.Nom : String.Empty;
                _NewOffre.MySelection.MyContrat = (_ContratNew.Id != 0) ? _ContratNew : null;
                panelContrat.BackColor = (_ContratNew.Id != 0) ? _ColorClair: _ColorEmpty;
                labelContrat.BackColor = (_ContratNew.Id != 0) ? _ColorClair: _ColorEmpty;
                labelContrat.ForeColor = (_ContratNew.Id != 0) ? _ColorFonce: _ColorEmpty;
                buttonInsert.Visible = EnabledInsertion();
            }

        }

        private void bindingSourcePoste_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourcePoste.Current != null && _PosteNew != null)
            {
                _PosteNew = (Poste)bindingSourcePoste.Current;
                labelPoste.Text = (_PosteNew.Id !=0)?_PosteNew.Nom : String.Empty;
                _NewOffre.MySelection.MyPoste = (_PosteNew.Id != 0) ? _PosteNew : null;
                panelPoste.BackColor = (_PosteNew.Id != 0) ? _ColorFonce : _ColorEmpty;
                labelPoste.BackColor = (_PosteNew.Id != 0) ? _ColorFonce : _ColorEmpty;
                labelPoste.ForeColor = (_PosteNew.Id != 0) ? _ColorClair : _ColorEmpty;
                buttonInsert.Visible = EnabledInsertion();
            }
        }


        private void frmGreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = Ok ? DialogResult.OK : DialogResult.Cancel;
        }
        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            bool empty = String.IsNullOrWhiteSpace(textBoxDescription.Text);
            panelDescription.BackColor = (empty) ? _ColorEmpty : _ColorClair;
            textBoxDescription.BackColor = (empty) ? _ColorEmpty : _ColorClair;
            buttonInsert.Visible = EnabledInsertion();
        }


        private void buttonInsert_Click(object sender, EventArgs e)
        {
            _NewOffre.Description = textBoxDescription.Text;
            _NewOffre.LienAnnonce = textBoxLienAnnonce.Text;

            OffreManager offreManager = new OffreManager();
            int insertOffre = offreManager.Create(_NewOffre);
            Ok = insertOffre != 0;
            if (Ok)
            {
                labelInsert.Text = $"Nouvelle offre n° {insertOffre} crée";
                labelInsert.ForeColor = _ColorFonce;
                this.FillFormulaire();
            }
            else
            {
                labelInsert.Text = $"L'offre n'a pu être crée";
                labelInsert.ForeColor = Color.DarkRed;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.FillFormulaire();
        }

        private bool EnabledInsertion()
        {
            return !String.IsNullOrWhiteSpace(labelSociete.Text)
                            && !String.IsNullOrWhiteSpace(labelRegion.Text)
                            && !String.IsNullOrWhiteSpace(labelPoste.Text)
                            && !String.IsNullOrWhiteSpace(labelContrat.Text)
                            && !String.IsNullOrWhiteSpace(textBoxDescription.Text);
        }


    }
}
