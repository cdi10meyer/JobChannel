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
            this.labelResultat = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRegion = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxContrat = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxPoste = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxJours = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxPreference = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewOffre = new MetroFramework.Controls.MetroGrid();
            this.panelPreference = new System.Windows.Forms.Panel();
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
            this.panel1.Size = new System.Drawing.Size(1085, 517);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelResultat, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1085, 517);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelResultat
            // 
            this.labelResultat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelResultat.AutoSize = true;
            this.labelResultat.BackColor = System.Drawing.Color.Transparent;
            this.labelResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelResultat.Location = new System.Drawing.Point(1012, 494);
            this.labelResultat.Name = "labelResultat";
            this.labelResultat.Size = new System.Drawing.Size(70, 20);
            this.labelResultat.TabIndex = 16;
            this.labelResultat.Text = "résultat";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel2.ColumnCount = 11;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.buttonDelete, 9, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonUpdate, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonInsert, 8, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonSelect, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxRegion, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxContrat, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxPoste, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxJours, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxPreference, 10, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1085, 57);
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
            this.buttonDelete.Location = new System.Drawing.Point(936, 30);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.SetRowSpan(this.buttonDelete, 2);
            this.buttonDelete.Size = new System.Drawing.Size(26, 25);
            this.buttonDelete.TabIndex = 8;
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
            this.buttonUpdate.Location = new System.Drawing.Point(876, 30);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.SetRowSpan(this.buttonUpdate, 2);
            this.buttonUpdate.Size = new System.Drawing.Size(26, 25);
            this.buttonUpdate.TabIndex = 7;
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
            this.buttonInsert.Location = new System.Drawing.Point(906, 30);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.SetRowSpan(this.buttonInsert, 2);
            this.buttonInsert.Size = new System.Drawing.Size(26, 25);
            this.buttonInsert.TabIndex = 9;
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
            this.buttonSelect.Location = new System.Drawing.Point(846, 30);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.SetRowSpan(this.buttonSelect, 2);
            this.buttonSelect.Size = new System.Drawing.Size(26, 25);
            this.buttonSelect.TabIndex = 6;
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(297, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contrat";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(472, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Poste";
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxRegion.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.ItemHeight = 19;
            this.comboBoxRegion.Location = new System.Drawing.Point(122, 31);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(169, 25);
            this.comboBoxRegion.Style = MetroFramework.MetroColorStyle.Silver;
            this.comboBoxRegion.TabIndex = 10;
            this.comboBoxRegion.UseSelectable = true;
            // 
            // comboBoxContrat
            // 
            this.comboBoxContrat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxContrat.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBoxContrat.FormattingEnabled = true;
            this.comboBoxContrat.ItemHeight = 19;
            this.comboBoxContrat.Location = new System.Drawing.Point(297, 31);
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
            this.comboBoxPoste.Location = new System.Drawing.Point(472, 31);
            this.comboBoxPoste.Name = "comboBoxPoste";
            this.comboBoxPoste.Size = new System.Drawing.Size(169, 25);
            this.comboBoxPoste.Style = MetroFramework.MetroColorStyle.Silver;
            this.comboBoxPoste.TabIndex = 12;
            this.comboBoxPoste.UseSelectable = true;
            // 
            // comboBoxJours
            // 
            this.comboBoxJours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxJours.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBoxJours.FormattingEnabled = true;
            this.comboBoxJours.ItemHeight = 19;
            this.comboBoxJours.Location = new System.Drawing.Point(647, 31);
            this.comboBoxJours.Name = "comboBoxJours";
            this.comboBoxJours.Size = new System.Drawing.Size(74, 25);
            this.comboBoxJours.Style = MetroFramework.MetroColorStyle.Silver;
            this.comboBoxJours.TabIndex = 13;
            this.comboBoxJours.UseSelectable = true;
            this.comboBoxJours.SelectedValueChanged += new System.EventHandler(this.comboBoxJours_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(647, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Jours";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(122, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Région";
            // 
            // checkBoxPreference
            // 
            this.checkBoxPreference.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBoxPreference.AutoSize = true;
            this.checkBoxPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPreference.ForeColor = System.Drawing.Color.Indigo;
            this.checkBoxPreference.Location = new System.Drawing.Point(969, 34);
            this.checkBoxPreference.Name = "checkBoxPreference";
            this.checkBoxPreference.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel2.SetRowSpan(this.checkBoxPreference, 2);
            this.checkBoxPreference.Size = new System.Drawing.Size(111, 20);
            this.checkBoxPreference.TabIndex = 17;
            this.checkBoxPreference.Text = "Préferences";
            this.checkBoxPreference.UseVisualStyleBackColor = true;
            this.checkBoxPreference.CheckedChanged += new System.EventHandler(this.checkBoxPreference_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewOffre, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelPreference, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 105);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1085, 386);
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
            this.dataGridViewOffre.Location = new System.Drawing.Point(245, 3);
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
            this.dataGridViewOffre.Size = new System.Drawing.Size(594, 343);
            this.dataGridViewOffre.Style = MetroFramework.MetroColorStyle.Silver;
            this.dataGridViewOffre.TabIndex = 0;
            // 
            // panelPreference
            // 
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
            this.panelPreference.Location = new System.Drawing.Point(845, 3);
            this.panelPreference.Name = "panelPreference";
            this.panelPreference.Size = new System.Drawing.Size(237, 380);
            this.panelPreference.TabIndex = 2;
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.BackColor = System.Drawing.Color.Thistle;
            this.buttonEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnregistrer.ForeColor = System.Drawing.Color.Indigo;
            this.buttonEnregistrer.Location = new System.Drawing.Point(123, 123);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(84, 23);
            this.buttonEnregistrer.TabIndex = 26;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = false;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // buttonReinitialiser
            // 
            this.buttonReinitialiser.BackColor = System.Drawing.Color.Thistle;
            this.buttonReinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReinitialiser.ForeColor = System.Drawing.Color.Indigo;
            this.buttonReinitialiser.Location = new System.Drawing.Point(32, 123);
            this.buttonReinitialiser.Name = "buttonReinitialiser";
            this.buttonReinitialiser.Size = new System.Drawing.Size(86, 23);
            this.buttonReinitialiser.TabIndex = 25;
            this.buttonReinitialiser.Text = "Reinitialiser";
            this.buttonReinitialiser.UseVisualStyleBackColor = false;
            this.buttonReinitialiser.Click += new System.EventHandler(this.buttonReinitialiser_Click);
            // 
            // labelPreferenceJours
            // 
            this.labelPreferenceJours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPreferenceJours.AutoSize = true;
            this.labelPreferenceJours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreferenceJours.ForeColor = System.Drawing.Color.Orchid;
            this.labelPreferenceJours.Location = new System.Drawing.Point(88, 78);
            this.labelPreferenceJours.Name = "labelPreferenceJours";
            this.labelPreferenceJours.Size = new System.Drawing.Size(37, 15);
            this.labelPreferenceJours.TabIndex = 24;
            this.labelPreferenceJours.Text = "Jours";
            // 
            // labelPreferencePoste
            // 
            this.labelPreferencePoste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPreferencePoste.AutoSize = true;
            this.labelPreferencePoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreferencePoste.ForeColor = System.Drawing.Color.Orchid;
            this.labelPreferencePoste.Location = new System.Drawing.Point(88, 55);
            this.labelPreferencePoste.Name = "labelPreferencePoste";
            this.labelPreferencePoste.Size = new System.Drawing.Size(38, 15);
            this.labelPreferencePoste.TabIndex = 23;
            this.labelPreferencePoste.Text = "Poste";
            // 
            // labelPreferenceContrat
            // 
            this.labelPreferenceContrat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPreferenceContrat.AutoSize = true;
            this.labelPreferenceContrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreferenceContrat.ForeColor = System.Drawing.Color.Orchid;
            this.labelPreferenceContrat.Location = new System.Drawing.Point(88, 31);
            this.labelPreferenceContrat.Name = "labelPreferenceContrat";
            this.labelPreferenceContrat.Size = new System.Drawing.Size(46, 15);
            this.labelPreferenceContrat.TabIndex = 22;
            this.labelPreferenceContrat.Text = "Contrat";
            // 
            // labelPreferenceRegion
            // 
            this.labelPreferenceRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPreferenceRegion.AutoSize = true;
            this.labelPreferenceRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreferenceRegion.ForeColor = System.Drawing.Color.Orchid;
            this.labelPreferenceRegion.Location = new System.Drawing.Point(88, 9);
            this.labelPreferenceRegion.Name = "labelPreferenceRegion";
            this.labelPreferenceRegion.Size = new System.Drawing.Size(47, 15);
            this.labelPreferenceRegion.TabIndex = 21;
            this.labelPreferenceRegion.Text = "Région";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(34, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Jours:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(32, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Poste:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(25, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Contrat:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(25, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Région:";
            // 
            // frmGrey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1097, 605);
            this.Controls.Add(this.panel1);
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
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffre)).EndInit();
            this.panelPreference.ResumeLayout(false);
            this.panelPreference.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSourceOffre;
        private System.Windows.Forms.BindingSource bindingSourceRegion;
        private System.Windows.Forms.BindingSource bindingSourceContrat;
        private System.Windows.Forms.BindingSource bindingSourcePoste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelResultat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroGrid dataGridViewOffre;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonSelect;
        private MetroFramework.Controls.MetroComboBox comboBoxRegion;
        private MetroFramework.Controls.MetroComboBox comboBoxContrat;
        private MetroFramework.Controls.MetroComboBox comboBoxPoste;
        private MetroFramework.Controls.MetroComboBox comboBoxJours;
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
    }
}