
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitre = new System.Windows.Forms.Panel();
            this.lbTitreLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNomUtilisateur = new System.Windows.Forms.Label();
            this.lbMotPasse = new System.Windows.Forms.Label();
            this.txtBxNomUt = new System.Windows.Forms.TextBox();
            this.txtBxMoPass = new System.Windows.Forms.TextBox();
            this.btnOkLogIn = new System.Windows.Forms.Button();
            this.btnAnnulerLogIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.btnAnnulerLogIn);
            this.panel1.Controls.Add(this.btnOkLogIn);
            this.panel1.Controls.Add(this.txtBxMoPass);
            this.panel1.Controls.Add(this.txtBxNomUt);
            this.panel1.Controls.Add(this.lbMotPasse);
            this.panel1.Controls.Add(this.lbNomUtilisateur);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panelTitre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 326);
            this.panel1.TabIndex = 0;
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(242)))), ((int)(((byte)(179)))));
            this.panelTitre.Controls.Add(this.lbTitreLogin);
            this.panelTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(751, 60);
            this.panelTitre.TabIndex = 0;
            // 
            // lbTitreLogin
            // 
            this.lbTitreLogin.AutoSize = true;
            this.lbTitreLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitreLogin.Location = new System.Drawing.Point(3, 9);
            this.lbTitreLogin.Name = "lbTitreLogin";
            this.lbTitreLogin.Size = new System.Drawing.Size(262, 29);
            this.lbTitreLogin.TabIndex = 0;
            this.lbTitreLogin.Text = "Système Téléthon STE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbNomUtilisateur
            // 
            this.lbNomUtilisateur.AutoSize = true;
            this.lbNomUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomUtilisateur.Location = new System.Drawing.Point(270, 130);
            this.lbNomUtilisateur.Name = "lbNomUtilisateur";
            this.lbNomUtilisateur.Size = new System.Drawing.Size(199, 30);
            this.lbNomUtilisateur.TabIndex = 2;
            this.lbNomUtilisateur.Text = "Nom d\'utilisateur :";
            // 
            // lbMotPasse
            // 
            this.lbMotPasse.AutoSize = true;
            this.lbMotPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotPasse.Location = new System.Drawing.Point(293, 178);
            this.lbMotPasse.Name = "lbMotPasse";
            this.lbMotPasse.Size = new System.Drawing.Size(133, 24);
            this.lbMotPasse.TabIndex = 3;
            this.lbMotPasse.Text = "Mot de passe :";
            // 
            // txtBxNomUt
            // 
            this.txtBxNomUt.Location = new System.Drawing.Point(452, 130);
            this.txtBxNomUt.Name = "txtBxNomUt";
            this.txtBxNomUt.Size = new System.Drawing.Size(236, 22);
            this.txtBxNomUt.TabIndex = 4;
            // 
            // txtBxMoPass
            // 
            this.txtBxMoPass.Location = new System.Drawing.Point(452, 178);
            this.txtBxMoPass.Name = "txtBxMoPass";
            this.txtBxMoPass.Size = new System.Drawing.Size(236, 22);
            this.txtBxMoPass.TabIndex = 5;
            // 
            // btnOkLogIn
            // 
            this.btnOkLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(242)))), ((int)(((byte)(179)))));
            this.btnOkLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkLogIn.Location = new System.Drawing.Point(452, 260);
            this.btnOkLogIn.Name = "btnOkLogIn";
            this.btnOkLogIn.Size = new System.Drawing.Size(98, 33);
            this.btnOkLogIn.TabIndex = 6;
            this.btnOkLogIn.Text = "OK";
            this.btnOkLogIn.UseVisualStyleBackColor = false;
            // 
            // btnAnnulerLogIn
            // 
            this.btnAnnulerLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(242)))), ((int)(((byte)(179)))));
            this.btnAnnulerLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerLogIn.Location = new System.Drawing.Point(590, 260);
            this.btnAnnulerLogIn.Name = "btnAnnulerLogIn";
            this.btnAnnulerLogIn.Size = new System.Drawing.Size(98, 33);
            this.btnAnnulerLogIn.TabIndex = 7;
            this.btnAnnulerLogIn.Text = "Annuler";
            this.btnAnnulerLogIn.UseVisualStyleBackColor = false;
            this.btnAnnulerLogIn.Click += new System.EventHandler(this.btnAnnulerLogIn_Click);
            // 
            // SystèmeTelethon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(252)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(751, 326);
            this.Controls.Add(this.panel1);
            this.Name = "SystèmeTelethon";
            this.Text = "Système Tèlèthon STE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Label lbTitreLogin;
        private System.Windows.Forms.Button btnOkLogIn;
        private System.Windows.Forms.TextBox txtBxMoPass;
        private System.Windows.Forms.TextBox txtBxNomUt;
        private System.Windows.Forms.Label lbMotPasse;
        private System.Windows.Forms.Label lbNomUtilisateur;
        private System.Windows.Forms.Button btnAnnulerLogIn;
    }
}

