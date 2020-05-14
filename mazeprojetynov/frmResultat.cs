using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mazeprojetynov
{
    public partial class frmResultat : MetroFramework.Forms.MetroForm
    {
        public string resultat;
        public frmResultat()
        {
            InitializeComponent();
            lblResultat.Text = "Le parcours est : " + frmEditeur.resultat;
        }

    }
}
