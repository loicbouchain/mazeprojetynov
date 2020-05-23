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
    public partial class frmModifierUtilisateur : MetroFramework.Forms.MetroForm
    {
        public int id;
        ynovprojetEntities testcontext = new ynovprojetEntities();
        public user user;
        public Hashing hash;
        public frmModifierUtilisateur()
        {
            InitializeComponent();
            cbxUser.DataSource = testcontext.user.Select(c => new { Num = c.id, Nom = c.user_name, password = c.user_mdp }).ToList(); //charge les utilisateur de la base
            cbxUser.DisplayMember = "Nom";
            cbxUser.ValueMember = "Num";
          
            cbxUser.Text = "--Nom de la map--";

        }

        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {
            hash = new Hashing();
            String iduserstring;
            iduserstring = cbxUser.SelectedValue.ToString();
            id = Convert.ToInt32(iduserstring);

            var user = testcontext.user.Where(p => p.id == id);
            foreach (var utilisateur in user)
            {
                utilisateur.user_name = txtBoxUsername.Text;
                utilisateur.user_mdp = hash.HashPassword(txtBoxPassword.Text);
            }

            testcontext.SaveChanges();
            cbxUser.DataSource = testcontext.user.Select(c => new { Num = c.id, Nom = c.user_name, password = c.user_mdp }).ToList();
            cbxUser.DisplayMember = "Nom";
            cbxUser.ValueMember = "Num";
            cbxUser.Text = "--Nom de la map--";
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            lblmdp.Visible = true;
            lblNom.Visible = true;
            txtBoxPassword.Visible = true;
            txtBoxUsername.Visible = true;
            btn_Enregistrer.Visible = true;

            String iduserstring;
            iduserstring = cbxUser.SelectedValue.ToString();
            id = Convert.ToInt32(iduserstring);

            var user = testcontext.user.Where(p => p.id == id); //modifie celui choisi
            foreach (var utilisateur in user)
            {
                txtBoxUsername.Text = utilisateur.user_name;
    
            }
        }
    }
}
