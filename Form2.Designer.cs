
namespace systemeTelethon
{
    partial class Form2
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
            this.pnlInterface2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlInterface2
            // 
            this.pnlInterface2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(213)))));
            this.pnlInterface2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInterface2.Location = new System.Drawing.Point(0, -375);
            this.pnlInterface2.Name = "pnlInterface2";
            this.pnlInterface2.Size = new System.Drawing.Size(856, 1086);
            this.pnlInterface2.TabIndex = 0;
            this.pnlInterface2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 711);
            this.Controls.Add(this.pnlInterface2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInterface2;
    }
}