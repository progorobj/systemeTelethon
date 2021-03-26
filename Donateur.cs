using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemeTelethon
{
    class Donateur : Personne
    {
      private  string id;
        private string adresse;
        private string telephone;
        private char typedecarte;
        private string numeroDeCarte;
        private string DateExpiration;
        private int x;
        static int count = 1;

        public int MyProperty { get; set; }
        public string Id { get => id; set => id = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public char Typedecarte { get => typedecarte; set => typedecarte = value; }
        public string NumeroDeCarte { get => numeroDeCarte; set => numeroDeCarte = value; }
        public string DateExpiration1 { get => DateExpiration; set => DateExpiration = value; }

        public Donateur(string nom, string prenom, string id, string adresse, string telephone, char typedecarte, string numeroDeCarte, string dateExpiration) : base(nom, prenom)
        {
            this.Id = id ?? throw new ArgumentNullException(nameof(id));
            this.Adresse = adresse ?? throw new ArgumentNullException(nameof(adresse));
            this.Telephone = telephone ?? throw new ArgumentNullException(nameof(telephone));
            this.Typedecarte = typedecarte;
            this.NumeroDeCarte = numeroDeCarte ?? throw new ArgumentNullException(nameof(numeroDeCarte));
            this.DateExpiration = dateExpiration ?? throw new ArgumentNullException(nameof(dateExpiration));
            x = count++;
        }

        public override string ToString()
        {
            return "Donateur #"+x + base.ToString() + " [ Id : " + this.Id + " ] [ Adresse : " + this.Adresse +" ] [ Téléphone : " + this.Telephone + "] [ Type de carte : "+ this.Typedecarte  +" ] [ Numero de carte : " + this.NumeroDeCarte+ " ]"+" [ Date expiration "+ this.DateExpiration+" ]";
        }
    }
}
