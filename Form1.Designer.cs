
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
            this.txtBxMoPass = new System.Windows.Forms.TextBox();
            this.txtBxNomUt = new System.Windows.Forms.TextBox();
            this.lbMotPasse = new System.Windows.Forms.Label();
            this.lbNomUtilisateur = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitre = new System.Windows.Forms.Panel();
            this.lbTitreLogin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtBxMoPass);
            this.panel1.Controls.Add(this.txtBxNomUt);
            this.panel1.Controls.Add(this.lbMotPasse);
            this.panel1.Controls.Add(this.lbNomUtilisateur);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panelTitre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 264);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtBxMoPass
            // 
            this.txtBxMoPass.Location = new System.Drawing.Point(423, 133);
            this.txtBxMoPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxMoPass.Name = "txtBxMoPass";
            this.txtBxMoPass.Size = new System.Drawing.Size(229, 20);
            this.txtBxMoPass.TabIndex = 5;
            // 
            // txtBxNomUt
            // 
            this.txtBxNomUt.Location = new System.Drawing.Point(423, 94);
            this.txtBxNomUt.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxNomUt.Name = "txtBxNomUt";
            this.txtBxNomUt.Size = new System.Drawing.Size(229, 20);
            this.txtBxNomUt.TabIndex = 4;
            // 
            // lbMotPasse
            // 
            this.lbMotPasse.AutoSize = true;
            this.lbMotPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotPasse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMotPasse.Location = new System.Drawing.Point(285, 135);
            this.lbMotPasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMotPasse.Name = "lbMotPasse";
            this.lbMotPasse.Size = new System.Drawing.Size(113, 20);
            this.lbMotPasse.TabIndex = 3;
            this.lbMotPasse.Text = "Mot de passe :";
            // 
            // lbNomUtilisateur
            // 
            this.lbNomUtilisateur.AutoSize = true;
            this.lbNomUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomUtilisateur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNomUtilisateur.Location = new System.Drawing.Point(285, 94);
            this.lbNomUtilisateur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNomUtilisateur.Name = "lbNomUtilisateur";
            this.lbNomUtilisateur.Size = new System.Drawing.Size(134, 20);
            this.lbNomUtilisateur.TabIndex = 2;
            this.lbNomUtilisateur.Text = "Nom d\'utilisateur :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelTitre.Controls.Add(this.lbTitreLogin);
            this.panelTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(720, 49);
            this.panelTitre.TabIndex = 0;
            // 
            // lbTitreLogin
            // 
            this.lbTitreLogin.AutoSize = true;
            this.lbTitreLogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitreLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitreLogin.Location = new System.Drawing.Point(2, 9);
            this.lbTitreLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitreLogin.Name = "lbTitreLogin";
            this.lbTitreLogin.Size = new System.Drawing.Size(221, 22);
            this.lbTitreLogin.TabIndex = 0;
            this.lbTitreLogin.Text = "Système Téléthon STE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(558, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 28);
            this.button1.TabIndex = 31;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(423, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 28);
            this.button2.TabIndex = 30;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // SystèmeTelethon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(252)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(720, 264);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox txtBxMoPass;
        private System.Windows.Forms.TextBox txtBxNomUt;
        private System.Windows.Forms.Label lbMotPasse;
        private System.Windows.Forms.Label lbNomUtilisateur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

