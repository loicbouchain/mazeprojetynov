namespace mazeprojetynov
{
    partial class frmListeCartes
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
            this.cbxMap = new MetroFramework.Controls.MetroComboBox();
            this.btnSupprimer = new MetroFramework.Controls.MetroButton();
            this.pct_Retour = new System.Windows.Forms.PictureBox();
            this.pctExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Retour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxMap
            // 
            this.cbxMap.FormattingEnabled = true;
            this.cbxMap.ItemHeight = 23;
            this.cbxMap.Location = new System.Drawing.Point(436, 170);
            this.cbxMap.Name = "cbxMap";
            this.cbxMap.Size = new System.Drawing.Size(233, 29);
            this.cbxMap.TabIndex = 8;
            this.cbxMap.SelectedIndexChanged += new System.EventHandler(this.cbxMap_SelectedIndexChanged);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(436, 313);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(233, 44);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // pct_Retour
            // 
            this.pct_Retour.BackgroundImage = global::mazeprojetynov.Properties.Resources.iconfinder_undo_back_arrow_2931166;
            this.pct_Retour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct_Retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_Retour.Location = new System.Drawing.Point(3, 8);
            this.pct_Retour.Name = "pct_Retour";
            this.pct_Retour.Size = new System.Drawing.Size(50, 50);
            this.pct_Retour.TabIndex = 7;
            this.pct_Retour.TabStop = false;
            this.pct_Retour.Click += new System.EventHandler(this.pct_Retour_Click);
            // 
            // pctExit
            // 
            this.pctExit.BackgroundImage = global::mazeprojetynov.Properties.Resources.iconfinder_exit_delete_remove_close_x_2931151;
            this.pctExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Location = new System.Drawing.Point(1083, 8);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(50, 50);
            this.pctExit.TabIndex = 6;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // frmListeCartes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 592);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.cbxMap);
            this.Controls.Add(this.pct_Retour);
            this.Controls.Add(this.pctExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListeCartes";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.frmListeCartes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Retour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.PictureBox pct_Retour;
        private MetroFramework.Controls.MetroComboBox cbxMap;
        private MetroFramework.Controls.MetroButton btnSupprimer;
    }
}