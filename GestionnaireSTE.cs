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
        private List<Commanditaire> commanditaire = new List<Commanditaire>();
        private List<Don> don = new List<Don>();
        private List<Prix> prix = new List<Prix>();
        
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
        public void AjouterDonateur(string nom, string prenom, string id, string adresse, string telephone, char type, string numeroCarte, string DateExpiration)
        {
            Donateur donateur1 = new Donateur(nom, prenom, id, adresse, telephone, type, numeroCarte, DateExpiration);
            donateurs.Add(donateur1);
        }
        public void AjouterDon(string idDon, string dateDuDon, string idDonateur, double montant)
        {
            Don don1 = new Don(idDon,dateDuDon,idDonateur, montant);
            don.Add(don1);
        }
       
    }
}
