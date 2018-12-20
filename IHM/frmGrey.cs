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
        private BO.Region _RecordedRegion;
        private Contrat _RecordedContrat;
        private Poste _RecordedPoste;
        private int _RecordedJours;
        private Selection _RecordedSelection;
        private Selection _Preference;
        private Offre _RecordedOffre;
        string Erreur = "Veuillez Sélectionner une offre";
        string Cree = "crée";
        string Modifie = "modifiée";
        string Supprimee = "supprimée";
        public List<string> _Jours;

        public frmGrey() : base()
        {
            InitializeComponent();

            _RecordedRegion = new BO.Region();
            _RecordedContrat = new Contrat();
            _RecordedPoste = new Poste();
            _RecordedOffre = new Offre();
            _RecordedJours = 0;
            _Jours = new List<string>()
            {
                "Tous",
                "10",
                "20",
                "30"
            };

            this.FillingComboBox();
            _RecordedSelection = new Selection(_RecordedPoste, _RecordedRegion, _RecordedContrat, 0);
            this.FillingDataGridView(_RecordedSelection);

            this.ModelingColumns();

            labelResultat.Text = String.Empty;
            panelPreference.Visible = false;

        }
        #region "Méthodes propres à la classe"
        private void FillingComboBox()
        {
            RegionManager regionManager = new RegionManager();
            bindingSourceRegion.DataSource = regionManager.RetrieveAllRegionsToutes();
            comboBoxRegion.DataSource = bindingSourceRegion;
            comboBoxRegion.ValueMember = "IdRegion";
            comboBoxRegion.DisplayMember = "NomRegion";

            ContratManager contratManager = new ContratManager();
            bindingSourceContrat.DataSource = contratManager.RetrieveAllContratsTous();
            comboBoxContrat.DataSource = bindingSourceContrat;
            comboBoxContrat.ValueMember = "IdContrat";
            comboBoxContrat.DisplayMember = "TypeContrat";

            PosteManager posteManager = new PosteManager();
            bindingSourcePoste.DataSource = posteManager.RetrieveAllPostesTous();
            comboBoxPoste.DataSource = bindingSourcePoste;
            comboBoxPoste.ValueMember = "IdPoste";
            comboBoxPoste.DisplayMember = "TypePoste";


            comboBoxJours.DataSource = _Jours;
        }
        private void FillingDataGridView(Selection selection)
        {
            List<Offre> offres;
            OffreManager offreManager = new OffreManager();

            offres = (selection != null) ? offreManager.RetrieveOffresBySelection(selection) : offreManager.RetrieveAllOffres(); ;

            bindingSourceOffre.DataSource = offres;
            dataGridViewOffre.DataSource = bindingSourceOffre;
            ModelingDataGridView();
        }
        private void ModelingDataGridView()
        {
            int nombre = dataGridViewOffre.RowCount;
            dataGridViewOffre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int totalRowHeight = dataGridViewOffre.ColumnHeadersHeight + 5;


            foreach (DataGridViewRow row in dataGridViewOffre.Rows)
            {totalRowHeight += row.Height;
            }

            dataGridViewOffre.Height = totalRowHeight;
        }
        private void ModelingColumns()
        {
            dataGridViewOffre.Columns["IdOffre"].Visible = false;
            dataGridViewOffre.Columns["MySelection"].Visible = false;
            dataGridViewOffre.Columns["Description"].Visible = false;
            dataGridViewOffre.Columns["LienAnnonce"].Visible = false;
            dataGridViewOffre.Columns["DatePublication"].Visible = false;
            dataGridViewOffre.Columns["MySociete"].HeaderText = "Société";
            dataGridViewOffre.Columns["NomRegion"].HeaderText = "Région";
            dataGridViewOffre.Columns["TypeContrat"].HeaderText = "Contrat";
            dataGridViewOffre.Columns["TypePoste"].HeaderText = "Poste";
            dataGridViewOffre.Columns["DatePublication"].HeaderText = "Date de publication";
            dataGridViewOffre.Columns["Publication"].DisplayIndex = 0;
            dataGridViewOffre.Columns["MySociete"].DisplayIndex = 1;
            dataGridViewOffre.Columns["NomRegion"].DisplayIndex = 2;
            dataGridViewOffre.Columns["TypeContrat"].DisplayIndex = 3;
            dataGridViewOffre.Columns["TypePoste"].DisplayIndex = 4;
        }

        public string ConstructAction(string action)
        {
            return $"Offre {action} avec succès";
        }

        private void FillingPreference(Selection preference)
        {
            labelPreferenceRegion.Text = preference.MyRegion.NomRegion;

            comboBoxRegion.SelectedValue = comboBoxRegion.FindStringExact(labelPreferenceRegion.Text);

            labelPreferencePoste.Text = preference.MyPoste.TypePoste;

            comboBoxPoste.SelectedValue = comboBoxPoste.FindStringExact(labelPreferencePoste.Text);

            labelPreferenceContrat.Text = preference.MyContrat.TypeContrat;
            
            comboBoxContrat.SelectedValue = comboBoxContrat.FindStringExact(labelPreferenceContrat.Text);

            labelPreferenceJours.Text = (preference.NbrJour != 0) ? _Preference.NbrJour.ToString() : "Tous";

            comboBoxJours.SelectedIndex = comboBoxJours.FindStringExact(labelPreferenceJours.Text);

        }

        #endregion "Méthodes propres à la classe"

        private void bindingSourceRegion_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceRegion.Current != null && _RecordedSelection != null)
            {
                _RecordedRegion = (BO.Region)bindingSourceRegion.Current;
                _RecordedSelection = new Selection(_RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJours);
                labelPreferenceRegion.Text = _RecordedSelection.MyRegion.NomRegion;
                this.FillingDataGridView(_RecordedSelection);
            }
        }

        private void bindingSourceContrat_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceContrat.Current != null && _RecordedSelection != null)
            {
                _RecordedContrat = (Contrat)bindingSourceContrat.Current;
                _RecordedSelection = new Selection(_RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJours);
                labelPreferenceContrat.Text = _RecordedSelection.MyContrat.TypeContrat;
                this.FillingDataGridView(_RecordedSelection);
            }
        }

        private void bindingSourcePoste_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourcePoste.Current != null && _RecordedSelection != null)
            {
                _RecordedPoste = (Poste)bindingSourcePoste.Current;
                _RecordedSelection = new Selection(_RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJours);
                labelPreferencePoste.Text = _RecordedSelection.MyPoste.TypePoste;
                this.FillingDataGridView(_RecordedSelection);
            }
        }
        private void comboBoxJours_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxJours.SelectedValue != null && _RecordedSelection != null)
            {
                _RecordedJours = (comboBoxJours.SelectedValue.ToString() != "Tous") ? Convert.ToInt32(comboBoxJours.SelectedValue) : 0;

                _RecordedSelection = new Selection(_RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJours);
                labelPreferenceJours.Text = (_RecordedSelection.NbrJour != 0) ? _RecordedSelection.NbrJour.ToString() : "Tous";
                this.FillingDataGridView(_RecordedSelection);
            }

        }

        private void bindingSourceOffre_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceOffre.Current != null)
            {
                _RecordedOffre = (Offre)bindingSourceOffre.Current;
            }
            else
            {
                _RecordedOffre = null;
            }
        }


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
                labelResultat.Text = Erreur;
                labelResultat.ForeColor = Color.SteelBlue;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (_RecordedOffre != null)
            {
                this.Opacity = 0.5;
                using (frmYellow fenetre = new frmYellow(_RecordedOffre))
                {
                    fenetre.ShowDialog();
                    if (fenetre.DialogResult == DialogResult.OK)
                    {
                        this.Opacity = 1;
                        FillingDataGridView(_RecordedSelection);
                        labelResultat.Text = ConstructAction(Modifie);
                        labelResultat.ForeColor = Color.Orange;
                    }
                }
                this.Opacity = 1;
            }
            else
            {
                labelResultat.Text = Erreur;
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
                    labelResultat.Text = ConstructAction(Cree);
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
                using (frmRed fenetre = new frmRed(_RecordedOffre))
                {
                    fenetre.ShowDialog();
                    if (fenetre.DialogResult == DialogResult.OK)
                    {
                        FillingDataGridView(_RecordedSelection);
                        labelResultat.Text = ConstructAction(Supprimee);
                        labelResultat.ForeColor = Color.DarkRed;
                    }
                }
            }
            else
            {
                labelResultat.Text = Erreur;
                labelResultat.ForeColor = Color.DarkRed;
            }
            this.Opacity = 1;

        }

        private void checkBoxPreference_CheckedChanged(object sender, EventArgs e)
        {
            panelPreference.Visible = checkBoxPreference.Checked;
            if (panelPreference.Visible)
            {
                _Preference = GetPreference();
                this.FillingPreference(_Preference);
            }
        }

        private void buttonReinitialiser_Click(object sender, EventArgs e)
        {
            _Preference = this.GetPreference();
            this.FillingPreference(_Preference);
            //this.FillingDataGridView(_Preference);
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            _Preference = _RecordedSelection;
            CreatePreference(_Preference);
        }
        private Selection GetPreference()
        {
            //File.Delete("preference.json");
            if (File.Exists("preference.json"))
            {
                Stream fichier = File.OpenRead("preference.json");
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Selection));
                _Preference = (Selection)serializer.ReadObject(fichier);
                fichier.Close();
            }
            else
            {
                _Preference = new Selection();
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
            Stream fichier = File.Create("preference.json");
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(_Preference.GetType());
            serializer.WriteObject(fichier, _Preference);
            fichier.Close();
        }
    }
}

