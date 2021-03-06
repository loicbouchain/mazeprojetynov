﻿using System;
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
    public partial class frmAjouterUtilisateur : MetroFramework.Forms.MetroForm
    {
        ynovprojetEntities testcontext = new ynovprojetEntities();
        public user user;
        public Hashing hash;
        public frmAjouterUtilisateur()
        {
            InitializeComponent();
        }

        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {
            hash = new Hashing();
           
            user = new user
            {
                user_name = txtBoxUsername.Text,
                user_mdp = hash.HashPassword(txtBoxPassword.Text) //hash le password en bcrypt

            };
            testcontext.user.Add(user);
            testcontext.SaveChanges();//l'ajoute a la bdd
            this.Close();
        }
    }
}
