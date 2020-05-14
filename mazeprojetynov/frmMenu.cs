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
    public partial class frmMenu : MetroFramework.Forms.MetroForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            frmJouer frmJouer = new frmJouer();
            frmJouer.Show();
            this.Hide();
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            frmEditeur frmEditeur = new frmEditeur();
            frmEditeur.Show();
            this.Hide();
        }

        private void btnRegles_Click(object sender, EventArgs e)
        {
            frmAdministration frmRegles = new frmAdministration();
            frmRegles.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
