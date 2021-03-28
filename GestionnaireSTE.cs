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
            Prix Televiseur = new Prix("1","téléviseur",120,5,"radioshack");
            Prix Calendrier = new Prix("2", "calendrier", 10, 5,  "dollorama");
            Prix Repas = new Prix("3", "repas pour 2", 30, 5,  "Paul patate");
            Prix Bbq = new Prix("4", "BBQ", 100, 5,  "Canadiantire");
            listePrix.Add(Televiseur);
            listePrix.Add(Calendrier);
            listePrix.Add(Repas);
            listePrix.Add(Bbq);
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
            Donateur unDonateur = new Donateur(nom, prenom, id, adresse, telephone, type, numeroCarte, DateExpiration);
            donateurs.Add(unDonateur);
        }
        public void AjouterDon(string idDon, string dateDuDon, string idDonateur, double montant)
        {
            Don unDon = new Don(idDon, dateDuDon, idDonateur, montant);
            don.Add(unDon);
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
        public string AfficherDonateurs()
        {
            String result = "";
            foreach (Donateur donateur in this.getDonateurs())
            {

                result += donateur + "\r\n" +
                    " " + "\r\n";

            }
            return result;
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
        public string AfficherDons()
        {
            String result = "";
            foreach (Don don in this.getDon())
            {

                result += don + "\r\n" +
                    " " + "\r\n";

            }
            return result;
        }
        public Boolean EnregistrerDonateur(String IdDonateur)
        {
            bool checkup = false;
            foreach (Donateur donateur in  this.getDonateurs())
            {
                if (IdDonateur.Equals(donateur.getID())){
                    checkup = true;
                }

            }
            return checkup;
        }

        public Boolean AttribuerPrix(double montant)
        {
            if (montant > 49 )
            {
                return true;       
                    }
            

            return false;
        }

        
     }
       
    
}
