
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
            this.btnAnnulerLogIn = new System.Windows.Forms.Button();
            this.btnOkLogIn = new System.Windows.Forms.Button();
            this.txtBxMoPass = new System.Windows.Forms.TextBox();
            this.txtBxNomUt = new System.Windows.Forms.TextBox();
            this.lbMotPasse = new System.Windows.Forms.Label();
            this.lbNomUtilisateur = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitre = new System.Windows.Forms.Panel();
            this.lbTitreLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 265);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAnnulerLogIn
            // 
            this.btnAnnulerLogIn.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAnnulerLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerLogIn.Location = new System.Drawing.Point(442, 211);
            this.btnAnnulerLogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnulerLogIn.Name = "btnAnnulerLogIn";
            this.btnAnnulerLogIn.Size = new System.Drawing.Size(74, 27);
            this.btnAnnulerLogIn.TabIndex = 7;
            this.btnAnnulerLogIn.Text = "Annuler";
            this.btnAnnulerLogIn.UseVisualStyleBackColor = false;
            this.btnAnnulerLogIn.Click += new System.EventHandler(this.btnAnnulerLogIn_Click);
            // 
            // btnOkLogIn
            // 
            this.btnOkLogIn.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOkLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkLogIn.Location = new System.Drawing.Point(339, 211);
            this.btnOkLogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOkLogIn.Name = "btnOkLogIn";
            this.btnOkLogIn.Size = new System.Drawing.Size(74, 27);
            this.btnOkLogIn.TabIndex = 6;
            this.btnOkLogIn.Text = "OK";
            this.btnOkLogIn.UseVisualStyleBackColor = false;
            // 
            // txtBxMoPass
            // 
            this.txtBxMoPass.Location = new System.Drawing.Point(339, 145);
            this.txtBxMoPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBxMoPass.Name = "txtBxMoPass";
            this.txtBxMoPass.Size = new System.Drawing.Size(178, 20);
            this.txtBxMoPass.TabIndex = 5;
            // 
            // txtBxNomUt
            // 
            this.txtBxNomUt.Location = new System.Drawing.Point(339, 106);
            this.txtBxNomUt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBxNomUt.Name = "txtBxNomUt";
            this.txtBxNomUt.Size = new System.Drawing.Size(178, 20);
            this.txtBxNomUt.TabIndex = 4;
            // 
            // lbMotPasse
            // 
            this.lbMotPasse.AutoSize = true;
            this.lbMotPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotPasse.Location = new System.Drawing.Point(220, 145);
            this.lbMotPasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMotPasse.Name = "lbMotPasse";
            this.lbMotPasse.Size = new System.Drawing.Size(106, 18);
            this.lbMotPasse.TabIndex = 3;
            this.lbMotPasse.Text = "Mot de passe :";
            // 
            // lbNomUtilisateur
            // 
            this.lbNomUtilisateur.AutoSize = true;
            this.lbNomUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomUtilisateur.Location = new System.Drawing.Point(202, 106);
            this.lbNomUtilisateur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNomUtilisateur.Name = "lbNomUtilisateur";
            this.lbNomUtilisateur.Size = new System.Drawing.Size(126, 18);
            this.lbNomUtilisateur.TabIndex = 2;
            this.lbNomUtilisateur.Text = "Nom d\'utilisateur :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitre.Controls.Add(this.lbTitreLogin);
            this.panelTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(563, 49);
            this.panelTitre.TabIndex = 0;
            // 
            // lbTitreLogin
            // 
            this.lbTitreLogin.AutoSize = true;
            this.lbTitreLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitreLogin.Location = new System.Drawing.Point(2, 7);
            this.lbTitreLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitreLogin.Name = "lbTitreLogin";
            this.lbTitreLogin.Size = new System.Drawing.Size(204, 24);
            this.lbTitreLogin.TabIndex = 0;
            this.lbTitreLogin.Text = "Système Téléthon STE";
            // 
            // SystèmeTelethon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(252)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(563, 265);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SystèmeTelethon";
            this.Text = "Système Tèlèthon STE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
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

