namespace JobChannelApplication
{
    partial class FenAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablePrincipale = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tablePrincipale
            // 
            this.tablePrincipale.ColumnCount = 1;
            this.tablePrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePrincipale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePrincipale.Location = new System.Drawing.Point(8, 8);
            this.tablePrincipale.Margin = new System.Windows.Forms.Padding(0);
            this.tablePrincipale.Name = "tablePrincipale";
            this.tablePrincipale.RowCount = 2;
            this.tablePrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tablePrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePrincipale.Size = new System.Drawing.Size(760, 562);
            this.tablePrincipale.TabIndex = 0;
            // 
            // FenAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 578);
            this.Controls.Add(this.tablePrincipale);
            this.Name = "FenAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePrincipale;
    }
}

