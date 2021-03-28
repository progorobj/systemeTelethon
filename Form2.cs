using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            Regex myRegexPhone = new Regex(@"^\d{3}\-\d{3}\-\d{4}$");
            Regex myRegexNom = new Regex(@"^[a-z]+$");
            Regex myRegexCarteCredit = new Regex(@"^\d{16}$");
            DateTime date1 = DateTime.Parse(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            DateTime date2 = DateTime.Now;

            if (textIDonateur.Text.Equals("") || textPrenom.Text.Equals("") || textNom.Text.Equals("") || textAdresse.Text.Equals("") || textPhone.Text.Equals("") || textNumeroCarte.Text.Equals(""))
            {
                DialogResult message = MessageBox.Show("Vous avez des champs vides . " +
                    "Meci de remplir tout les champs ", "Attention");
            }
            else if (!rbtnAmex.Checked && !rbtnVisa.Checked && !rbtnMc.Checked)
            {
                DialogResult message = MessageBox.Show("Erreur il manque le type de carte", "Attention");
            }
            else if (!myRegexPhone.IsMatch(textPhone.Text))
            {
                DialogResult message = MessageBox.Show("Erreur numero de telephone incorect format = 555-555-5555 ", "Attention");
            }
            else if ( date1 < date2)
            {
                DialogResult message = MessageBox.Show("Erreur la carte de crédit est expirée", "Attention");
            }
            else if(!myRegexNom.IsMatch(textPrenom.Text) || !myRegexNom.IsMatch(textNom.Text))
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


        private void btnAjouterDon_Click(object sender, EventArgs e)
        {
            if (textIdDon.Text.Equals("") || textMontantDon.Text.Equals(""))
            {
                DialogResult message = MessageBox.Show("Erreur l'id du don ou du donateur ou le montant est vide");
            }
            else if (galerie1.EnregistrerDonateur(textIDonateur.Text)==false){
                DialogResult message = MessageBox.Show("Erreur le donateur n'existe pas");
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

        private void btnAfficherDonateur_Click(object sender, EventArgs e)
        {
            textAffichage.Text = galerie1.AfficherDonateurs();
        }

        private void btnAfficherDon_Click(object sender, EventArgs e)
        {
            textAffichage.Text = galerie1.AfficherDons();
        }

        private void btnAjouterComm_Click(object sender, EventArgs e)
        {
            if (txtBxIdComm.Text.Equals("") || txtPrenomComm.Text.Equals("")
                || txtNomComm.Text.Equals(""))
            {
                DialogResult message = MessageBox.Show("Vous avez des champs vides . " +
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

        private void txtBxNom_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnAfficherComm_Click(object sender, EventArgs e)
        {
            
            textAffichage.Text = galerie1.AfficherCommanditaires();
        }

        private void btnAjouterPrix_Click(object sender, EventArgs e)
        {
            if (txtIdPrix.Text.Equals("") || txtBxDescription.Text.Equals("")
                || txtValeurPrix.Text.Equals("") || txtQuantitePrix.Text.Equals("")
                || txtBxIdComm.Text.Equals(""))
            {
                DialogResult message = MessageBox.Show("Vous avez des champs vides . " +
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

        private void btnAfficherPri_Click(object sender, EventArgs e)
        {

            textAffichage.Text = galerie1.AfficherPrix();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAfficherPrix_Click(object sender, EventArgs e)
        {
            int nbrePrix;
           int nbrePoints = int.Parse(textNombreDePoints.Text);
            if (galerie1.AttribuerPrix(double.Parse(textMontantDon.Text)))
            {
                if (nbrePoints >= 1 && nbrePoints < 3)
                {
                    foreach (Prix unPrix in galerie1.getPrix())
                    {
                        if (unPrix.Valeur >= 1 && unPrix.Valeur < 3)
                        {
                            
                            textAffichage.Text = "Félicitation ! Vous avez gagner un " + nbrePoints + " " + unPrix.Description;
                            unPrix.Deduire(nbrePoints);
                        }

                    }
                }
                if (nbrePoints >= 3 && nbrePoints < 10)
                {
                    foreach (Prix unPrix in galerie1.getPrix())
                    {
                        if (unPrix.Valeur >= 3 && unPrix.Valeur < 10)
                        {
                            nbrePrix = nbrePoints / 3;

                            //test vérification de la quantité disponible de prix
                            if (unPrix.QteDisponible >= nbrePrix)
                            {
                                textAffichage.Text = "Félicitation ! Vous avez gagner  " + nbrePrix + " " + unPrix.Description;
                                unPrix.Deduire(nbrePrix);
                            }
                            else
                            {
                                textAffichage.Text = "Quantité épuisé en stock .";
                            }

                        }

                    }
                }
                if (nbrePoints >= 10 && nbrePoints < 12)
                {
                    foreach (Prix unPrix in galerie1.getPrix())
                    {
                        if (unPrix.Valeur >= 10 && unPrix.Valeur < 12)
                        {
                            nbrePrix = nbrePoints / 10;
                            textAffichage.Text = "Félicitation ! Vous avez gagner  " + nbrePrix + " " + unPrix.Description;
                            unPrix.Deduire(nbrePrix);
                        }

                    }
                }
                if (nbrePoints >= 12)
                {
                    foreach (Prix unPrix in galerie1.getPrix())
                    {
                        if (unPrix.Valeur >= 12)
                        {
                            nbrePrix = nbrePoints / 12;
                            textAffichage.Text = "Félicitation ! Vous avez gagner  " + nbrePrix+ " " + unPrix.Description;
                            unPrix.Deduire(nbrePrix);
                        }

                    }
                }

            }
            else
            {
                textAffichage.Text = "Malheureusement ! Votre score ne vous permet pas de gagner aucun prix.  ";

            }
        }
    }
}
