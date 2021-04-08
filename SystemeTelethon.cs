using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BibliothequeTelethon;

namespace systemeTelethon
{
    public partial class Systeme : Form
    {
        protected GestionnaireSTE galerie1 = new GestionnaireSTE();
        protected AffichageTelethon affichage = new AffichageTelethon();

        protected Regex myRegexPhone = new Regex(@"^\d{3}\-\d{3}\-\d{4}$");
        protected Regex myRegexNom = new Regex(@"^[a-z]+$");
        protected Regex myRegexMontant = new Regex(@"^[0-9]+$");
        protected Regex myRegexCarteCredit = new Regex(@"^\d{16}$");
        protected Regex myRegexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        public Systeme()
        {
            InitializeComponent();
        }
        private void BtnAjouterDonateur_Click(object sender, EventArgs e)
        {

            DateTime date1 = DateTime.Parse(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            DateTime date2 = DateTime.Now;

            if (textIDonateur.Text.Equals("") || textPrenom.Text.Equals("") || textNom.Text.Equals("") || textEmail.Text.Equals("") || textPhone.Text.Equals("") || textNumeroCarte.Text.Equals(""))
            {
                DialogResult = MessageBox.Show("Vous avez des champs vides, veuillez remplir tout les champs ", "Attention");
            }
            else if (galerie1.EnregistrerDonateur(textIDonateur.Text))
            {
                DialogResult = MessageBox.Show("Erreur le donateur existe déja dans la liste ", "Attention");
            }
            else if (!rbtnAmex.Checked && !rbtnVisa.Checked && !rbtnMc.Checked)
            {
                DialogResult = MessageBox.Show("Erreur il manque le type de carte", "Attention");
            }
            else if (!myRegexPhone.IsMatch(textPhone.Text))
            {
                DialogResult = MessageBox.Show("Erreur numero de telephone incorect, format = 555-555-5555 ", "Attention");
            }
            else if (date1 < date2)
            {
                DialogResult = MessageBox.Show("Erreur la carte de crédit est expirée", "Attention");
            }
            else if (!myRegexNom.IsMatch(textPrenom.Text) || !myRegexNom.IsMatch(textNom.Text))
            {
                DialogResult = MessageBox.Show("Erreur Nom et prénom ne peut uniquement contenir des lettres de a à z", "Attention");
            }
            else if (!myRegexCarteCredit.IsMatch(textNumeroCarte.Text))
            {
                DialogResult = MessageBox.Show("Erreur le numero de carte de crédit est invalide seul une suite de 16 chiffre entre 0-9 est accepté", "Attention");
            }
            else if (!myRegexEmail.IsMatch(textEmail.Text))
            {
                DialogResult = MessageBox.Show("Erreur l'adresse email est invailde, format = xyz@gmail.com ", "Attention");
            }
            else
            {
                String id = textIDonateur.Text;
                String prenom = textPrenom.Text;
                String nom = textNom.Text;
                String adresse = textEmail.Text;
                String telephone = textPhone.Text;
                String numero = textNumeroCarte.Text;
                String date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                char type = 'A';
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
                DialogResult = MessageBox.Show("Erreur l'id du don ou du donateur ou le montant est vide", "Attention");
            }
            else if (galerie1.EnregistrerDonateur(textIDonateur.Text) == false)
            {
                DialogResult = MessageBox.Show("Erreur le donateur n'existe pas", "Attention");
            }
            else if (galerie1.EnregistrerDon(textIdDon.Text))
            {
                DialogResult = MessageBox.Show("L'id du don existe déja dans la liste", "Attention");
            }
            else if (!myRegexMontant.IsMatch(textMontantDon.Text) || textMontantDon.Text[0]=='0')
            {
                DialogResult = MessageBox.Show("Erreur le montant du don dois être supérieur à 0 et seul les chiffres de 0-9 sont accepté", "Attention");
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
            if (galerie1.GetDonateurs().Count > 0)
            {
                affichage.textAffiche = galerie1.AfficherDonateurs();
                affichage.ShowDialog();
            }
            else
            {
                DialogResult = MessageBox.Show("Erreur la liste est vide");
            }
        }

        private void BtnAfficherDon_Click(object sender, EventArgs e)
        {
            if (galerie1.GetDon().Count > 0)
            {
                affichage.textAffiche = galerie1.AfficherDons();
                affichage.ShowDialog();
            }
            else
            {
                DialogResult = MessageBox.Show("Erreur la liste est vide");
            }
        }

        private void BtnAjouterComm_Click(object sender, EventArgs e)
        {
            if (txtBxIdComm.Text.Equals("") || txtPrenomComm.Text.Equals("")
                || txtNomComm.Text.Equals(""))
            {
                DialogResult = MessageBox.Show("Vous avez des champs vides . " +
                    "Meci de remplir tout les champs ", "Attention");
            }
            else
            {
                string idCommand = txtBxIdComm.Text;
                string prenomCommand = txtPrenomComm.Text;
                string nomCommand = txtNomComm.Text;
                galerie1.AjouterCommanditaire(nomCommand, prenomCommand, idCommand);
            }

        }



        private void BtnAfficherComm_Click(object sender, EventArgs e)
        {

            affichage.textAffiche = galerie1.AfficherCommanditaires();
            affichage.ShowDialog();

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
                galerie1.AjouterPrix(idPrix, description, valeur, quantite, idCommand);
            }
        }

        private void BtnAfficherPri_Click(object sender, EventArgs e)
        {

            affichage.textAffiche = galerie1.AfficherPrix();
            affichage.ShowDialog();
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
                textEmail.Text = string.Empty;
                textIdDon.Text = string.Empty;
                textIDonateur.Text = string.Empty;
                textMontantDon.Text = string.Empty;
                textNom.Text = string.Empty;
                textPrenom.Text = string.Empty;
                textPhone.Text = string.Empty;
                textNumeroCarte.Text = string.Empty;
                rbtnAmex.Checked = false;
                rbtnMc.Checked = false;
                rbtnVisa.Checked = false;

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
                AffichageTelethon affichage = new AffichageTelethon();

                affichage.textAffiche = "Le donateur avec " + textNombreDePoints.Text + " point(s) remporte un ou plusieurs prix :  \r\n" +
                 "" + test;
                affichage.ShowDialog();


                textNombreDePoints.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnQuitterComman_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuitterInfo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuitterDon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
