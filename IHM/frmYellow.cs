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
        private BO.Region _DefaultRegion = new BO.Region( "Selectionner une région...");
        private Contrat _DefaultContrat = new Contrat("Selectionner un contrat...");
        private Poste _DefaultPoste = new Poste("Selectionner un poste...");
        private RegionManager _RegionManager;
        private PosteManager _PosteManager;
        private ContratManager _ContratManager;
        bool Ok = false;
        public frmYellow(Offre offre)
        {
            InitializeComponent();

            _RegionManager = new RegionManager();
            _PosteManager = new PosteManager();
            _ContratManager = new ContratManager();

            _OldOffre = offre;
            _NewOffre = offre;

            this.DialogResult = DialogResult.Cancel;

            this.FillFormulaire(_OldOffre);

            this.FillingAllComboBox();

            buttonUpdate.Enabled = EnabledUpdate();

            regionNew = _DefaultRegion;
            contratNew = _DefaultContrat;
            posteNew = _DefaultPoste;

            labelTitre.Text = $"Modification de l'offre N°{_OldOffre.Id}";
            labelResultat.Text = String.Empty;

        }
        
        private void bindingSourceRegion_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSourceRegion.Current != null && regionNew != null)
            {
                regionNew = new BO.Region((Consultation)bindingSourceRegion.Current);
                labelRegionNew.Text = (regionNew.Id !=0)?regionNew.Nom : _OldOffre.MySelection.MyRegion.Nom;
                buttonUpdate.Enabled = EnabledUpdate();
                labelResultat.Text = String.Empty;
            }

        }

        private void bindingSourceContrat_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSourceContrat.Current != null && contratNew != null)
            {
                contratNew = new Contrat((Consultation)bindingSourceContrat.Current);
                labelContratNew.Text = (contratNew.Id != 0)? contratNew.Nom : _OldOffre.MySelection.MyContrat.Nom;
                buttonUpdate.Enabled = EnabledUpdate();
                labelResultat.Text = String.Empty;
            }
        }

        private void bindingSourcePoste_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSourcePoste.Current != null && posteNew != null)
            {
                posteNew = new Poste((Consultation)bindingSourcePoste.Current);
                labelPosteNew.Text = (posteNew.Id != 0) ? posteNew.Nom : _OldOffre.MySelection.MyPoste.Nom;
                buttonUpdate.Enabled = EnabledUpdate();
                labelResultat.Text = String.Empty;
            }
        }

        private void frmYellow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = Ok?DialogResult.OK:DialogResult.Cancel;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _NewOffre.MySelection.MyPoste = (posteNew.Id != 0) ? posteNew : _OldOffre.MySelection.MyPoste;
            _NewOffre.MySelection.MyContrat = (contratNew.Id != 0) ? contratNew : _OldOffre.MySelection.MyContrat;
            _NewOffre.MySelection.MyRegion = (regionNew.Id != 0) ? regionNew : _OldOffre.MySelection.MyRegion;
            _NewOffre.Description = textBoxDescriptionNew.Text;
            _NewOffre.LienAnnonce = String.IsNullOrWhiteSpace(textBoxLienAnnonceNew.Text) ? String.Empty : textBoxLienAnnonceNew.Text; 
            OffreManager offreManager = new OffreManager();
            Ok = offreManager.Update(_NewOffre);
            if (Ok)
            {
                this.FillFormulaire(_NewOffre);
                labelResultat.Text = $"Offre modifiée";
                buttonUpdate.Enabled = EnabledUpdate();
            }
            else
            {
                labelResultat.Text = $"Offre non modifiée";
                labelResultat.ForeColor = Color.DarkRed;
                buttonUpdate.Enabled = EnabledUpdate();
            }
        }
        
        private void textBoxDescriptionNew_TextChanged(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = EnabledUpdate();
            labelResultat.Text = String.Empty;
        }

        private void textBoxLienAnnonceNew_TextChanged(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = EnabledUpdate();
            labelResultat.Text = String.Empty;
        }

        private void FillFormulaire(Offre uneOffre)
        {
            labelDatePublication.Text = uneOffre.DatePublication.ToShortDateString();
            labelSociete.Text = uneOffre.MySelection.MySociete.Nom.ToUpper();
            labelRegionOld.Text = uneOffre.MySelection.MyRegion.Nom;
            labelContratOld.Text = uneOffre.MySelection.MyContrat.Nom;
            labelPosteOld.Text = uneOffre.MySelection.MyPoste.Nom;
            textBoxDescriptionOld.Text = uneOffre.Description;
            textBoxLienAnnonceOld.Text = uneOffre.LienAnnonce;
            labelRegionNew.Text = _OldOffre.MySelection.MyRegion.Nom;
            labelContratNew.Text = _OldOffre.MySelection.MyContrat.Nom;
            labelPosteNew.Text = _OldOffre.MySelection.MyPoste.Nom;
            textBoxDescriptionNew.Text = _OldOffre.Description;
            textBoxLienAnnonceNew.Text = _OldOffre.LienAnnonce;
        }
        private bool EnabledUpdate()
        {
            return !(textBoxDescriptionOld.Text == textBoxDescriptionNew.Text
                   && textBoxLienAnnonceOld.Text == textBoxLienAnnonceNew.Text
                   && labelRegionOld.Text == labelRegionNew.Text
                   && labelContratOld.Text == labelContratNew.Text
                   && labelPosteOld.Text == labelPosteNew.Text)
                   && !String.IsNullOrWhiteSpace(textBoxDescriptionNew.Text);
        }
        private void FillingAllComboBox()
        {
            _RegionManager.FillingComboBox(_DefaultRegion, bindingSourceRegion, comboBoxRegion);
            _ContratManager.FillingComboBox(_DefaultContrat, bindingSourceContrat, comboBoxContrat);
            _PosteManager.FillingComboBox(_DefaultPoste, bindingSourcePoste, comboBoxPoste);

        }
    }
}
