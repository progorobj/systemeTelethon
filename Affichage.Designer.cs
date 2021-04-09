
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
            this.pnlAffichage = new System.Windows.Forms.Panel();
            this.textAffichage = new System.Windows.Forms.TextBox();
            this.pnlAffichage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAffichage
            // 
            this.pnlAffichage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(181)))));
            this.pnlAffichage.Controls.Add(this.textAffichage);
            this.pnlAffichage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAffichage.Location = new System.Drawing.Point(0, 0);
            this.pnlAffichage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAffichage.Name = "pnlAffichage";
            this.pnlAffichage.Size = new System.Drawing.Size(731, 254);
            this.pnlAffichage.TabIndex = 0;
            // 
            // textAffichage
            // 
            this.textAffichage.BackColor = System.Drawing.SystemColors.Window;
            this.textAffichage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAffichage.Location = new System.Drawing.Point(23, 23);
            this.textAffichage.Multiline = true;
            this.textAffichage.Name = "textAffichage";
            this.textAffichage.ReadOnly = true;
            this.textAffichage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textAffichage.Size = new System.Drawing.Size(679, 208);
            this.textAffichage.TabIndex = 0;
            this.textAffichage.TextChanged += new System.EventHandler(this.textAffichage_TextChanged_1);
            // 
            // AffichageTelethon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 254);
            this.Controls.Add(this.pnlAffichage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AffichageTelethon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Affichage ";
            this.Load += new System.EventHandler(this.AffichageTelethon_Load);
            this.pnlAffichage.ResumeLayout(false);
            this.pnlAffichage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAffichage;
        private System.Windows.Forms.TextBox textAffichage;
    }
}