namespace mazeprojetynov
{
    partial class frmMenu
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
            this.btnJouer = new MetroFramework.Controls.MetroButton();
            this.btnEditer = new MetroFramework.Controls.MetroButton();
            this.btnRegles = new MetroFramework.Controls.MetroButton();
            this.btnQuitter = new MetroFramework.Controls.MetroButton();
            this.lblTitre = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnJouer
            // 
            this.btnJouer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJouer.Location = new System.Drawing.Point(346, 122);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(192, 77);
            this.btnJouer.TabIndex = 0;
            this.btnJouer.Text = "JOUER";
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditer.Location = new System.Drawing.Point(346, 228);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(192, 77);
            this.btnEditer.TabIndex = 1;
            this.btnEditer.Text = "EDITEUR DE NIVEAU";
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // btnRegles
            // 
            this.btnRegles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegles.Location = new System.Drawing.Point(346, 334);
            this.btnRegles.Name = "btnRegles";
            this.btnRegles.Size = new System.Drawing.Size(192, 77);
            this.btnRegles.TabIndex = 2;
            this.btnRegles.Text = "REGLES";
            this.btnRegles.Click += new System.EventHandler(this.btnRegles_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.Location = new System.Drawing.Point(346, 479);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(192, 77);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "QUITTER";
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitre.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTitre.Location = new System.Drawing.Point(350, 27);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(191, 25);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "JEU DU LABYRINTHE";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRegles);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnJouer);
            this.Name = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnJouer;
        private MetroFramework.Controls.MetroButton btnEditer;
        private MetroFramework.Controls.MetroButton btnRegles;
        private MetroFramework.Controls.MetroButton btnQuitter;
        private MetroFramework.Controls.MetroLabel lblTitre;
    }
}