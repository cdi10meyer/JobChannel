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
        private int _RecordedJours;
        private Selection _RecordedSelection;
        private Selection _Preference;
        private Offre _RecordedOffre;
        private const string ERREUR = "Veuillez Sélectionner une offre";
        private const string CREE = "crée";
        private const string MODIFIE = "modifiée";
        private const string SUPPRIMEE = "supprimée";
        private const string PREFERENCEFILE = "preference.json";
        private List<string> _Jours = new List<string>()
            {
                "Tous",
                "10",
                "20",
                "30"
            };

        public frmGrey() : base()
        {
            InitializeComponent();

            _RecordedSociete = new Societe();
            _RecordedRegion = new BO.Region();
            _RecordedContrat = new Contrat();
            _RecordedPoste = new Poste();
            _RecordedOffre = new Offre();
            _RecordedJours = 0;

            this.FillingComboBox();
            _RecordedSelection = new Selection(_RecordedSociete,_RecordedPoste,_RecordedRegion,_RecordedContrat, 0);
            this.FillingDataGridView(_RecordedSelection);

            this.ModelingColumns();

            labelResultat.Text = String.Empty;
            this.EnabledButtonPreference();

            panelPreference.Visible = false;

        }
        #region "Méthodes propres à la classe"
        private void FillingComboBox()
        {
            SocieteManager societeManager = new SocieteManager();

            bindingSourceSociete.DataSource = societeManager.RetrieveAll("Toutes", new Societe());
            comboBoxSociete.DataSource = bindingSourceSociete;
            comboBoxSociete.ValueMember = "Id";
            comboBoxSociete.DisplayMember = "Nom";

            RegionManager regionManager = new RegionManager();
            List<BO.Region> regions = new List<BO.Region>();
            BO.Region region = new BO.Region();
            bindingSourceRegion.DataSource = regionManager.RetrieveAll("Toutes", new BO.Region());
            comboBoxRegion.DataSource = bindingSourceRegion;
            comboBoxRegion.ValueMember = "Id";
            comboBoxRegion.DisplayMember = "Nom";

            ContratManager contratManager = new ContratManager();
            bindingSourceContrat.DataSource = contratManager.RetrieveAll("Tous", new Contrat());
            comboBoxContrat.DataSource = bindingSourceContrat;
            comboBoxContrat.ValueMember = "Id";
            comboBoxContrat.DisplayMember = "Nom";

            PosteManager posteManager = new PosteManager();
            bindingSourcePoste.DataSource = posteManager.RetrieveAll("Tous", new Poste());
            comboBoxPoste.DataSource = bindingSourcePoste;
            comboBoxPoste.ValueMember = "Id";
            comboBoxPoste.DisplayMember = "Nom";


            comboBoxJours.DataSource = _Jours;
        }
        private void FillingDataGridView(Selection selection)
        {
            List<Offre> offres;
            OffreManager offreManager = new OffreManager();

            offres = (selection != null) ? offreManager.RetrieveBySelection(selection) : offreManager.RetrieveAll();

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
            {
                totalRowHeight += row.Height;
            }

            dataGridViewOffre.Height = totalRowHeight;
        }
        private void ModelingColumns()
        {
            dataGridViewOffre.Columns["Id"].Visible = false;
            dataGridViewOffre.Columns["Nom"].Visible = false;
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

        public string ConstructAction(string action)
        {
            return $"Offre {action} avec succès";
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

            labelPreferenceJours.Text = (preference.NbrJour != 0) ? _Preference.NbrJour.ToString() : _Jours.First();
            comboBoxJours.SelectedIndex = comboBoxJours.FindStringExact(labelPreferenceJours.Text);

        }

        #endregion "Méthodes propres à la classe"

        private void bindingSourceSociete_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceSociete.Current != null && _RecordedSelection != null)
            {
                _RecordedSociete = new Societe((Consultation)bindingSourceSociete.Current);
               _RecordedSelection = new Selection(_RecordedSociete, _RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJours);
                labelPreferenceSociete.Text = _RecordedSelection.MySociete.Nom;
                this.FillingDataGridView(_RecordedSelection);
            }
        }
        private void bindingSourceRegion_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceRegion.Current != null && _RecordedSelection != null)
            {
                _RecordedRegion = new BO.Region((Consultation)bindingSourceRegion.Current);
                _RecordedSelection = new Selection(_RecordedSociete, _RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJours);
                labelPreferenceRegion.Text = _RecordedSelection.MyRegion.Nom;
                this.FillingDataGridView(_RecordedSelection);
            }
        }

        private void bindingSourceContrat_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourceContrat.Current != null && _RecordedSelection != null)
            {
                _RecordedContrat = new Contrat((Consultation)bindingSourceContrat.Current);
                _RecordedSelection = new Selection(_RecordedSociete, _RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJours);
                labelPreferenceContrat.Text = _RecordedSelection.MyContrat.Nom;
                this.FillingDataGridView(_RecordedSelection);
            }
        }

        private void bindingSourcePoste_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bindingSourcePoste.Current != null && _RecordedSelection != null)
            {
                _RecordedPoste = new Poste((Consultation)bindingSourcePoste.Current);
                _RecordedSelection = new Selection(_RecordedSociete, _RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJours);
                labelPreferencePoste.Text = _RecordedSelection.MyPoste.Nom;
                this.FillingDataGridView(_RecordedSelection);
            }
        }

        private void comboBoxJours_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxJours.SelectedValue != null && _RecordedSelection != null)
            {
                _RecordedJours = (comboBoxJours.SelectedValue.ToString() != _Jours.First()) ? Convert.ToInt32(comboBoxJours.SelectedValue) : 0;

                _RecordedSelection = new Selection(_RecordedSociete,_RecordedPoste, _RecordedRegion, _RecordedContrat, _RecordedJours);
                labelPreferenceJours.Text = (_RecordedSelection.NbrJour != 0) ? _RecordedSelection.NbrJour.ToString() : _Jours.First();
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
                labelResultat.Text = ERREUR;
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
                        labelResultat.Text = ConstructAction(MODIFIE);
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
                    labelResultat.Text = ConstructAction(CREE);
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
                        labelResultat.Text = ConstructAction(SUPPRIMEE);
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
                _Preference = new Selection();
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
            _Preference = new Selection();
            this.FillingPreference(_Preference);

        }
        private Selection GetPreference()
        {
            if (File.Exists(PREFERENCEFILE))
            {
                Stream fichier = File.OpenRead(PREFERENCEFILE);
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
    }
}

