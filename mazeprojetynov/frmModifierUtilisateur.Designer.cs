namespace mazeprojetynov
{
    partial class frmModifierUtilisateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblmdp = new MetroFramework.Controls.MetroLabel();
            this.lblNom = new MetroFramework.Controls.MetroLabel();
            this.btn_Enregistrer = new MetroFramework.Controls.MetroButton();
            this.txtBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.cbxUser = new MetroFramework.Controls.MetroComboBox();
            this.btnModifier = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblmdp
            // 
            this.lblmdp.AutoSize = true;
            this.lblmdp.Location = new System.Drawing.Point(437, 146);
            this.lblmdp.Name = "lblmdp";
            this.lblmdp.Size = new System.Drawing.Size(95, 19);
            this.lblmdp.TabIndex = 34;
            this.lblmdp.Text = "Mot de passe :";
            this.lblmdp.Visible = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(438, 60);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(116, 19);
            this.lblNom.TabIndex = 33;
            this.lblNom.Text = "Nom d\'utilisateur :";
            this.lblNom.Visible = false;
            // 
            // btn_Enregistrer
            // 
            this.btn_Enregistrer.Location = new System.Drawing.Point(457, 270);
            this.btn_Enregistrer.Name = "btn_Enregistrer";
            this.btn_Enregistrer.Size = new System.Drawing.Size(106, 36);
            this.btn_Enregistrer.TabIndex = 32;
            this.btn_Enregistrer.Text = "Enregistrer";
            this.btn_Enregistrer.Visible = false;
            this.btn_Enregistrer.Click += new System.EventHandler(this.btn_Enregistrer_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(437, 168);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(144, 23);
            this.txtBoxPassword.TabIndex = 31;
            this.txtBoxPassword.Visible = false;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(437, 91);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(144, 23);
            this.txtBoxUsername.TabIndex = 30;
            this.txtBoxUsername.Visible = false;
            // 
            // cbxUser
            // 
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.ItemHeight = 23;
            this.cbxUser.Location = new System.Drawing.Point(52, 85);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(233, 29);
            this.cbxUser.TabIndex = 35;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(52, 168);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(233, 44);
            this.btnModifier.TabIndex = 36;
            this.btnModifier.Text = "Modifier cet utilisateur";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // frmModifierUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 393);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.cbxUser);
            this.Controls.Add(this.lblmdp);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btn_Enregistrer);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModifierUtilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblmdp;
        private MetroFramework.Controls.MetroLabel lblNom;
        private MetroFramework.Controls.MetroButton btn_Enregistrer;
        private MetroFramework.Controls.MetroTextBox txtBoxPassword;
        private MetroFramework.Controls.MetroTextBox txtBoxUsername;
        private MetroFramework.Controls.MetroComboBox cbxUser;
        private MetroFramework.Controls.MetroButton btnModifier;
    }
}