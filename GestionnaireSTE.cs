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
       private List<Don> don = new List<Don>();
        public GestionnaireSTE()
        {
        //constructeur par default   
        }

        public GestionnaireSTE(List<Donateur> donateurs, List<Don> don)
        {
            this.donateurs = donateurs;
            this.don = don;
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
            Donateur a = new Donateur(nom, prenom, id, adresse, telephone, type, numeroCarte, DateExpiration);
            donateurs.Add(a);
        }
        public void AjouterDon(string idDon, string dateDuDon, string idDonateur, double montant)
        {
            Don don1 = new Don(idDon,dateDuDon,idDonateur, montant);
            don.Add(don1);
        }
       
    }
}
