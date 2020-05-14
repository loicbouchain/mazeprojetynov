namespace mazeprojetynov
{
    partial class frmSupprimerUtilisateur
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
            this.btnSupprimer = new MetroFramework.Controls.MetroButton();
            this.cbxUser = new MetroFramework.Controls.MetroComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(223, 213);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(233, 44);
            this.btnSupprimer.TabIndex = 38;
            this.btnSupprimer.Text = "Supprimer cet utilisateur";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // cbxUser
            // 
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.ItemHeight = 23;
            this.cbxUser.Location = new System.Drawing.Point(223, 130);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(233, 29);
            this.cbxUser.TabIndex = 37;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(223, 308);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 39;
            // 
            // frmSupprimerUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 393);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.cbxUser);
            this.Name = "frmSupprimerUtilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSupprimer;
        private MetroFramework.Controls.MetroComboBox cbxUser;
        private System.Windows.Forms.Label lblError;
    }
}