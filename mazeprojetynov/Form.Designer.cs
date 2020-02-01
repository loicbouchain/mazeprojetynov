namespace mazeprojetynov
{
    partial class Form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picMaze = new System.Windows.Forms.PictureBox();
            this.btndepart = new System.Windows.Forms.Button();
            this.btnfin = new System.Windows.Forms.Button();
            this.btnmur = new System.Windows.Forms.Button();
            this.btnpiege = new System.Windows.Forms.Button();
            this.btnvide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(15, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Afficher le chemin le plus court";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(114, 20);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Créer";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Enabled = false;
            this.txtHeight.Location = new System.Drawing.Point(59, 33);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(35, 20);
            this.txtHeight.TabIndex = 9;
            this.txtHeight.Text = "10";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hauteur";
            // 
            // txtWidth
            // 
            this.txtWidth.Enabled = false;
            this.txtWidth.Location = new System.Drawing.Point(59, 7);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(35, 20);
            this.txtWidth.TabIndex = 7;
            this.txtWidth.Text = "15";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Largeur";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // picMaze
            // 
            this.picMaze.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaze.BackColor = System.Drawing.Color.White;
            this.picMaze.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picMaze.Location = new System.Drawing.Point(15, 60);
            this.picMaze.Name = "picMaze";
            this.picMaze.Size = new System.Drawing.Size(965, 511);
            this.picMaze.TabIndex = 12;
            this.picMaze.TabStop = false;
            this.picMaze.Click += new System.EventHandler(this.picMaze_Click);
            // 
            // btndepart
            // 
            this.btndepart.Location = new System.Drawing.Point(1033, 102);
            this.btndepart.Name = "btndepart";
            this.btndepart.Size = new System.Drawing.Size(75, 23);
            this.btndepart.TabIndex = 13;
            this.btndepart.Text = "départ";
            this.btndepart.UseVisualStyleBackColor = true;
            this.btndepart.Click += new System.EventHandler(this.btndepart_Click);
            // 
            // btnfin
            // 
            this.btnfin.Location = new System.Drawing.Point(1033, 206);
            this.btnfin.Name = "btnfin";
            this.btnfin.Size = new System.Drawing.Size(75, 23);
            this.btnfin.TabIndex = 14;
            this.btnfin.Text = "fin";
            this.btnfin.UseVisualStyleBackColor = true;
            this.btnfin.Click += new System.EventHandler(this.btnfin_Click);
            // 
            // btnmur
            // 
            this.btnmur.Location = new System.Drawing.Point(1033, 287);
            this.btnmur.Name = "btnmur";
            this.btnmur.Size = new System.Drawing.Size(75, 23);
            this.btnmur.TabIndex = 15;
            this.btnmur.Text = "mur";
            this.btnmur.UseVisualStyleBackColor = true;
            this.btnmur.Click += new System.EventHandler(this.btnmur_Click);
            // 
            // btnpiege
            // 
            this.btnpiege.Location = new System.Drawing.Point(1033, 368);
            this.btnpiege.Name = "btnpiege";
            this.btnpiege.Size = new System.Drawing.Size(75, 23);
            this.btnpiege.TabIndex = 16;
            this.btnpiege.Text = "piège";
            this.btnpiege.UseVisualStyleBackColor = true;
            this.btnpiege.Click += new System.EventHandler(this.btnpiege_Click);
            // 
            // btnvide
            // 
            this.btnvide.Location = new System.Drawing.Point(1033, 436);
            this.btnvide.Name = "btnvide";
            this.btnvide.Size = new System.Drawing.Size(75, 23);
            this.btnvide.TabIndex = 17;
            this.btnvide.Text = "vide";
            this.btnvide.UseVisualStyleBackColor = true;
            this.btnvide.Click += new System.EventHandler(this.btnvide_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 612);
            this.Controls.Add(this.btnvide);
            this.Controls.Add(this.btnpiege);
            this.Controls.Add(this.btnmur);
            this.Controls.Add(this.btnfin);
            this.Controls.Add(this.btndepart);
            this.Controls.Add(this.picMaze);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picMaze;
        private System.Windows.Forms.Button btndepart;
        private System.Windows.Forms.Button btnfin;
        private System.Windows.Forms.Button btnmur;
        private System.Windows.Forms.Button btnpiege;
        private System.Windows.Forms.Button btnvide;
    }
}

