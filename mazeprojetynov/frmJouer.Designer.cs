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
            this.btnLoadMap = new MetroFramework.Controls.MetroButton();
            this.cbxMap = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMur = new MetroFramework.Controls.MetroLabel();
            this.lblObstacle = new MetroFramework.Controls.MetroLabel();
            this.lblPiege = new MetroFramework.Controls.MetroLabel();
            this.btnRaf = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadMap
            // 
            this.btnLoadMap.Location = new System.Drawing.Point(336, 328);
            this.btnLoadMap.Name = "btnLoadMap";
            this.btnLoadMap.Size = new System.Drawing.Size(233, 44);
            this.btnLoadMap.TabIndex = 1;
            this.btnLoadMap.Text = "CHARGER";
            this.btnLoadMap.Click += new System.EventHandler(this.btnLoadMap_Click);
            // 
            // cbxMap
            // 
            this.cbxMap.FormattingEnabled = true;
            this.cbxMap.ItemHeight = 23;
            this.cbxMap.Location = new System.Drawing.Point(336, 182);
            this.cbxMap.Name = "cbxMap";
            this.cbxMap.Size = new System.Drawing.Size(233, 29);
            this.cbxMap.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::mazeprojetynov.Properties.Resources.iconfinder_exit_delete_remove_close_x_2931151;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblMur
            // 
            this.lblMur.AutoSize = true;
            this.lblMur.Location = new System.Drawing.Point(47, 182);
            this.lblMur.Name = "lblMur";
            this.lblMur.Size = new System.Drawing.Size(111, 19);
            this.lblMur.TabIndex = 6;
            this.lblMur.Text = "Nombre de murs";
            this.lblMur.Visible = false;
            // 
            // lblObstacle
            // 
            this.lblObstacle.AutoSize = true;
            this.lblObstacle.Location = new System.Drawing.Point(47, 271);
            this.lblObstacle.Name = "lblObstacle";
            this.lblObstacle.Size = new System.Drawing.Size(127, 19);
            this.lblObstacle.TabIndex = 7;
            this.lblObstacle.Text = "Nombre d\'obstacles";
            this.lblObstacle.Visible = false;
            // 
            // lblPiege
            // 
            this.lblPiege.AutoSize = true;
            this.lblPiege.Location = new System.Drawing.Point(47, 357);
            this.lblPiege.Name = "lblPiege";
            this.lblPiege.Size = new System.Drawing.Size(120, 19);
            this.lblPiege.TabIndex = 8;
            this.lblPiege.Text = "Nombre de pièges";
            this.lblPiege.Visible = false;
            // 
            // btnRaf
            // 
            this.btnRaf.Location = new System.Drawing.Point(666, 328);
            this.btnRaf.Name = "btnRaf";
            this.btnRaf.Size = new System.Drawing.Size(145, 44);
            this.btnRaf.TabIndex = 9;
            this.btnRaf.Text = "Informations de la map";
            this.btnRaf.Click += new System.EventHandler(this.btnRaf_Click);
            // 
            // frmJouer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.btnRaf);
            this.Controls.Add(this.lblPiege);
            this.Controls.Add(this.lblObstacle);
            this.Controls.Add(this.lblMur);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbxMap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoadMap);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJouer";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnLoadMap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox cbxMap;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel lblMur;
        private MetroFramework.Controls.MetroLabel lblObstacle;
        private MetroFramework.Controls.MetroLabel lblPiege;
        private MetroFramework.Controls.MetroButton btnRaf;
    }
}