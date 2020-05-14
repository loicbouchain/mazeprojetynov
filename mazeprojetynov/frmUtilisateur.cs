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
    public partial class frmUtilisateur : MetroFramework.Forms.MetroForm
    {
        public frmUtilisateur()
        {
            InitializeComponent();
        }

        private void pctUpdate_Click(object sender, EventArgs e)
        {
            frmModifierUtilisateur frmModifierUtilisateur = new frmModifierUtilisateur();
            frmModifierUtilisateur.Show();

        }

        private void pctAdd_Click(object sender, EventArgs e)
        {
            frmAjouterUtilisateur frmAjouterUtilisateur = new frmAjouterUtilisateur();
            frmAjouterUtilisateur.Show();
          
        }

        private void pctRemove_Click(object sender, EventArgs e)
        {
            frmSupprimerUtilisateur frmSupprimerUtilisateur = new frmSupprimerUtilisateur();
            frmSupprimerUtilisateur.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pct_Retour_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();

        }
    }
}
