namespace mazeprojetynov
{
    partial class frmInfoMap
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
            this.lblPiege = new MetroFramework.Controls.MetroLabel();
            this.lblObstacle = new MetroFramework.Controls.MetroLabel();
            this.lblMur = new MetroFramework.Controls.MetroLabel();
            this.lblResultat = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblPiege
            // 
            this.lblPiege.AutoSize = true;
            this.lblPiege.Location = new System.Drawing.Point(64, 189);
            this.lblPiege.Name = "lblPiege";
            this.lblPiege.Size = new System.Drawing.Size(120, 19);
            this.lblPiege.TabIndex = 11;
            this.lblPiege.Text = "Nombre de pièges";
            // 
            // lblObstacle
            // 
            this.lblObstacle.AutoSize = true;
            this.lblObstacle.Location = new System.Drawing.Point(64, 108);
            this.lblObstacle.Name = "lblObstacle";
            this.lblObstacle.Size = new System.Drawing.Size(112, 19);
            this.lblObstacle.TabIndex = 10;
            this.lblObstacle.Text = "Nombre de boue";
            // 
            // lblMur
            // 
            this.lblMur.AutoSize = true;
            this.lblMur.Location = new System.Drawing.Point(64, 35);
            this.lblMur.Name = "lblMur";
            this.lblMur.Size = new System.Drawing.Size(111, 19);
            this.lblMur.TabIndex = 9;
            this.lblMur.Text = "Nombre de murs";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(64, 259);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(54, 19);
            this.lblResultat.TabIndex = 12;
            this.lblResultat.Text = "Resultat";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(64, 321);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(125, 19);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date du dernier test";
            // 
            // frmInfoMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 372);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblPiege);
            this.Controls.Add(this.lblObstacle);
            this.Controls.Add(this.lblMur);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInfoMap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblPiege;
        private MetroFramework.Controls.MetroLabel lblObstacle;
        private MetroFramework.Controls.MetroLabel lblMur;
        private MetroFramework.Controls.MetroLabel lblResultat;
        private MetroFramework.Controls.MetroLabel lblDate;
    }
}