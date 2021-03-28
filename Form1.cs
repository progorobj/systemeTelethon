using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemeTelethon
{
    public partial class SystèmeTelethon : Form
    {
        public SystèmeTelethon()
        {
            InitializeComponent();
        }

        private void btnAnnulerLogIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // pictureBox1.Padding = new Padding(0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbTitreLogin_Click(object sender, EventArgs e)
        {

        }

        private void lbNomUtilisateur_Click(object sender, EventArgs e)
        {

        }

        private void lbMotPasse_Click(object sender, EventArgs e)
        {

        }

        private void txtBxNomUt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBxMoPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOk_Click_1(object sender, EventArgs e)
        {
            string utilisateur = txtBxNomUt.Text.Trim().ToLower();
            string motPasse = txtBxMoPass.Text;
            if (!String.IsNullOrEmpty(utilisateur) &&
                (!String.IsNullOrEmpty((motPasse))))
            {
                if (utilisateur == "téléthon 2021" && motPasse == "Don@2021")
                {

                    this.Close();



                }
                else
                {
                    MessageBox.Show("Les informations saisies ne sont pas " +
                        "valides.", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    txtBxNomUt.SelectAll();
                    txtBxNomUt.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vous devez saisir votre nom d'utilisateur " +
                    "et votre mot de passe.", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtBxNomUt.Focus();

            }
        }

     


        private void buttonAnnuler_Click_2(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Désirez-vous réellement " +
         "quitter cette application ?", "Attention",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
