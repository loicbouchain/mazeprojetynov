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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public static int iduser;

        ynovprojetEntities testcontext = new ynovprojetEntities();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            var users = testcontext.user.Select(c => new { Num = c.id, username = c.user_name, password = c.user_mdp, role = c.role }).ToList();

            foreach (var utilisateur in users)
            {
                if (utilisateur.username == txtBox_username.Text)
                {
                    if (utilisateur.password == txtbox_password.Text)
                    {

                        iduser = Convert.ToInt32(utilisateur.Num);


                        frmMenu frmMenu = new frmMenu();
                        frmMenu.Show();
                        this.Hide();
                        

                    }
                    else
                    {
                        lblError.Text = "Mauvais mot de passe";
                    }
                }
            }

           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
