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
    public partial class frmListeCartes : MetroFramework.Forms.MetroForm
    {
        public int idmap;
        ynovprojetEntities testcontext = new ynovprojetEntities();
        public frmListeCartes()
        {
            InitializeComponent();
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void frmListeCartes_Load(object sender, EventArgs e)
        {
            cbxMap.DataSource = testcontext.map.Select(c => new { Num = c.id, Nom = c.nom_map }).ToList(); //charge toutes les cartes de la bdd
            cbxMap.DisplayMember = "Nom";
            cbxMap.ValueMember = "Num";
            cbxMap.Text = "--Nom de la map--";
        }

        private void pct_Retour_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            String idmapstring;
            idmapstring = cbxMap.SelectedValue.ToString();
            idmap = Convert.ToInt32(idmapstring);

            var map = testcontext.map.Where(p => p.id == idmap);

          

            foreach (var carte in map)
            {

                testcontext.map.Remove(carte);
            }
            testcontext.SaveChanges();
            cbxMap.DataSource = testcontext.map.Select(c => new { Num = c.id, Nom = c.nom_map }).ToList();
            cbxMap.DisplayMember = "Nom";
            cbxMap.ValueMember = "Num";
            cbxMap.Text = "--Nom de la map--";


        }

        private void cbxMap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
