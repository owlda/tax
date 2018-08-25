namespace PrixFinale
{
    partial class Form1
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
            this.PrixInitial = new System.Windows.Forms.Label();
            this.InputPrix = new System.Windows.Forms.TextBox();
            this.TPS = new System.Windows.Forms.Label();
            this.TVQ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProduitQuebecois = new System.Windows.Forms.CheckBox();
            this.Calculer = new System.Windows.Forms.Button();
            this.PrixFinale = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrixInitial
            // 
            this.PrixInitial.AutoSize = true;
            this.PrixInitial.Location = new System.Drawing.Point(46, 34);
            this.PrixInitial.Name = "PrixInitial";
            this.PrixInitial.Size = new System.Drawing.Size(51, 13);
            this.PrixInitial.TabIndex = 0;
            this.PrixInitial.Text = "Prix Initial";
            this.PrixInitial.Click += new System.EventHandler(this.PrixInitial_Click);
            // 
            // InputPrix
            // 
            this.InputPrix.Location = new System.Drawing.Point(128, 34);
            this.InputPrix.Name = "InputPrix";
            this.InputPrix.Size = new System.Drawing.Size(208, 20);
            this.InputPrix.TabIndex = 1;
            this.InputPrix.TextChanged += new System.EventHandler(this.InputPrix_TextChanged);
            // 
            // TPS
            // 
            this.TPS.AutoSize = true;
            this.TPS.Location = new System.Drawing.Point(62, 134);
            this.TPS.Name = "TPS";
            this.TPS.Size = new System.Drawing.Size(28, 13);
            this.TPS.TabIndex = 2;
            this.TPS.Text = "TPS";
            this.TPS.Click += new System.EventHandler(this.TPS_Click);
            // 
            // TVQ
            // 
            this.TVQ.AutoSize = true;
            this.TVQ.Location = new System.Drawing.Point(61, 179);
            this.TVQ.Name = "TVQ";
            this.TVQ.Size = new System.Drawing.Size(29, 13);
            this.TVQ.TabIndex = 3;
            this.TVQ.Text = "TVQ";
            this.TVQ.Click += new System.EventHandler(this.TVQ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProduitQuebecois
            // 
            this.ProduitQuebecois.AutoSize = true;
            this.ProduitQuebecois.Location = new System.Drawing.Point(64, 226);
            this.ProduitQuebecois.Name = "ProduitQuebecois";
            this.ProduitQuebecois.Size = new System.Drawing.Size(113, 17);
            this.ProduitQuebecois.TabIndex = 6;
            this.ProduitQuebecois.Text = "Produit Quebecois";
            this.ProduitQuebecois.UseVisualStyleBackColor = true;
            this.ProduitQuebecois.CheckedChanged += new System.EventHandler(this.ProduitQuebecois_CheckedChanged);
            // 
            // Calculer
            // 
            this.Calculer.Location = new System.Drawing.Point(356, 34);
            this.Calculer.Name = "Calculer";
            this.Calculer.Size = new System.Drawing.Size(117, 47);
            this.Calculer.TabIndex = 7;
            this.Calculer.Text = "Calculer";
            this.Calculer.UseVisualStyleBackColor = true;
            this.Calculer.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrixFinale
            // 
            this.PrixFinale.AutoSize = true;
            this.PrixFinale.Location = new System.Drawing.Point(300, 253);
            this.PrixFinale.Name = "PrixFinale";
            this.PrixFinale.Size = new System.Drawing.Size(52, 13);
            this.PrixFinale.TabIndex = 8;
            this.PrixFinale.Text = "PrixFinale";
            this.PrixFinale.Click += new System.EventHandler(this.PrixFinale_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 304);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrixFinale);
            this.Controls.Add(this.Calculer);
            this.Controls.Add(this.ProduitQuebecois);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TVQ);
            this.Controls.Add(this.TPS);
            this.Controls.Add(this.InputPrix);
            this.Controls.Add(this.PrixInitial);
            this.Name = "Form1";
            this.Text = "Calcul de taxes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrixInitial;
        private System.Windows.Forms.TextBox InputPrix;
        private System.Windows.Forms.Label TPS;
        private System.Windows.Forms.Label TVQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ProduitQuebecois;
        private System.Windows.Forms.Button Calculer;
        private System.Windows.Forms.Label PrixFinale;
        private System.Windows.Forms.Label label3;
    }
}

