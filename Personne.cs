using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemeTelethon
{
    class Personne
    {
        string nom;
        string prenom;

        public Personne(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public string Preom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }


        public override string ToString()
        {
            return " : [ Prénom : " + this.prenom + " ] [ Nom : " + this.nom+" ]";
        }
    }
}
