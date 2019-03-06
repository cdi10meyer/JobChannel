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
    public partial class frmBlack : MetroForm
    {
        public frmBlack(string message)
        {
            InitializeComponent();
            tbError.TextAlign = HorizontalAlignment.Center;
            tbError.Text = message;
        }
    }
}
