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
    public partial class frmJouer : MetroFramework.Forms.MetroForm
    {
        public static int idmap;
        ynovprojetEntities testcontext = new ynovprojetEntities();
        public frmJouer()
        {
            InitializeComponent();
            cbxMap.DataSource = testcontext.map.Select(c => new { Num = c.id, Nom = c.nom_map }).ToList();
            cbxMap.DisplayMember = "Nom";
            cbxMap.ValueMember = "Num";
            cbxMap.Text = "--Nom de la map--";
            String idmapstring;
            idmapstring = cbxMap.SelectedValue.ToString();
            idmap = Convert.ToInt32(idmapstring);
            lblMur.Text = "Nombre de murs : " + testcontext.casemap.Where(c => c.id_map == idmap && c.mur == false).Count().ToString();
            lblObstacle.Text = "Nombre d'obstacles : " + testcontext.casemap.Where(c => c.id_map == idmap && c.boue == true).Count().ToString();
            lblPiege.Text = "Nombre de pièges : " + testcontext.casemap.Where(c => c.id_map == idmap && c.piege == true).Count().ToString();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {
            String idmapstring;
            idmapstring = cbxMap.SelectedValue.ToString();
            idmap = Convert.ToInt32(idmapstring);
            frmEditeur frmEditeur = new frmEditeur();
            frmEditeur.Show();
            this.Hide();
            
        }


        private void btnRaf_Click(object sender, EventArgs e)
        {
            String idmapstring;
            idmapstring = cbxMap.SelectedValue.ToString();
            idmap = Convert.ToInt32(idmapstring);
            lblMur.Text = "Nombre de murs : " + testcontext.casemap.Where(c => c.id_map == idmap && c.mur == false).Count().ToString();
            lblObstacle.Text = "Nombre d'obstacles : " + testcontext.casemap.Where(c => c.id_map == idmap && c.boue == true).Count().ToString();
            lblPiege.Text = "Nombre de pièges : " + testcontext.casemap.Where(c => c.id_map == idmap && c.piege == true).Count().ToString();
            frmInfoMap frmInfoMap = new frmInfoMap();
            frmInfoMap.Show();
        }
    }
}
