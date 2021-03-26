
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
            this.lbTitreLogin = new System.Windows.Forms.Label();
            this.pbxLogin = new System.Windows.Forms.PictureBox();
            this.btnAnnulerLogin = new System.Windows.Forms.Button();
            this.btnOkLogin = new System.Windows.Forms.Button();
            this.txtBxMoPass = new System.Windows.Forms.TextBox();
            this.txtBxNomUt = new System.Windows.Forms.TextBox();
            this.lbMotPasse = new System.Windows.Forms.Label();
            this.lbNomUtilisateur = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(181)))));
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.lbTitreLogin);
            this.pnlLogin.Controls.Add(this.pbxLogin);
            this.pnlLogin.Controls.Add(this.btnAnnulerLogin);
            this.pnlLogin.Controls.Add(this.btnOkLogin);
            this.pnlLogin.Controls.Add(this.txtBxMoPass);
            this.pnlLogin.Controls.Add(this.txtBxNomUt);
            this.pnlLogin.Controls.Add(this.lbMotPasse);
            this.pnlLogin.Controls.Add(this.lbNomUtilisateur);
            this.pnlLogin.Location = new System.Drawing.Point(5, 6);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(949, 313);
            this.pnlLogin.TabIndex = 36;
            // 
            // lbTitreLogin
            // 
            this.lbTitreLogin.AutoSize = true;
            this.lbTitreLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbTitreLogin.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitreLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitreLogin.Location = new System.Drawing.Point(255, 21);
            this.lbTitreLogin.Name = "lbTitreLogin";
            this.lbTitreLogin.Size = new System.Drawing.Size(384, 40);
            this.lbTitreLogin.TabIndex = 0;
            this.lbTitreLogin.Text = "Système Téléthon STE";
            this.lbTitreLogin.Click += new System.EventHandler(this.lbTitreLogin_Click_1);
            // 
            // pbxLogin
            // 
            this.pbxLogin.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogin.Image")));
            this.pbxLogin.Location = new System.Drawing.Point(21, 82);
            this.pbxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pbxLogin.Name = "pbxLogin";
            this.pbxLogin.Size = new System.Drawing.Size(311, 126);
            this.pbxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLogin.TabIndex = 39;
            this.pbxLogin.TabStop = false;
            // 
            // btnAnnulerLogin
            // 
            this.btnAnnulerLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btnAnnulerLogin.FlatAppearance.BorderSize = 0;
            this.btnAnnulerLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnulerLogin.Location = new System.Drawing.Point(732, 231);
            this.btnAnnulerLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnulerLogin.Name = "btnAnnulerLogin";
            this.btnAnnulerLogin.Size = new System.Drawing.Size(136, 42);
            this.btnAnnulerLogin.TabIndex = 38;
            this.btnAnnulerLogin.Text = "Annuler";
            this.btnAnnulerLogin.UseVisualStyleBackColor = false;
            this.btnAnnulerLogin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnOkLogin
            // 
            this.btnOkLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btnOkLogin.FlatAppearance.BorderSize = 0;
            this.btnOkLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOkLogin.Location = new System.Drawing.Point(545, 231);
            this.btnOkLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnOkLogin.Name = "btnOkLogin";
            this.btnOkLogin.Size = new System.Drawing.Size(155, 42);
            this.btnOkLogin.TabIndex = 37;
            this.btnOkLogin.Text = "Ok";
            this.btnOkLogin.UseVisualStyleBackColor = false;
            this.btnOkLogin.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtBxMoPass
            // 
            this.txtBxMoPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxMoPass.Location = new System.Drawing.Point(545, 172);
            this.txtBxMoPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxMoPass.Name = "txtBxMoPass";
            this.txtBxMoPass.Size = new System.Drawing.Size(321, 30);
            this.txtBxMoPass.TabIndex = 36;
            // 
            // txtBxNomUt
            // 
            this.txtBxNomUt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNomUt.Location = new System.Drawing.Point(545, 124);
            this.txtBxNomUt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxNomUt.Name = "txtBxNomUt";
            this.txtBxNomUt.Size = new System.Drawing.Size(321, 30);
            this.txtBxNomUt.TabIndex = 35;
            // 
            // lbMotPasse
            // 
            this.lbMotPasse.AutoSize = true;
            this.lbMotPasse.BackColor = System.Drawing.Color.Transparent;
            this.lbMotPasse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotPasse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMotPasse.Location = new System.Drawing.Point(353, 177);
            this.lbMotPasse.Name = "lbMotPasse";
            this.lbMotPasse.Size = new System.Drawing.Size(150, 24);
            this.lbMotPasse.TabIndex = 34;
            this.lbMotPasse.Text = "Mot de passe :";
            // 
            // lbNomUtilisateur
            // 
            this.lbNomUtilisateur.AutoSize = true;
            this.lbNomUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.lbNomUtilisateur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomUtilisateur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNomUtilisateur.Location = new System.Drawing.Point(351, 127);
            this.lbNomUtilisateur.Name = "lbNomUtilisateur";
            this.lbNomUtilisateur.Size = new System.Drawing.Size(183, 24);
            this.lbNomUtilisateur.TabIndex = 33;
            this.lbNomUtilisateur.Text = "Nom d\'utilisateur :";
            // 
            // SystèmeTelethon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 325);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SystèmeTelethon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Système Tèlèthon STE";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lbTitreLogin;
        private System.Windows.Forms.PictureBox pbxLogin;
        private System.Windows.Forms.Button btnAnnulerLogin;
        private System.Windows.Forms.Button btnOkLogin;
        private System.Windows.Forms.TextBox txtBxMoPass;
        private System.Windows.Forms.TextBox txtBxNomUt;
        private System.Windows.Forms.Label lbMotPasse;
        private System.Windows.Forms.Label lbNomUtilisateur;
    }
}

