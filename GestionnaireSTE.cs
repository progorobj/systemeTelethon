using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemeTelethon
{
    class GestionnaireSTE
    {
        private List<Donateur> donateurs = new List<Donateur>();
        private List<Commanditaire> commanditaires = new List<Commanditaire>();
        private List<Don> don = new List<Don>();
        private List<Prix> listePrix = new List<Prix>();

        public GestionnaireSTE()
        {
            //constructeur par default   
        }

        public List<Donateur> getDonateurs()
        {
            return this.donateurs;
        }
        public List<Don> getDon()
        {
            return this.don;
        }

        public List<Commanditaire> getCommanditaire()
        {
            return this.commanditaires;
        }

        public List<Prix> getPrix()
        {
            return this.listePrix;

        }
        public void AjouterDonateur(string nom, string prenom, string id, string adresse, string telephone, char type, string numeroCarte, string DateExpiration)
        {
            Donateur donateur1 = new Donateur(nom, prenom, id, adresse, telephone, type, numeroCarte, DateExpiration);
            donateurs.Add(donateur1);
        }
        public void AjouterDon(string idDon, string dateDuDon, string idDonateur, double montant)
        {
            Don don1 = new Don(idDon, dateDuDon, idDonateur, montant);
            don.Add(don1);
        }

        public void AjouterCommanditaire(string nom, string prenom, string iDCommanditaire)
        {
            Commanditaire unCommanditaire = new Commanditaire(nom, prenom, iDCommanditaire);
            commanditaires.Add(unCommanditaire);
        }

        public void AjouterPrix(string idPrix, string description, double valeur,
            int qteOriginale, string idCommanditaire)
        {
            Prix unPrix = new Prix(idPrix, description, valeur, qteOriginale, idCommanditaire);
            listePrix.Add(unPrix);
        
        }

        public string AfficherCommanditaires() 
        {
            String result = "";
            foreach (Commanditaire unCommanditaire in this.getCommanditaire())
            {

                result += unCommanditaire + "\r\n" +
                    " " + "\r\n";

            }
            return result;
        }

        public string AfficherPrix()
        {
            String result = "";
            foreach (Prix unPrix in this.getPrix())
            {

                result += unPrix + "\r\n" +
                    " " + "\r\n";

            }
            return result;

        }
       
    }
}
