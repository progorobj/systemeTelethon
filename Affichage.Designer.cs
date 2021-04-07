
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
            this.textAffichage = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.textAffichage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 254);
            this.panel1.TabIndex = 0;
            // 
            // textAffichage
            // 
            this.textAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textAffichage.Location = new System.Drawing.Point(24, 21);
            this.textAffichage.Margin = new System.Windows.Forms.Padding(2);
            this.textAffichage.Multiline = true;
            this.textAffichage.Name = "textAffichage";
            this.textAffichage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textAffichage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textAffichage.Size = new System.Drawing.Size(683, 209);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}