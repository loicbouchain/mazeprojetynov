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
    public partial class frmSupprimerUtilisateur : MetroFramework.Forms.MetroForm
    {
        public int id;
        ynovprojetEntities testcontext = new ynovprojetEntities();
        public user user;
        public int iduser;
       
        public frmSupprimerUtilisateur()
        {
            InitializeComponent();
            iduser = frmLogin.iduser;
            cbxUser.DataSource = testcontext.user.Select(c => new { Num = c.id, Nom = c.user_name, password = c.user_mdp }).ToList();
            cbxUser.DisplayMember = "Nom";
            cbxUser.ValueMember = "Num";
            cbxUser.Text = "--Nom de la map--";

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            String iduserstring;
            iduserstring = cbxUser.SelectedValue.ToString();
            id = Convert.ToInt32(iduserstring);

            var map = testcontext.user.Where(p => p.id == id);



            foreach (var carte in map)
            {
                if (carte.id != frmLogin.iduser)
                {
                    testcontext.user.Remove(carte);
                    lblError.Text = "";
                }
                else
                {
                    lblError.Text = "Vous ne pouvez pas vous supprimer";
                }
            }

            testcontext.SaveChanges();
            cbxUser.DataSource = testcontext.user.Select(c => new { Num = c.id, Nom = c.user_name }).ToList();
            cbxUser.DisplayMember = "Nom";
            cbxUser.ValueMember = "Num";
            cbxUser.Text = "--Nom de la map--";
        }
    }
}
