namespace mazeprojetynov
{
    partial class frmJouer
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
            this.btnJouerAleatoire = new MetroFramework.Controls.MetroButton();
            this.btnJouerExistant = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJouerAleatoire
            // 
            this.btnJouerAleatoire.Location = new System.Drawing.Point(279, 130);
            this.btnJouerAleatoire.Name = "btnJouerAleatoire";
            this.btnJouerAleatoire.Size = new System.Drawing.Size(333, 144);
            this.btnJouerAleatoire.TabIndex = 0;
            this.btnJouerAleatoire.Text = "JOUER NIVEAU ALÉATOIRE";
            // 
            // btnJouerExistant
            // 
            this.btnJouerExistant.Location = new System.Drawing.Point(279, 361);
            this.btnJouerExistant.Name = "btnJouerExistant";
            this.btnJouerExistant.Size = new System.Drawing.Size(333, 144);
            this.btnJouerExistant.TabIndex = 1;
            this.btnJouerExistant.Text = "JOUER NIVEAU CRÉÉ";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(382, 460);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::mazeprojetynov.Properties.Resources.iconfinder_exit_delete_remove_close_x_2931151;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(820, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::mazeprojetynov.Properties.Resources.iconfinder_undo_back_arrow_2931166;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmJouer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnJouerExistant);
            this.Controls.Add(this.btnJouerAleatoire);
            this.Name = "frmJouer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnJouerAleatoire;
        private MetroFramework.Controls.MetroButton btnJouerExistant;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}