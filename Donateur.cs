using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemeTelethon
{
    class Donateur : Personne
    {
        string id;
        string adresse;
        string telephone;
        char typedecarte;
        string numeroDeCarte;
        string DateExpiration;



        public Donateur(string nom, string prenom, string id, string adresse, string telephone, char typedecarte, string numeroDeCarte, string dateExpiration) : base(nom, prenom)
        {
            this.id = id ?? throw new ArgumentNullException(nameof(id));
            this.adresse = adresse ?? throw new ArgumentNullException(nameof(adresse));
            this.telephone = telephone ?? throw new ArgumentNullException(nameof(telephone));
            this.typedecarte = typedecarte;
            this.numeroDeCarte = numeroDeCarte ?? throw new ArgumentNullException(nameof(numeroDeCarte));
            DateExpiration = dateExpiration ?? throw new ArgumentNullException(nameof(dateExpiration));
            base.;
        }
       
    }
}
