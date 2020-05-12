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
    public partial class frmInfoMap : MetroFramework.Forms.MetroForm
    {
        public int idmap;
        ynovprojetEntities testcontext = new ynovprojetEntities();
        public frmInfoMap()
        {
            InitializeComponent();
            idmap = frmJouer.idmap;
            lblMur.Text = "Nombre de murs : " + testcontext.casemap.Where(c => c.id_map == idmap && c.mur == false).Count().ToString();
            lblObstacle.Text = "Nombre d'obstacles : " + testcontext.casemap.Where(c => c.id_map == idmap && c.boue == true).Count().ToString();
            lblPiege.Text = "Nombre de pièges : " + testcontext.casemap.Where(c => c.id_map == idmap && c.piege == true).Count().ToString();

            //lblResultat.Text = "Résultat du dernier test : " + testcontext.test.Where(c => c.id_map == idmap).Select(c => c.resultat).ToString();
            //lblDate.Text = "Date du dernier test : " + testcontext.test.Where(c => c.id_map == idmap).Select(c => c.date).ToString();
        }

    }
}
