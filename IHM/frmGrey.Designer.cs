namespace IHM
{
    partial class frmGrey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSourceOffre = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceRegion = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceContrat = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourcePoste = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.checkBoxPreference = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxContrat = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxPoste = new MetroFramework.Controls.MetroComboBox();
            this.labelPoste = new System.Windows.Forms.Label();
            this.comboBoxRegion = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSociete = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxJour = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewOffre = new MetroFramework.Controls.MetroGrid();
            this.panelPreference = new System.Windows.Forms.Panel();
            this.buttonRecuperer = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.labelPreferenceSociete = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.buttonReinitialiser = new System.Windows.Forms.Button();
            this.labelPreferenceJours = new System.Windows.Forms.Label();
            this.labelPreferencePoste = new System.Windows.Forms.Label();
            this.labelPreferenceContrat = new System.Windows.Forms.Label();
            this.labelPreferenceRegion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSelection = new System.Windows.Forms.Label();
            this.labelAction = new System.Windows.Forms.Label();
            this.bindingSourceSociete = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceJour = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOffre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceContrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePoste)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffre)).BeginInit();
            this.panelPreference.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSociete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceJour)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceOffre
            // 
            this.bindingSourceOffre.CurrentItemChanged += new System.EventHandler(this.bindingSourceOffre_CurrentItemChanged);
            // 
            // bindingSourceRegion
            // 
            this.bindingSourceRegion.CurrentItemChanged += new System.EventHandler(this.bindingSourceRegion_CurrentItemChanged);
            // 
            // bindingSourceContrat
            // 
            this.bindingSourceContrat.CurrentItemChanged += new System.EventHandler(this.bindingSourceContrat_CurrentItemChanged);
            // 
            // bindingSourcePoste
            // 
            this.bindingSourcePoste.CurrentItemChanged += new System.EventHandler(this.bindingSourcePoste_CurrentItemChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 538);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 538);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel2.ColumnCount = 14;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonDelete, 10, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonUpdate, 8, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonInsert, 9, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonSelect, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxPreference, 12, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxContrat, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxPoste, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelPoste, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxRegion, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxSociete, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxJour, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1082, 57);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.BackgroundImage = global::IHM.Properties.Resources.deleteRed;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(924, 26);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.SetRowSpan(this.buttonDelete, 2);
            this.buttonDelete.Size = new System.Drawing.Size(26, 21);
            this.buttonDelete.TabIndex = 8;
            this.toolTip.SetToolTip(this.buttonDelete, "Supprimer l\'offre sélectionnée");
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.White;
            this.buttonUpdate.BackgroundImage = global::IHM.Properties.Resources.updateYellow;
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Location = new System.Drawing.Point(864, 26);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.SetRowSpan(this.buttonUpdate, 2);
            this.buttonUpdate.Size = new System.Drawing.Size(26, 21);
            this.buttonUpdate.TabIndex = 7;
            this.toolTip.SetToolTip(this.buttonUpdate, "Modifier l\'offre sélectionnée");
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.White;
            this.buttonInsert.BackgroundImage = global::IHM.Properties.Resources.insertGreen;
            this.buttonInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInsert.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonInsert.FlatAppearance.BorderSize = 0;
            this.buttonInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsert.Location = new System.Drawing.Point(894, 26);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.SetRowSpan(this.buttonInsert, 2);
            this.buttonInsert.Size = new System.Drawing.Size(26, 21);
            this.buttonInsert.TabIndex = 9;
            this.toolTip.SetToolTip(this.buttonInsert, "Créer une nouvelle offre");
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.White;
            this.buttonSelect.BackgroundImage = global::IHM.Properties.Resources.selectBlue;
            this.buttonSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSelect.Location = new System.Drawing.Point(834, 26);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.SetRowSpan(this.buttonSelect, 2);
            this.buttonSelect.Size = new System.Drawing.Size(26, 21);
            this.buttonSelect.TabIndex = 6;
            this.toolTip.SetToolTip(this.buttonSelect, "Visualiser l\'offre sélectionnée");
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // checkBoxPreference
            // 
            this.checkBoxPreference.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBoxPreference.AutoSize = true;
            this.checkBoxPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPreference.ForeColor = System.Drawing.Color.Indigo;
            this.checkBoxPreference.Location = new System.Drawing.Point(965, 27);
            this.checkBoxPreference.Name = "checkBoxPreference";
            this.checkBoxPreference.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel2.SetRowSpan(this.checkBoxPreference, 2);
            this.checkBoxPreference.Size = new System.Drawing.Size(111, 19);
            this.checkBoxPreference.TabIndex = 17;
            this.checkBoxPreference.Text = "Préferences";
            this.checkBoxPreference.UseVisualStyleBackColor = true;
            this.checkBoxPreference.CheckedChanged += new System.EventHandler(this.checkBoxPreference_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(650, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Contrat";
            // 
            // comboBoxContrat
            // 
            this.comboBoxContrat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxContrat.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBoxContrat.FormattingEnabled = true;
            this.comboBoxContrat.ItemHeight = 19;
            this.comboBoxContrat.Location = new System.Drawing.Point(650, 27);
            this.comboBoxContrat.Name = "comboBoxContrat";
            this.comboBoxContrat.Size = new System.Drawing.Size(169, 25);
            this.comboBoxContrat.Style = MetroFramework.MetroColorStyle.Silver;
            this.comboBoxContrat.TabIndex = 11;
            this.comboBoxContrat.UseSelectable = true;
            // 
            // comboBoxPoste
            // 
            this.comboBoxPoste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxPoste.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBoxPoste.FormattingEnabled = true;
            this.comboBoxPoste.ItemHeight = 19;
            this.comboBoxPoste.Location = new System.Drawing.Point(475, 27);
            this.comboBoxPoste.Name = "comboBoxPoste";
            this.comboBoxPoste.Size = new System.Drawing.Size(169, 25);
            this.comboBoxPoste.Style = MetroFramework.MetroColorStyle.Silver;
            this.comboBoxPoste.TabIndex = 12;
            this.comboBoxPoste.UseSelectable = true;
            // 
            // labelPoste
            // 
            this.labelPoste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPoste.AutoSize = true;
            this.labelPoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoste.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelPoste.Location = new System.Drawing.Point(475, 8);
            this.labelPoste.Name = "labelPoste";
            this.labelPoste.Size = new System.Drawing.Size(48, 16);
            this.labelPoste.TabIndex = 5;
            this.labelPoste.Text = "Poste";
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxRegion.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.ItemHeight = 19;
            this.comboBoxRegion.Location = new System.Drawing.Point(300, 27);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(169, 25);
            this.comboBoxRegion.Style = MetroFramework.MetroColorStyle.Silver;
            this.comboBoxRegion.TabIndex = 10;
            this.comboBoxRegion.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(300, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Région";
            // 
            // comboBoxSociete
            // 
            this.comboBoxSociete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSociete.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBoxSociete.FormattingEnabled = true;
            this.comboBoxSociete.ItemHeight = 19;
            this.comboBoxSociete.Location = new System.Drawing.Point(125, 27);
            this.comboBoxSociete.Name = "comboBoxSociete";
            this.comboBoxSociete.Size = new System.Drawing.Size(169, 25);
            this.comboBoxSociete.Style = MetroFramework.MetroColorStyle.Silver;
            this.comboBoxSociete.TabIndex = 19;
            this.comboBoxSociete.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(125, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Société";
            // 
            // comboBoxJour
            // 
            this.comboBoxJour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxJour.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBoxJour.FormattingEnabled = true;
            this.comboBoxJour.ItemHeight = 19;
            this.comboBoxJour.Location = new System.Drawing.Point(5, 27);
            this.comboBoxJour.Name = "comboBoxJour";
            this.comboBoxJour.Size = new System.Drawing.Size(114, 25);
            this.comboBoxJour.Style = MetroFramework.MetroColorStyle.Silver;
            this.comboBoxJour.TabIndex = 13;
            this.comboBoxJour.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(5, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nb Jours";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewOffre, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelPreference, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 105);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1082, 407);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dataGridViewOffre
            // 
            this.dataGridViewOffre.AllowUserToAddRows = false;
            this.dataGridViewOffre.AllowUserToDeleteRows = false;
            this.dataGridViewOffre.AllowUserToResizeRows = false;
            this.dataGridViewOffre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOffre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewOffre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOffre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewOffre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOffre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOffre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOffre.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOffre.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewOffre.EnableHeadersVisualStyles = false;
            this.dataGridViewOffre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewOffre.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewOffre.Location = new System.Drawing.Point(219, 20);
            this.dataGridViewOffre.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.dataGridViewOffre.MultiSelect = false;
            this.dataGridViewOffre.Name = "dataGridViewOffre";
            this.dataGridViewOffre.ReadOnly = true;
            this.dataGridViewOffre.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOffre.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOffre.RowHeadersVisible = false;
            this.dataGridViewOffre.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewOffre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOffre.Size = new System.Drawing.Size(643, 343);
            this.dataGridViewOffre.Style = MetroFramework.MetroColorStyle.Silver;
            this.dataGridViewOffre.TabIndex = 0;
            // 
            // panelPreference
            // 
            this.panelPreference.Controls.Add(this.buttonRecuperer);
            this.panelPreference.Controls.Add(this.buttonSupprimer);
            this.panelPreference.Controls.Add(this.labelPreferenceSociete);
            this.panelPreference.Controls.Add(this.label3);
            this.panelPreference.Controls.Add(this.buttonEnregistrer);
            this.panelPreference.Controls.Add(this.buttonReinitialiser);
            this.panelPreference.Controls.Add(this.labelPreferenceJours);
            this.panelPreference.Controls.Add(this.labelPreferencePoste);
            this.panelPreference.Controls.Add(this.labelPreferenceContrat);
            this.panelPreference.Controls.Add(this.labelPreferenceRegion);
            this.panelPreference.Controls.Add(this.label9);
            this.panelPreference.Controls.Add(this.label8);
            this.panelPreference.Controls.Add(this.label7);
            this.panelPreference.Controls.Add(this.label6);
            this.panelPreference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPreference.Location = new System.Drawing.Point(868, 3);
            this.panelPreference.Name = "panelPreference";
            this.panelPreference.Size = new System.Drawing.Size(211, 401);
            this.panelPreference.TabIndex = 2;
            // 
            // buttonRecuperer
            // 
            this.buttonRecuperer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRecuperer.BackColor = System.Drawing.Color.Thistle;
            this.buttonRecuperer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRecuperer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecuperer.ForeColor = System.Drawing.Color.Indigo;
            this.buttonRecuperer.Location = new System.Drawing.Point(19, 180);
            this.buttonRecuperer.Name = "buttonRecuperer";
            this.buttonRecuperer.Size = new System.Drawing.Size(86, 23);
            this.buttonRecuperer.TabIndex = 30;
            this.buttonRecuperer.Text = "Récupérer";
            this.toolTip.SetToolTip(this.buttonRecuperer, "Récupérer les préferences enregistrées");
            this.buttonRecuperer.UseVisualStyleBackColor = false;
            this.buttonRecuperer.Click += new System.EventHandler(this.buttonRecuperer_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSupprimer.BackColor = System.Drawing.Color.Thistle;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.Color.Indigo;
            this.buttonSupprimer.Location = new System.Drawing.Point(111, 180);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(84, 23);
            this.buttonSupprimer.TabIndex = 29;
            this.buttonSupprimer.Text = "Supprimer";
            this.toolTip.SetToolTip(this.buttonSupprimer, "Supprimer les préferences enregistrées");
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // labelPreferenceSociete
            // 
            this.labelPreferenceSociete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPreferenceSociete.AutoSize = true;
            this.labelPreferenceSociete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreferenceSociete.ForeColor = System.Drawing.Color.Orchid;
            this.labelPreferenceSociete.Location = new System.Drawing.Point(95, 82);
            this.labelPreferenceSociete.Name = "labelPreferenceSociete";
            this.labelPreferenceSociete.Size = new System.Drawing.Size(48, 15);
            this.labelPreferenceSociete.TabIndex = 28;
            this.labelPreferenceSociete.Text = "Société";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(30, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Société:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEnregistrer.BackColor = System.Drawing.Color.Thistle;
            this.buttonEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnregistrer.ForeColor = System.Drawing.Color.Indigo;
            this.buttonEnregistrer.Location = new System.Drawing.Point(111, 21);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(84, 23);
            this.buttonEnregistrer.TabIndex = 26;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.toolTip.SetToolTip(this.buttonEnregistrer, "Enregistrer les préferences sélectionnées");
            this.buttonEnregistrer.UseVisualStyleBackColor = false;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // buttonReinitialiser
            // 
            this.buttonReinitialiser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonReinitialiser.BackColor = System.Drawing.Color.Thistle;
            this.buttonReinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReinitialiser.ForeColor = System.Drawing.Color.Indigo;
            this.buttonReinitialiser.Location = new System.Drawing.Point(19, 21);
            this.buttonReinitialiser.Name = "buttonReinitialiser";
            this.buttonReinitialiser.Size = new System.Drawing.Size(86, 23);
            this.buttonReinitialiser.TabIndex = 25;
            this.buttonReinitialiser.Text = "Réinitialiser";
            this.toolTip.SetToolTip(this.buttonReinitialiser, "Réinitialiser les préferences sélectionnées");
            this.buttonReinitialiser.UseVisualStyleBackColor = false;
            this.buttonReinitialiser.Click += new System.EventHandler(this.buttonReinitialiser_Click);
            // 
            // labelPreferenceJours
            // 
            this.labelPreferenceJours.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPreferenceJours.AutoSize = true;
            this.labelPreferenceJours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreferenceJours.ForeColor = System.Drawing.Color.Orchid;
            this.labelPreferenceJours.Location = new System.Drawing.Point(95, 60);
            this.labelPreferenceJours.Name = "labelPreferenceJours";
            this.labelPreferenceJours.Size = new System.Drawing.Size(37, 15);
            this.labelPreferenceJours.TabIndex = 24;
            this.labelPreferenceJours.Text = "Jours";
            // 
            // labelPreferencePoste
            // 
            this.labelPreferencePoste.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPreferencePoste.AutoSize = true;
            this.labelPreferencePoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreferencePoste.ForeColor = System.Drawing.Color.Orchid;
            this.labelPreferencePoste.Location = new System.Drawing.Point(97, 126);
            this.labelPreferencePoste.Name = "labelPreferencePoste";
            this.labelPreferencePoste.Size = new System.Drawing.Size(38, 15);
            this.labelPreferencePoste.TabIndex = 23;
            this.labelPreferencePoste.Text = "Poste";
            // 
            // labelPreferenceContrat
            // 
            this.labelPreferenceContrat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPreferenceContrat.AutoSize = true;
            this.labelPreferenceContrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreferenceContrat.ForeColor = System.Drawing.Color.Orchid;
            this.labelPreferenceContrat.Location = new System.Drawing.Point(95, 149);
            this.labelPreferenceContrat.Name = "labelPreferenceContrat";
            this.labelPreferenceContrat.Size = new System.Drawing.Size(46, 15);
            this.labelPreferenceContrat.TabIndex = 22;
            this.labelPreferenceContrat.Text = "Contrat";
            // 
            // labelPreferenceRegion
            // 
            this.labelPreferenceRegion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPreferenceRegion.AutoSize = true;
            this.labelPreferenceRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreferenceRegion.ForeColor = System.Drawing.Color.Orchid;
            this.labelPreferenceRegion.Location = new System.Drawing.Point(95, 104);
            this.labelPreferenceRegion.Name = "labelPreferenceRegion";
            this.labelPreferenceRegion.Size = new System.Drawing.Size(47, 15);
            this.labelPreferenceRegion.TabIndex = 21;
            this.labelPreferenceRegion.Text = "Région";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label9.Location = new System.Drawing.Point(23, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nb Jours:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label8.Location = new System.Drawing.Point(40, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Poste:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(32, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Contrat:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(32, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Région:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.labelSelection, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelAction, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 512);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1082, 26);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // labelSelection
            // 
            this.labelSelection.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSelection.AutoSize = true;
            this.labelSelection.BackColor = System.Drawing.Color.Transparent;
            this.labelSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSelection.Location = new System.Drawing.Point(1009, 3);
            this.labelSelection.Name = "labelSelection";
            this.labelSelection.Size = new System.Drawing.Size(70, 20);
            this.labelSelection.TabIndex = 17;
            this.labelSelection.Text = "résultat";
            // 
            // labelAction
            // 
            this.labelAction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAction.AutoSize = true;
            this.labelAction.BackColor = System.Drawing.Color.Transparent;
            this.labelAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAction.Location = new System.Drawing.Point(3, 3);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(70, 20);
            this.labelAction.TabIndex = 18;
            this.labelAction.Text = "résultat";
            this.labelAction.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bindingSourceSociete
            // 
            this.bindingSourceSociete.CurrentItemChanged += new System.EventHandler(this.bindingSourceSociete_CurrentItemChanged);
            // 
            // bindingSourceJour
            // 
            this.bindingSourceJour.CurrentItemChanged += new System.EventHandler(this.bindingSourceJour_CurrentItemChanged);
            // 
            // frmGrey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1094, 626);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1094, 626);
            this.Name = "frmGrey";
            this.Padding = new System.Windows.Forms.Padding(6, 60, 6, 28);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Visualisation";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOffre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceContrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePoste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffre)).EndInit();
            this.panelPreference.ResumeLayout(false);
            this.panelPreference.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSociete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceJour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSourceOffre;
        private System.Windows.Forms.BindingSource bindingSourceRegion;
        private System.Windows.Forms.BindingSource bindingSourceContrat;
        private System.Windows.Forms.BindingSource bindingSourcePoste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelPoste;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroGrid dataGridViewOffre;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonSelect;
        private MetroFramework.Controls.MetroComboBox comboBoxRegion;
        private MetroFramework.Controls.MetroComboBox comboBoxContrat;
        private MetroFramework.Controls.MetroComboBox comboBoxPoste;
        private MetroFramework.Controls.MetroComboBox comboBoxJour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxPreference;
        private System.Windows.Forms.Panel panelPreference;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Button buttonReinitialiser;
        private System.Windows.Forms.Label labelPreferenceJours;
        private System.Windows.Forms.Label labelPreferencePoste;
        private System.Windows.Forms.Label labelPreferenceContrat;
        private System.Windows.Forms.Label labelPreferenceRegion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox comboBoxSociete;
        private System.Windows.Forms.BindingSource bindingSourceSociete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPreferenceSociete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.BindingSource bindingSourceJour;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonRecuperer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelSelection;
        private System.Windows.Forms.Label labelAction;
    }
}