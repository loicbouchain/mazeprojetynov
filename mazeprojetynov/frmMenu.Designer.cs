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
            this.lblTitre = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJouer
            // 
            this.btnJouer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJouer.Location = new System.Drawing.Point(349, 268);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(192, 77);
            this.btnJouer.TabIndex = 0;
            this.btnJouer.Text = "Charger une carte";
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditer.Location = new System.Drawing.Point(349, 145);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(192, 77);
            this.btnEditer.TabIndex = 1;
            this.btnEditer.Text = "Créer une carte";
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // btnRegles
            // 
            this.btnRegles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegles.Location = new System.Drawing.Point(349, 396);
            this.btnRegles.Name = "btnRegles";
            this.btnRegles.Size = new System.Drawing.Size(192, 77);
            this.btnRegles.TabIndex = 2;
            this.btnRegles.Text = "Administration";
            this.btnRegles.Click += new System.EventHandler(this.btnRegles_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitre.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTitre.Location = new System.Drawing.Point(384, 32);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(124, 25);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "LABYRINTHE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::mazeprojetynov.Properties.Resources.iconfinder_exit_delete_remove_close_x_2931151;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(835, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnRegles);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnJouer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnJouer;
        private MetroFramework.Controls.MetroButton btnEditer;
        private MetroFramework.Controls.MetroButton btnRegles;
        private MetroFramework.Controls.MetroLabel lblTitre;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}