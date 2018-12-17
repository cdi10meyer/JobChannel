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
        BO.Region regionNew;
        Contrat contratNew;
        Poste posteNew;
        Societe societeNew;
        string Champs = "*Champs obligatoire*";
        bool Ok = false;

        public frmGreen()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            _NewOffre = new Offre();

            this.FillingComboBox();

            this.FillFormulaire();
            regionNew = new BO.Region();
            contratNew = new Contrat();
            posteNew = new Poste();
            societeNew = new Societe();

            labelInsert.Text = String.Empty;
            labelTitre.Text = "Création d'une nouvelle Offre";
        }

       
        private void FillFormulaire()
        {
            labelDatePublication.Text = DateTime.Now.ToShortDateString();
            labelSociete.Text = Champs;
            labelRegion.Text = Champs;
            labelPoste.Text = Champs;
            labelContrat.Text = Champs;
            textBoxDescription.Text = Champs;
            textBoxLienAnnonce.Text = String.Empty;
            
            panelSociete.BackColor = Color.Gainsboro;
            labelSociete.ForeColor = Color.DarkRed;
            panelRegion.BackColor = Color.Gainsboro;
            labelRegion.ForeColor = Color.DarkRed;
            panelPoste.BackColor = Color.Gainsboro;
            labelPoste.BackColor = Color.Gainsboro;
            labelPoste.ForeColor = Color.DarkRed;
            panelContrat.BackColor = Color.Gainsboro;
            labelContrat.ForeColor = Color.DarkRed;
            labelContrat.BackColor = Color.Gainsboro;
            labelContrat.ForeColor = Color.DarkRed;
            panelDescription.BackColor = Color.Gainsboro;
            textBoxDescription.BackColor = Color.Gainsboro;
            textBoxDescription.ForeColor = Color.DarkRed;
        }
        private void FillingComboBox()
        {
            SocieteManager societeManager = new SocieteManager();
            bindingSourceSociete.DataSource = societeManager.RetrieveAllSocietes();
            comboBoxSociete.DataSource = bindingSourceSociete;
            comboBoxSociete.ValueMember = "IdSociete";
            comboBoxSociete.DisplayMember = "NomSociete";

            RegionManager regionManager = new RegionManager();
            bindingSourceRegion.DataSource = regionManager.RetrieveAllRegions();
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
        private void bindingSourceSociete_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceSociete.Current != null && societeNew != null)
            {

                societeNew = (Societe)bindingSourceSociete.Current;
                labelSociete.Text = societeNew.NomSociete;
                _NewOffre.MySociete = societeNew;
                panelSociete.BackColor = Color.Honeydew;
                labelSociete.ForeColor = Color.OliveDrab;

            }
        }

        private void bindingSourceRegion_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceRegion.Current != null && regionNew != null)
            {
                regionNew = (BO.Region)bindingSourceRegion.Current;
                labelRegion.Text = regionNew.NomRegion;
                _NewOffre.MySelection.MyRegion = regionNew;
                panelRegion.BackColor = Color.OliveDrab;
                labelRegion.ForeColor = Color.Honeydew;
            }
        }

        private void bindingSourceContrat_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceContrat.Current != null && contratNew != null)
            {

                contratNew = (Contrat)bindingSourceContrat.Current;
                labelContrat.Text = contratNew.TypeContrat;
                _NewOffre.MySelection.MyContrat = contratNew;
                panelContrat.BackColor = Color.Honeydew;
                labelContrat.BackColor = Color.Honeydew;
                labelContrat.ForeColor = Color.OliveDrab;
            }

        }

        private void bindingSourcePoste_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourcePoste.Current != null && posteNew != null)
            {

                posteNew = (Poste)bindingSourcePoste.Current;
                labelPoste.Text = posteNew.TypePoste;
                _NewOffre.MySelection.MyPoste = posteNew;
                panelPoste.BackColor = Color.OliveDrab;
                labelPoste.BackColor = Color.OliveDrab;
                labelPoste.ForeColor = Color.Honeydew;

            }
        }
        
       
        private void frmGreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = Ok? DialogResult.OK:DialogResult.Cancel;
        }

        private void textBoxDescription_Leave(object sender, EventArgs e)
        {
            if(textBoxDescription.Text != String.Empty && textBoxDescription.Text != Champs)
            {
                panelDescription.BackColor = Color.Honeydew;
                textBoxDescription.BackColor = Color.Honeydew;
                textBoxDescription.ForeColor = Color.OliveDrab;
            }
            else
            {
                panelDescription.BackColor = Color.Gainsboro;
                textBoxDescription.BackColor = Color.Gainsboro;
                textBoxDescription.Text = Champs;
                textBoxDescription.ForeColor = Color.DarkRed;
            }
        }

        private void textBoxDescription_Enter(object sender, EventArgs e)
        {
            if (textBoxDescription.Text == Champs)
            {
                textBoxDescription.Text = String.Empty;
                textBoxDescription.ForeColor = Color.OliveDrab;
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (labelSociete.Text != Champs
                && labelRegion.Text != Champs
                && labelPoste.Text != Champs
                && labelContrat.Text != Champs
                && textBoxDescription.Text != Champs
                && textBoxDescription.Text != String.Empty)
            {
                _NewOffre.Description = textBoxDescription.Text;
                _NewOffre.LienAnnonce = textBoxLienAnnonce.Text;

                OffreManager offreManager = new OffreManager();
                int insertOffre = offreManager.CreateOffre(_NewOffre);
                Ok = insertOffre != 0;
                if (Ok)
                {
                    labelInsert.Text = $"Nouvelle offre n° {insertOffre} crée";
                    labelInsert.ForeColor = Color.OliveDrab;
                    this.FillFormulaire();
                }
                else
                {
                    labelInsert.Text = $"L'offre n'a pu être crée";
                    labelInsert.ForeColor = Color.DarkRed;
                }
            }
            else
            {
                labelInsert.Text = $"Veuillez remplir les champs obligatoires";
                labelInsert.ForeColor = Color.DarkRed;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.FillFormulaire();
        }
    }
}
