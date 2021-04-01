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

        private void BtnAnnulerLogIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            // pictureBox1.Padding = new Padding(0);
        }

        private void ButtonOk_Click_1(object sender, EventArgs e)
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

     


        private void ButtonAnnuler_Click_2(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Désirez-vous réellement " +
         "quitter cette application ?", "Attention",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtBxNomUt_Leave(object sender, EventArgs e)
        {
            if (txtBxNomUt.Text.Equals(""))
            {
                txtBxNomUt.ForeColor = Color.Silver;
                txtBxNomUt.Text = "Nom d'utilisateur";
            }
        }
    }
}
