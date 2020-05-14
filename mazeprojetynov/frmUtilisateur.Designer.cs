namespace mazeprojetynov
{
    partial class frmUtilisateur
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
            this.lblTitre = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.pctRemove = new System.Windows.Forms.PictureBox();
            this.pctUpdate = new System.Windows.Forms.PictureBox();
            this.pctAdd = new System.Windows.Forms.PictureBox();
            this.pct_Retour = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Retour)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitre.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTitre.Location = new System.Drawing.Point(128, 322);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(194, 25);
            this.lblTitre.TabIndex = 18;
            this.lblTitre.Text = "Ajouter un utilisateur";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(446, 322);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(203, 25);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Modifier un utilisateur";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(760, 322);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(218, 25);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Supprimer un utilisateur";
            // 
            // pctExit
            // 
            this.pctExit.BackgroundImage = global::mazeprojetynov.Properties.Resources.iconfinder_exit_delete_remove_close_x_2931151;
            this.pctExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Location = new System.Drawing.Point(991, 5);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(50, 50);
            this.pctExit.TabIndex = 21;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // pctRemove
            // 
            this.pctRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctRemove.Image = global::mazeprojetynov.Properties.Resources.removeUser;
            this.pctRemove.Location = new System.Drawing.Point(768, 126);
            this.pctRemove.Name = "pctRemove";
            this.pctRemove.Size = new System.Drawing.Size(195, 191);
            this.pctRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRemove.TabIndex = 17;
            this.pctRemove.TabStop = false;
            this.pctRemove.Click += new System.EventHandler(this.pctRemove_Click);
            // 
            // pctUpdate
            // 
            this.pctUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctUpdate.Image = global::mazeprojetynov.Properties.Resources.editUser;
            this.pctUpdate.Location = new System.Drawing.Point(445, 126);
            this.pctUpdate.Name = "pctUpdate";
            this.pctUpdate.Size = new System.Drawing.Size(195, 191);
            this.pctUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctUpdate.TabIndex = 16;
            this.pctUpdate.TabStop = false;
            this.pctUpdate.Click += new System.EventHandler(this.pctUpdate_Click);
            // 
            // pctAdd
            // 
            this.pctAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctAdd.Image = global::mazeprojetynov.Properties.Resources.addUser;
            this.pctAdd.Location = new System.Drawing.Point(127, 117);
            this.pctAdd.Name = "pctAdd";
            this.pctAdd.Size = new System.Drawing.Size(195, 191);
            this.pctAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAdd.TabIndex = 15;
            this.pctAdd.TabStop = false;
            this.pctAdd.Click += new System.EventHandler(this.pctAdd_Click);
            // 
            // pct_Retour
            // 
            this.pct_Retour.BackgroundImage = global::mazeprojetynov.Properties.Resources.iconfinder_undo_back_arrow_2931166;
            this.pct_Retour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct_Retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_Retour.Location = new System.Drawing.Point(-1, 5);
            this.pct_Retour.Name = "pct_Retour";
            this.pct_Retour.Size = new System.Drawing.Size(50, 50);
            this.pct_Retour.TabIndex = 22;
            this.pct_Retour.TabStop = false;
            this.pct_Retour.Click += new System.EventHandler(this.pct_Retour_Click);
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 559);
            this.Controls.Add(this.pct_Retour);
            this.Controls.Add(this.pctExit);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pctRemove);
            this.Controls.Add(this.pctUpdate);
            this.Controls.Add(this.pctAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUtilisateur";
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Retour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctAdd;
        private System.Windows.Forms.PictureBox pctUpdate;
        private System.Windows.Forms.PictureBox pctRemove;
        private MetroFramework.Controls.MetroLabel lblTitre;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.PictureBox pct_Retour;
    }
}