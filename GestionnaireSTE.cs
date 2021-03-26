using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemeTelethon
{
    class GestionnaireSTE
    {
        List<Donateur> donateurs = new List<Donateur>();
        List<Don> don = new List<Don>();
        List<Commanditaire> commanditaires = new List<Commanditaire>();
        List<Prix> prix = new List<Prix>();


        public GestionnaireSTE()
        {
           
        }

        public GestionnaireSTE(List<Donateur> donateurs, List<Don> don, List<Commanditaire> commanditaires, List<Prix> prix)
        {
            this.donateurs = donateurs;
            this.don = don;
            this.commanditaires = commanditaires;
            this.prix = prix;
        }
        public List<Donateur> getDonateurs()
        {
            return this.donateurs;
        }

        public List<Commanditaire> Commanditaires
        {
            get { return this.commanditaires; }
            set { this.commanditaires = value; }
        }


        public List<Prix> Prix
        {
            get { return this.prix; }
            set { this.prix = value; }
        }
        public void ajouterCommanditaire(string nom, string prenom, string iDCommanditaire)
        {
            Commanditaire unCommanditaire = new Commanditaire(nom, prenom, iDCommanditaire);
            commanditaires.Add(unCommanditaire);
        }

        public void ajouterDonateur(string nom, string prenom, string id, string adresse, string telephone, char type, string numeroCarte, string DateExpiration)
        {
            Donateur a = new Donateur(nom, prenom, id, adresse, telephone, type, numeroCarte, DateExpiration);
            donateurs.Add(a);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
