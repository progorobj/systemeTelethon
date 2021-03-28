using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemeTelethon
{
    class Donateur : Personne
    {
      protected  string Id;
        protected string Adresse;
        protected string Telephone;
        protected char Typedecarte;
        protected string NumeroDeCarte;
        protected string DateExpiration;
        protected int x;
        static int count = 1;

 

        public Donateur(string nom, string prenom, string id, string adresse, string telephone, char typedecarte, string numeroDeCarte, string dateExpiration) : base(nom, prenom)
        {
            this.Id = id ;
            this.Adresse = adresse ;
            this.Telephone = telephone ;
            this.Typedecarte = typedecarte;
            this.NumeroDeCarte = numeroDeCarte ;
            this.DateExpiration = dateExpiration ;
            x = count++;
        }
        public string getID()
        {
            return this.Id;
        }
        public override string ToString()
        {
            return "Donateur #"+x + base.ToString() + " [ Id : " + this.Id + " ] [ Adresse : " + this.Adresse +" ] [ Téléphone : " + this.Telephone + "] [ Type de carte : "+ this.Typedecarte  +" ] [ Numero de carte : " + this.NumeroDeCarte+ " ]"+" [ Date expiration "+ this.DateExpiration+" ]";
        }
    }
}
