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
        private void btnAjouterDonateur_Click(object sender, EventArgs e)
        {
            String id = textIDonateur.Text;
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
            String numero= textNumeroCarte.Text;
            String date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            galerie1.ajouterDonateur(id, prenom, nom, adresse, telephone,type, numero, date);
        }


        private void btnAjouterDon_Click(object sender, EventArgs e)
        {
            if (textIdDon.Text.Equals("") || textMontantDon.Text.Equals(""))
            {
                DialogResult message = MessageBox.Show("Erreur l'id ou le don est vide");
            }
            else
            {
                String IdDon = textIdDon.Text;
                String DateDuDon = DateTime.Now.ToString("MM/dd/yyyy");
                String IdDonateur = textIDonateur.Text;
                Double MontantDuDon = Double.Parse(textMontantDon.Text);

                galerie1.ajouterDon(IdDon, DateDuDon, IdDonateur, MontantDuDon);
                int Nombredepoints = 0;
                if (MontantDuDon > 49 && MontantDuDon < 200)
                {
                    Nombredepoints = 1;
                }
                else if (MontantDuDon > 199 && MontantDuDon < 350)
                {
                    Nombredepoints = 2;
                }
                else if (MontantDuDon > 349 && MontantDuDon <= 500)
                {
                    Nombredepoints = 3;
                }
                else if (MontantDuDon > 500 && MontantDuDon < 1000)
                {
                    Nombredepoints = 4;
                }
                else if (MontantDuDon > 999)
                {
                    Nombredepoints = 4 * (Int32.Parse(MontantDuDon.ToString()) / 500);
                }

                textNombreDePoints.Text = Nombredepoints.ToString();
            }
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

        private void btnAfficherDon_Click(object sender, EventArgs e)
        {
            String result = "";
            foreach (Don don in galerie1.getDon())
            {

                result += don + "\r\n" +
                    " " + "\r\n";

            }
            textAffichage.Text = result;
        }
    }
}
