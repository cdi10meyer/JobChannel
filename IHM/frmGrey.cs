using BLL;
using BO;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace IHM
{
    public partial class frmGrey : MetroForm
    {
        private Societe _RecordedSociete;
        private BO.Region _RecordedRegion;
        private Contrat _RecordedContrat;
        private Poste _RecordedPoste;
        private Jour _RecordedJour;
        private int _RecordedId;

        private Societe _DefaultSociete = new Societe("Toutes les sociétés");
        private BO.Region _DefaultRegion = new BO.Region("Toutes les régions");
        private Contrat _DefaultContrat = new Contrat("Tous les contrats");
        private Poste _DefaultPoste = new Poste("Tous les postes");
        private Jour _DefaultJour = new Jour("Tous les jours");

        private Selection _RecordedSelection;
        private Selection _Preference;
        private Offre _RecordedOffre;
        private const string ERREUR = "Veuillez Sélectionner une offre";
        private const string CREE = "crée";
        private const string MODIFIE = "modifiée";
        private const string SUPPRIMEE = "supprimée";
        private const string PREFERENCEFILE = "preference.json";

        public frmGrey() : base()
        {
            InitializeComponent();

            _RecordedSociete = _DefaultSociete;
            _RecordedRegion = _DefaultRegion;
            _RecordedContrat = _DefaultContrat;
            _RecordedPoste = _DefaultPoste;
            _RecordedJour = _DefaultJour;

            _RecordedOffre = new Offre();
            
            this.FillingAllComboBox();

            _RecordedSelection = new Selection(_RecordedSociete, _RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJour);

            this.FillingDataGridView(_RecordedSelection);

            //labelResultat.Text = String.Empty;
            this.EnabledButtonPreference();

            panelPreference.Visible = false;

        }

        #region "Gestion des selections"
        private void bindingSourceSociete_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceSociete.Current != null && _RecordedSelection != null)
            {
                _RecordedSociete = new Societe((Consultation)bindingSourceSociete.Current);
                _RecordedSelection = new Selection(_RecordedSociete, _RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJour);
                labelPreferenceSociete.Text = _RecordedSelection.MySociete.Nom;
                this.FillingDataGridView(_RecordedSelection);
            }
        }
        private void bindingSourceRegion_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceRegion.Current != null && _RecordedSelection != null)
            {
                _RecordedRegion = new BO.Region((Consultation)bindingSourceRegion.Current);
                _RecordedSelection = new Selection(_RecordedSociete, _RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJour);
                labelPreferenceRegion.Text = _RecordedSelection.MyRegion.Nom;
                this.FillingDataGridView(_RecordedSelection);
            }
        }

        private void bindingSourceContrat_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceContrat.Current != null && _RecordedSelection != null)
            {
                _RecordedContrat = new Contrat((Consultation)bindingSourceContrat.Current);
                _RecordedSelection = new Selection(_RecordedSociete, _RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJour);
                labelPreferenceContrat.Text = _RecordedSelection.MyContrat.Nom;
                this.FillingDataGridView(_RecordedSelection);
            }
        }

        private void bindingSourcePoste_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourcePoste.Current != null && _RecordedSelection != null)
            {
                _RecordedPoste = new Poste((Consultation)bindingSourcePoste.Current);
                _RecordedSelection = new Selection(_RecordedSociete, _RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJour);
                labelPreferencePoste.Text = _RecordedSelection.MyPoste.Nom;
                this.FillingDataGridView(_RecordedSelection);
            }
        }
        private void bindingSourceJour_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceJour.Current != null && _RecordedSelection != null)
            {
                _RecordedJour = new Jour((Consultation)bindingSourceJour.Current);
                _RecordedSelection = new Selection(_RecordedSociete, _RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJour);
                labelPreferenceJours.Text = _RecordedSelection.NbrJour.Nom;
                this.FillingDataGridView(_RecordedSelection);
            }
        }

        private void bindingSourceOffre_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceOffre.Current != null)
            {
                _RecordedOffre = (Offre)bindingSourceOffre.Current;
                labelResultat.Text =$"Offre n°{_RecordedOffre.Id} séléctionnée";
                labelResultat.ForeColor = Color.Gainsboro;
            }
            else
            {
                _RecordedOffre = null;
            }
        }

        #endregion "Gestion des selections"

        #region "Gestion des boutons CRUD"
        
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (_RecordedOffre != null)
            {
                this.Opacity = 0.5;
                using (frmBlue fenetre = new frmBlue(_RecordedOffre))
                {
                    fenetre.ShowDialog();
                }
                this.Opacity = 1;
            }
            else
            {
                labelResultat.Text = ERREUR;
                labelResultat.ForeColor = Color.SteelBlue;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (_RecordedOffre != null)
            {
                _RecordedId = _RecordedOffre.Id;
                this.Opacity = 0.5;
                using (frmYellow fenetre = new frmYellow(_RecordedOffre))
                {
                    fenetre.ShowDialog();
                    if (fenetre.DialogResult == DialogResult.OK)
                    {
                        this.Opacity = 1;
                        FillingDataGridView(_RecordedSelection);
                        labelResultat.Text = ConstructAction(_RecordedId,MODIFIE);
                        labelResultat.ForeColor = Color.Orange;
                    }
                }
                this.Opacity = 1;
            }
            else
            {
                labelResultat.Text = ERREUR;
                labelResultat.ForeColor = Color.Orange;
            }

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            using (frmGreen fenetre = new frmGreen())
            {
                fenetre.ShowDialog();
                if (fenetre.DialogResult == DialogResult.OK)
                {
                    this.Opacity = 1;
                    FillingDataGridView(_RecordedSelection);
                    dataGridViewOffre.Rows[0].Selected = true;
                    _RecordedId = Convert.ToInt32(dataGridViewOffre.SelectedCells[5].Value);
                    labelResultat.Text = ConstructAction(_RecordedId,CREE);
                    labelResultat.ForeColor = Color.OliveDrab;
                }
            }
            this.Opacity = 1;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            if (_RecordedOffre != null)
            {
                _RecordedId = _RecordedOffre.Id;
                using (frmRed fenetre = new frmRed(_RecordedOffre))
                {
                    fenetre.ShowDialog();
                    if (fenetre.DialogResult == DialogResult.OK)
                    {
                        FillingDataGridView(_RecordedSelection);
                        labelResultat.Text = ConstructAction(_RecordedId, SUPPRIMEE);
                        labelResultat.ForeColor = Color.DarkRed;
                    }
                }
            }
            else
            {
                labelResultat.Text = ERREUR;
                labelResultat.ForeColor = Color.DarkRed;
            }
            this.Opacity = 1;

        }
        #endregion "Gestion des boutons CRUD"

        #region "Gestion des préférences"
        private void checkBoxPreference_CheckedChanged(object sender, EventArgs e)
        {
            panelPreference.Visible = checkBoxPreference.Checked;
            if (panelPreference.Visible)
            {
                _Preference = GetPreference();
                this.FillingPreference(_Preference);
            }
            else
            {
                _Preference = new Selection(_RecordedSociete, _RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJour);
                this.FillingPreference(_Preference);
            }
        }

        private void buttonReinitialiser_Click(object sender, EventArgs e)
        {
            _Preference = this.GetPreference();
            this.FillingPreference(_Preference);
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            _Preference = _RecordedSelection;
            CreatePreference(_Preference);
        }
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            this.DeletePreference();
            _Preference = new Selection(_RecordedSociete, _RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJour);
            this.FillingPreference(_Preference);

        }
        #endregion "Gestion des préférences"

        #region "Méthodes propres à la classe"
        private void FillingAllComboBox()
        {
            SocieteManager societeManager = new SocieteManager();
            RegionManager regionManager = new RegionManager();
            ContratManager contratManager = new ContratManager();
            PosteManager posteManager = new PosteManager();
            JourManager jourManager = new JourManager();

            societeManager.FillingComboBox(_DefaultSociete, bindingSourceSociete, comboBoxSociete);
            regionManager.FillingComboBox(_DefaultRegion, bindingSourceRegion, comboBoxRegion);
            contratManager.FillingComboBox(_DefaultContrat, bindingSourceContrat, comboBoxContrat);
            posteManager.FillingComboBox(_DefaultPoste, bindingSourcePoste, comboBoxPoste);
            jourManager.FillingComboBox(_DefaultJour, bindingSourceJour, comboBoxJour);
        }

        private void FillingDataGridView(Selection selection)
        {
            List<Offre> offres;
            OffreManager offreManager = new OffreManager();

            offres = (selection != null) ? offreManager.RetrieveBySelection(selection) : offreManager.RetrieveAll();

            bindingSourceOffre.DataSource = offres;
            dataGridViewOffre.DataSource = bindingSourceOffre;
            ModelingRowsDataGridView();
            ModelingColumnsDataGridView();
        }
        private void ModelingRowsDataGridView()
        {
            int nombre = dataGridViewOffre.RowCount;
            dataGridViewOffre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int totalRowHeight = dataGridViewOffre.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dataGridViewOffre.Rows)
            {
                totalRowHeight += row.Height;
            }

            dataGridViewOffre.Height = totalRowHeight;
        }
        private void ModelingColumnsDataGridView()
        {
            dataGridViewOffre.Columns["Id"].Visible = false;
            dataGridViewOffre.Columns["MySelection"].Visible = false;
            dataGridViewOffre.Columns["Description"].Visible = false;
            dataGridViewOffre.Columns["LienAnnonce"].Visible = false;
            dataGridViewOffre.Columns["DatePublication"].Visible = false;
            dataGridViewOffre.Columns["NomSociete"].HeaderText = "Société";
            dataGridViewOffre.Columns["NomRegion"].HeaderText = "Région";
            dataGridViewOffre.Columns["TypeContrat"].HeaderText = "Contrat";
            dataGridViewOffre.Columns["TypePoste"].HeaderText = "Poste";
            dataGridViewOffre.Columns["Publication"].DefaultCellStyle.ForeColor = Color.DarkOliveGreen;
            dataGridViewOffre.Columns["NomSociete"].DefaultCellStyle.ForeColor = Color.DarkGreen;
            dataGridViewOffre.Columns["NomRegion"].DefaultCellStyle.ForeColor = Color.DarkSlateBlue;
            dataGridViewOffre.Columns["TypeContrat"].DefaultCellStyle.ForeColor = Color.DarkCyan;
            dataGridViewOffre.Columns["TypePoste"].DefaultCellStyle.ForeColor = Color.DarkMagenta;
        }

        public string ConstructAction(int id,string action)
        {
            return $"Offre n°{id} {action} avec succès";
        }

        private void FillingPreference(Selection preference)
        {
            labelPreferenceSociete.Text = preference.MySociete.Nom;
            comboBoxSociete.SelectedValue = comboBoxSociete.FindStringExact(labelPreferenceSociete.Text);

            labelPreferenceRegion.Text = preference.MyRegion.Nom;
            comboBoxRegion.SelectedValue = comboBoxRegion.FindStringExact(labelPreferenceRegion.Text);

            labelPreferencePoste.Text = preference.MyPoste.Nom;
            comboBoxPoste.SelectedValue = comboBoxPoste.FindStringExact(labelPreferencePoste.Text);

            labelPreferenceContrat.Text = preference.MyContrat.Nom;
            comboBoxContrat.SelectedValue = comboBoxContrat.FindStringExact(labelPreferenceContrat.Text);

            labelPreferenceJours.Text = preference.NbrJour.Nom;
            comboBoxJour.SelectedIndex = comboBoxJour.FindStringExact(labelPreferenceJours.Text);

        }

        private Selection GetPreference()
        {
            //File.Delete(PREFERENCEFILE);
            if (File.Exists(PREFERENCEFILE))
            {
                Stream fichier = File.OpenRead(PREFERENCEFILE);
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Selection));
                _Preference = (Selection)serializer.ReadObject(fichier);
                fichier.Close();
            }
            else
            {
                _Preference = new Selection(_RecordedSociete, _RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJour);
            }
            return _Preference;
        }
        /// <summary>
        /// Méthode appelée lors de l'évenement clic du bouton enregistrer
        /// Permet de sérialiser en json et d'enregistrer dans un fichier l'objet
        /// </summary>
        /// <param name="selection"></param>
        private void CreatePreference(Selection selection)
        {
            _Preference = selection;
            Stream fichier = File.Create(PREFERENCEFILE);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(_Preference.GetType());
            serializer.WriteObject(fichier, _Preference);
            fichier.Close();
            this.EnabledButtonPreference();
        }

        private void DeletePreference()
        {
            File.Delete(PREFERENCEFILE);
            this.EnabledButtonPreference();
        }

        private void EnabledButtonPreference()
        {
            bool enabled = File.Exists(PREFERENCEFILE);
            buttonReinitialiser.Enabled = enabled;
            buttonSupprimer.Enabled = enabled;
        }
        #endregion "Méthodes propres à la classe"

       
    }
}

