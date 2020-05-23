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
            lblResultat.Text = "Résultat du parcours : " + frmEditeur.resultat + Environment.NewLine + "Le parcours traverse " + frmEditeur.nbBoueinParcours + " case.s de boue." + Environment.NewLine + "Le parcours total comptabilise " + frmEditeur.nbCaseParcours + " cases."; //récupere les infos du parcours et les affichent
        }

    }
}
