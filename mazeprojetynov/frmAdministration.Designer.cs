﻿namespace mazeprojetynov
{
    partial class frmAdministration
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
            this.lblNiveauxTitre = new MetroFramework.Controls.MetroLabel();
            this.btnLoadMap = new MetroFramework.Controls.MetroButton();
            this.btnUtilisateur = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNiveauxTitre
            // 
            this.lblNiveauxTitre.AutoSize = true;
            this.lblNiveauxTitre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNiveauxTitre.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblNiveauxTitre.Location = new System.Drawing.Point(384, 28);
            this.lblNiveauxTitre.Name = "lblNiveauxTitre";
            this.lblNiveauxTitre.Size = new System.Drawing.Size(139, 25);
            this.lblNiveauxTitre.TabIndex = 12;
            this.lblNiveauxTitre.Text = "Administration";
            this.lblNiveauxTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoadMap
            // 
            this.btnLoadMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadMap.Location = new System.Drawing.Point(333, 229);
            this.btnLoadMap.Name = "btnLoadMap";
            this.btnLoadMap.Size = new System.Drawing.Size(233, 44);
            this.btnLoadMap.TabIndex = 13;
            this.btnLoadMap.Text = "Supprimer des cartes";
            this.btnLoadMap.Click += new System.EventHandler(this.btnLoadMap_Click);
            // 
            // btnUtilisateur
            // 
            this.btnUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUtilisateur.Location = new System.Drawing.Point(333, 319);
            this.btnUtilisateur.Name = "btnUtilisateur";
            this.btnUtilisateur.Size = new System.Drawing.Size(233, 44);
            this.btnUtilisateur.TabIndex = 14;
            this.btnUtilisateur.Text = "Utilisateur";
            this.btnUtilisateur.Click += new System.EventHandler(this.btnUtilisateur_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::mazeprojetynov.Properties.Resources.iconfinder_exit_delete_remove_close_x_2931151;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(820, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::mazeprojetynov.Properties.Resources.iconfinder_undo_back_arrow_2931166;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.btnUtilisateur);
            this.Controls.Add(this.btnLoadMap);
            this.Controls.Add(this.lblNiveauxTitre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdministration";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNiveauxTitre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnLoadMap;
        private MetroFramework.Controls.MetroButton btnUtilisateur;
    }
}