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
    public partial class Systeme : Form
    {
        GestionnaireSTE galerie1 = new GestionnaireSTE();
        
        public Systeme()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblQuant_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouterDonateur_Click(object sender, EventArgs e)
        {
            String id = textID.Text;
            String prenom = textPrenom.Text;
            String nom = textNom.Text;
            String adresse = textAdresse.Text;
            String telephone = textPhone.Text;
            char type='A';
            if (rbtnVisa.Checked)
            {
                type = 'V';
            }
            else if (rbtnMc.Checked)
            {
                type = 'M';
            }
            String numero= textnumeroCarte.Text;
            String date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            galerie1.ajouterDonateur(id, prenom, nom, adresse, telephone,type, numero, date);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouterDon_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAfficherDonateur_Click(object sender, EventArgs e)
        {
            String result = "";
            foreach (Donateur donateur in galerie1.getDonateurs())
            {

                result += donateur+"\r\n" +
                    " " +"\r\n";
                
            }
            textAffichage.Text = result;
        }
    }
}
