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
    public partial class frmAdministration : MetroFramework.Forms.MetroForm
    {
        public frmAdministration()
        {
            InitializeComponent();
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
            frmListeCartes frmListeCartes = new frmListeCartes();
            frmListeCartes.Show();
            this.Hide();
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            frmUtilisateur frmUtilisateur = new frmUtilisateur();
            frmUtilisateur.Show();
            this.Hide();

        }
    }
}