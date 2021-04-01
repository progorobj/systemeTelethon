
namespace systemeTelethon
{
    partial class SystèmeTelethon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystèmeTelethon));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitreLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtBxMoPass = new System.Windows.Forms.TextBox();
            this.txtBxNomUt = new System.Windows.Forms.TextBox();
            this.lbMotPasse = new System.Windows.Forms.Label();
            this.lbNomUtilisateur = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(181)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbTitreLogin);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnAnnuler);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.txtBxMoPass);
            this.panel2.Controls.Add(this.txtBxNomUt);
            this.panel2.Controls.Add(this.lbMotPasse);
            this.panel2.Controls.Add(this.lbNomUtilisateur);
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 255);
            this.panel2.TabIndex = 36;
            // 
            // lbTitreLogin
            // 
            this.lbTitreLogin.AutoSize = true;
            this.lbTitreLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbTitreLogin.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitreLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitreLogin.Location = new System.Drawing.Point(191, 17);
            this.lbTitreLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitreLogin.Name = "lbTitreLogin";
            this.lbTitreLogin.Size = new System.Drawing.Size(314, 32);
            this.lbTitreLogin.TabIndex = 0;
            this.lbTitreLogin.Text = "Système Téléthon STE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(181)))), ((int)(((byte)(233)))));
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnuler.Location = new System.Drawing.Point(549, 188);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(102, 34);
            this.btnAnnuler.TabIndex = 38;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.ButtonAnnuler_Click_2);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(181)))), ((int)(((byte)(233)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOk.Location = new System.Drawing.Point(409, 188);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(116, 34);
            this.btnOk.TabIndex = 37;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.ButtonOk_Click_1);
            // 
            // txtBxMoPass
            // 
            this.txtBxMoPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxMoPass.Location = new System.Drawing.Point(409, 140);
            this.txtBxMoPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxMoPass.Name = "txtBxMoPass";
            this.txtBxMoPass.Size = new System.Drawing.Size(242, 26);
            this.txtBxMoPass.TabIndex = 36;
            this.txtBxMoPass.Text = "Don@2021";
            // 
            // txtBxNomUt
            // 
            this.txtBxNomUt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNomUt.Location = new System.Drawing.Point(409, 101);
            this.txtBxNomUt.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxNomUt.Name = "txtBxNomUt";
            this.txtBxNomUt.Size = new System.Drawing.Size(242, 26);
            this.txtBxNomUt.TabIndex = 35;
            this.txtBxNomUt.Text = "téléthon 2021";
            this.txtBxNomUt.TextChanged += new System.EventHandler(this.txtBxNomUt_Leave);
            // 
            // lbMotPasse
            // 
            this.lbMotPasse.AutoSize = true;
            this.lbMotPasse.BackColor = System.Drawing.Color.Transparent;
            this.lbMotPasse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotPasse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMotPasse.Location = new System.Drawing.Point(265, 144);
            this.lbMotPasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMotPasse.Name = "lbMotPasse";
            this.lbMotPasse.Size = new System.Drawing.Size(120, 19);
            this.lbMotPasse.TabIndex = 34;
            this.lbMotPasse.Text = "Mot de passe :";
            // 
            // lbNomUtilisateur
            // 
            this.lbNomUtilisateur.AutoSize = true;
            this.lbNomUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.lbNomUtilisateur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomUtilisateur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNomUtilisateur.Location = new System.Drawing.Point(263, 103);
            this.lbNomUtilisateur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNomUtilisateur.Name = "lbNomUtilisateur";
            this.lbNomUtilisateur.Size = new System.Drawing.Size(148, 19);
            this.lbNomUtilisateur.TabIndex = 33;
            this.lbNomUtilisateur.Text = "Nom d\'utilisateur :";
            // 
            // SystèmeTelethon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 264);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SystèmeTelethon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Système Tèlèthon STE";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitreLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtBxMoPass;
        private System.Windows.Forms.TextBox txtBxNomUt;
        private System.Windows.Forms.Label lbMotPasse;
        private System.Windows.Forms.Label lbNomUtilisateur;
    }
}

