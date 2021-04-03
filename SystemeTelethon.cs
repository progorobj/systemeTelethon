using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliothequeTelethon;
namespace systemeTelethon
{
    public partial class Systeme : Form
    {
        readonly GestionnaireSTE galerie1 = new GestionnaireSTE();
        readonly Regex myRegexPhone = new Regex(@"^\d{3}\-\d{3}\-\d{4}$");
        readonly Regex myRegexNom = new Regex(@"^[a-z]+$");
        readonly Regex myRegexCarteCredit = new Regex(@"^\d{16}$");
        public Systeme()
        {
            InitializeComponent();
        }
        private void BtnAjouterDonateur_Click(object sender, EventArgs e)
        {
         
            DateTime date1 = DateTime.Parse(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            DateTime date2 = DateTime.Now;

            if (textIDonateur.Text.Equals("") || textPrenom.Text.Equals("") || textNom.Text.Equals("") || textAdresse.Text.Equals("") || textPhone.Text.Equals("") || textNumeroCarte.Text.Equals(""))
            {
                DialogResult = MessageBox.Show("Vous avez des champs vides . " +
                    "Meci de remplir tout les champs ", "Attention");
            }
            else if(galerie1.EnregistrerDonateur(textIDonateur.Text)){
                DialogResult  = MessageBox.Show("Erreur le donateur existe déja dans la liste ", "Attention");
            }
            else if (!rbtnAmex.Checked && !rbtnVisa.Checked && !rbtnMc.Checked)
            {
                DialogResult  = MessageBox.Show("Erreur il manque le type de carte", "Attention");
            }
            else if (!myRegexPhone.IsMatch(textPhone.Text))
            {
                DialogResult  = MessageBox.Show("Erreur numero de telephone incorect format = 555-555-5555 ", "Attention");
            }
            else if (date1 < date2)
            {
                DialogResult  = MessageBox.Show("Erreur la carte de crédit est expirée", "Attention");
            }
            else if (!myRegexNom.IsMatch(textPrenom.Text) || !myRegexNom.IsMatch(textNom.Text))
            {
                DialogResult = MessageBox.Show("Erreur Nom et prénom ne peut uniquement contenir des lettres de a à z", "Attention");
            }
            else if (!myRegexCarteCredit.IsMatch(textNumeroCarte.Text))
            {
                DialogResult = MessageBox.Show("Erreur le numero de carte de crédit est invalide seul une suite de 16 chiffre entre 0-9 est accepté", "Attention");
            }
            else
            {
                String id = textIDonateur.Text;
                String prenom = textPrenom.Text;
                String nom = textNom.Text;
                String adresse = textAdresse.Text;
                String telephone = textPhone.Text;
                String numero = textNumeroCarte.Text;
                String date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                char type ='A';
                if (rbtnVisa.Checked)
                {
                    type = 'V';
                }
                else if (rbtnMc.Checked)
                {
                    type = 'M';
                }
                galerie1.AjouterDonateur(nom, prenom, id, adresse, telephone, type, numero, date);
                
            }
        }


        private void BtnAjouterDon_Click(object sender, EventArgs e)
        {
            if (textIdDon.Text.Equals("") || textMontantDon.Text.Equals(""))
            {
                DialogResult = MessageBox.Show("Erreur l'id du don ou du donateur ou le montant est vide");
            }
            else if (galerie1.EnregistrerDonateur(textIDonateur.Text)==false){
                DialogResult = MessageBox.Show("Erreur le donateur n'existe pas");
            }
            else if (galerie1.EnregistrerDon(textIdDon.Text))
            {
                DialogResult = MessageBox.Show("L'id du don existe déja dans la liste");
            }
            else
            {
                String IdDon = textIdDon.Text;
                String DateDuDon = DateTime.Now.ToString("MM/dd/yyyy");
                String IdDonateur = textIDonateur.Text;
                Double MontantDuDon = Double.Parse(textMontantDon.Text);

                galerie1.AjouterDon(IdDon, DateDuDon, IdDonateur, MontantDuDon);
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

        private void BtnAfficherDonateur_Click(object sender, EventArgs e)
        {
           // textAffichage.Text = galerie1.AfficherDonateurs();
        }

        private void BtnAfficherDon_Click(object sender, EventArgs e)
        {
            AffichageTelethon affichage = new AffichageTelethon();
            //affichage.Visible = true;
            //affichage.Activate();           
            //textAffichage.Text = galerie1.AfficherDons();
           // affichage.textAffiche = textAffichage.Text;
            affichage.textAffiche = galerie1.AfficherDons();
            affichage.ShowDialog();
        }

        private void BtnAjouterComm_Click(object sender, EventArgs e)
        {
            if (txtBxIdComm.Text.Equals("") || txtPrenomComm.Text.Equals("")
                || txtNomComm.Text.Equals(""))
            {
                DialogResult  = MessageBox.Show("Vous avez des champs vides . " +
                    "Meci de remplir tout les champs ", "Attention");
            }
            else
            {
                string idCommand = txtBxIdComm.Text;
                string prenomCommand = txtPrenomComm.Text;
                string nomCommand = txtNomComm.Text;
                galerie1.AjouterCommanditaire(nomCommand, prenomCommand, idCommand );
            }

        }

   

        private void BtnAfficherComm_Click(object sender, EventArgs e)
        {
            
           // textAffichage.Text = galerie1.AfficherCommanditaires();
        }

        private void BtnAjouterPrix_Click(object sender, EventArgs e)
        {
            if (txtIdPrix.Text.Equals("") || txtBxDescription.Text.Equals("")
                || txtValeurPrix.Text.Equals("") || txtQuantitePrix.Text.Equals("")
                || txtBxIdComm.Text.Equals(""))
            {
                DialogResult = MessageBox.Show("Vous avez des champs vides . " +
                    "Meci de remplir tout les champs ", "Attention");
            }
            else
            {
                string idPrix = txtIdPrix.Text;
                string description = txtBxDescription.Text;
                double valeur = Double.Parse(txtValeurPrix.Text);
                int quantite = int.Parse(txtQuantitePrix.Text);
                string idCommand = txtBxIdComm.Text;
                galerie1.AjouterPrix(idPrix, description, valeur,quantite,idCommand);
            }
        }

        private void BtnAfficherPri_Click(object sender, EventArgs e)
        {

           // textAffichage.Text = galerie1.AfficherPrix();
        }

        private void ButtonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAfficherPrix_Click(object sender, EventArgs e)
        {
            if (textNombreDePoints.Text.Equals(""))
            {
                DialogResult message = MessageBox.Show("Erreur il faut d'abord ajouter un don ", "Attention");
            }
            else
            {
                double Valeurpoints = 10 * (Int32.Parse(textNombreDePoints.Text));
                List<Prix> sortedPrix = galerie1.GetPrix().OrderByDescending(Prix => Prix.Valeur).ToList();

                string test = "";
                foreach (Prix prix in sortedPrix)
                {
                    while (Valeurpoints >= prix.Valeur && prix.QteDisponible > 0)
                    {
                        prix.QteDisponible--;
                        Valeurpoints -= prix.Valeur;
                        test += "Le donateur remporte un " + prix.Description + " Valeur point =" + (prix.Valeur) / 10 + " Quantite disponible = " + prix.QteDisponible + "\r\n";
                    }
                }

              //  textAffichage.Text = "Le donateur avec " + textNombreDePoints.Text + " point(s) remporte un ou plusieurs prix :  \r\n" +
                 //   "" + test;
                textNombreDePoints.Text = "";
            }
        }
    }
}
