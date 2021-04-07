
namespace systemeTelethon
{
    partial class AffichageTelethon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffichageTelethon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.textAffichage = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.buttonQuitter);
            this.panel1.Controls.Add(this.textAffichage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 254);
            this.panel1.TabIndex = 0;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(157)))), ((int)(((byte)(254)))));
            this.buttonQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonQuitter.FlatAppearance.BorderSize = 0;
            this.buttonQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuitter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.ForeColor = System.Drawing.Color.White;
            this.buttonQuitter.Location = new System.Drawing.Point(642, 215);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(73, 28);
            this.buttonQuitter.TabIndex = 38;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = false;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // textAffichage
            // 
            this.textAffichage.Location = new System.Drawing.Point(9, 21);
            this.textAffichage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textAffichage.Multiline = true;
            this.textAffichage.Name = "textAffichage";
            this.textAffichage.Size = new System.Drawing.Size(707, 188);
            this.textAffichage.TabIndex = 0;
            this.textAffichage.WordWrap = false;
            this.textAffichage.TextChanged += new System.EventHandler(this.textAffichage_TextChanged);
            // 
            // AffichageTelethon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 254);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AffichageTelethon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Affichage ";
            this.Load += new System.EventHandler(this.AffichageTelethon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textAffichage;
        private System.Windows.Forms.Button buttonQuitter;
    }
}