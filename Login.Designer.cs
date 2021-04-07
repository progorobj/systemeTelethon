
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pictInstagram = new System.Windows.Forms.PictureBox();
            this.pictTwitter = new System.Windows.Forms.PictureBox();
            this.pictFacebook = new System.Windows.Forms.PictureBox();
            this.pictTelethon = new System.Windows.Forms.PictureBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtBxMoPass = new System.Windows.Forms.TextBox();
            this.txtBxNomUt = new System.Windows.Forms.TextBox();
            this.lbMotPasse = new System.Windows.Forms.Label();
            this.lbNomUtilisateur = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictTelethon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(180)))));
            this.pnlLogin.Controls.Add(this.pictInstagram);
            this.pnlLogin.Controls.Add(this.pictTwitter);
            this.pnlLogin.Controls.Add(this.pictFacebook);
            this.pnlLogin.Controls.Add(this.pictTelethon);
            this.pnlLogin.Controls.Add(this.btnAnnuler);
            this.pnlLogin.Controls.Add(this.btnOk);
            this.pnlLogin.Controls.Add(this.txtBxMoPass);
            this.pnlLogin.Controls.Add(this.txtBxNomUt);
            this.pnlLogin.Controls.Add(this.lbMotPasse);
            this.pnlLogin.Controls.Add(this.lbNomUtilisateur);
            this.pnlLogin.Location = new System.Drawing.Point(-2, -1);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(363, 381);
            this.pnlLogin.TabIndex = 36;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // pictInstagram
            // 
            this.pictInstagram.Image = ((System.Drawing.Image)(resources.GetObject("pictInstagram.Image")));
            this.pictInstagram.Location = new System.Drawing.Point(212, 334);
            this.pictInstagram.Margin = new System.Windows.Forms.Padding(2);
            this.pictInstagram.Name = "pictInstagram";
            this.pictInstagram.Size = new System.Drawing.Size(29, 31);
            this.pictInstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictInstagram.TabIndex = 42;
            this.pictInstagram.TabStop = false;
            // 
            // pictTwitter
            // 
            this.pictTwitter.Image = ((System.Drawing.Image)(resources.GetObject("pictTwitter.Image")));
            this.pictTwitter.Location = new System.Drawing.Point(167, 333);
            this.pictTwitter.Margin = new System.Windows.Forms.Padding(2);
            this.pictTwitter.Name = "pictTwitter";
            this.pictTwitter.Size = new System.Drawing.Size(29, 31);
            this.pictTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictTwitter.TabIndex = 41;
            this.pictTwitter.TabStop = false;
            // 
            // pictFacebook
            // 
            this.pictFacebook.Image = ((System.Drawing.Image)(resources.GetObject("pictFacebook.Image")));
            this.pictFacebook.Location = new System.Drawing.Point(123, 333);
            this.pictFacebook.Margin = new System.Windows.Forms.Padding(2);
            this.pictFacebook.Name = "pictFacebook";
            this.pictFacebook.Size = new System.Drawing.Size(31, 32);
            this.pictFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictFacebook.TabIndex = 40;
            this.pictFacebook.TabStop = false;
            // 
            // pictTelethon
            // 
            this.pictTelethon.BackColor = System.Drawing.Color.Transparent;
            this.pictTelethon.Image = ((System.Drawing.Image)(resources.GetObject("pictTelethon.Image")));
            this.pictTelethon.Location = new System.Drawing.Point(60, 13);
            this.pictTelethon.Name = "pictTelethon";
            this.pictTelethon.Size = new System.Drawing.Size(233, 89);
            this.pictTelethon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictTelethon.TabIndex = 39;
            this.pictTelethon.TabStop = false;
            this.pictTelethon.Click += new System.EventHandler(this.pictTelethon_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(181)))), ((int)(((byte)(233)))));
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnuler.Location = new System.Drawing.Point(187, 263);
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
            this.btnOk.Location = new System.Drawing.Point(77, 263);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 34);
            this.btnOk.TabIndex = 37;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.ButtonOk_Click_1);
            // 
            // txtBxMoPass
            // 
            this.txtBxMoPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxMoPass.Location = new System.Drawing.Point(187, 197);
            this.txtBxMoPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxMoPass.Name = "txtBxMoPass";
            this.txtBxMoPass.Size = new System.Drawing.Size(147, 26);
            this.txtBxMoPass.TabIndex = 36;
            this.txtBxMoPass.Text = "Don@2021";
            this.txtBxMoPass.TextChanged += new System.EventHandler(this.txtBxMoPass_TextChanged);
            // 
            // txtBxNomUt
            // 
            this.txtBxNomUt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNomUt.Location = new System.Drawing.Point(187, 154);
            this.txtBxNomUt.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxNomUt.Name = "txtBxNomUt";
            this.txtBxNomUt.Size = new System.Drawing.Size(147, 26);
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
            this.lbMotPasse.Location = new System.Drawing.Point(33, 197);
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
            this.lbNomUtilisateur.Location = new System.Drawing.Point(33, 154);
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
            this.ClientSize = new System.Drawing.Size(361, 380);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SystèmeTelethon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Système Tèlèthon STE";
            this.Load += new System.EventHandler(this.SystèmeTelethon_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictTelethon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox pictTelethon;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtBxMoPass;
        private System.Windows.Forms.TextBox txtBxNomUt;
        private System.Windows.Forms.Label lbMotPasse;
        private System.Windows.Forms.Label lbNomUtilisateur;
        private System.Windows.Forms.PictureBox pictInstagram;
        private System.Windows.Forms.PictureBox pictTwitter;
        private System.Windows.Forms.PictureBox pictFacebook;
    }
}

