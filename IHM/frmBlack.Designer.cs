namespace IHM
{
    partial class frmBlack
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbError = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tbError);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(42, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 294);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackgroundImage = global::IHM.Properties.Resources.warning;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(71, 3);
            this.panel2.MaximumSize = new System.Drawing.Size(200, 178);
            this.panel2.MinimumSize = new System.Drawing.Size(200, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 178);
            this.panel2.TabIndex = 2;
            // 
            // tbError
            // 
            this.tbError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbError.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbError.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbError.Location = new System.Drawing.Point(28, 198);
            this.tbError.Multiline = true;
            this.tbError.Name = "tbError";
            this.tbError.ReadOnly = true;
            this.tbError.Size = new System.Drawing.Size(275, 85);
            this.tbError.TabIndex = 3;
            this.tbError.Text = "Message d\'erreur";
            // 
            // frmBlack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 369);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinimumSize = new System.Drawing.Size(279, 253);
            this.Name = "frmBlack";
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Erreur";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbError;
    }
}