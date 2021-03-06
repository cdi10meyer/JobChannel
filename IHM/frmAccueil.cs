﻿using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace IHM
{
    public partial class frmAccueil : MetroForm
    {
        
        public frmAccueil() : base()
        {
            InitializeComponent();
            try
            {
                labelTitre.Text = $"{UserPrincipal.Current.GivenName} {UserPrincipal.Current.Surname}";
            }
            catch (Exception e)
            {
                using (frmBlack fenetre = new frmBlack(e.Message))
                {
                    this.Opacity = 0.75;
                    fenetre.ShowDialog();
                }
                this.Opacity = 1;
            }
        }


        private void btnVisualiser_Click(object sender, EventArgs e)
        {
            using (frmGrey fenetre = new frmGrey())
            {
                this.Opacity = 0.75;
                fenetre.ShowDialog();
            }
            this.Opacity = 1;
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            using (frmGreen fenetre = new frmGreen())
            {
                this.Opacity = 0.5;
                fenetre.ShowDialog();
            }
            this.Opacity = 1;
        }
    }
}
