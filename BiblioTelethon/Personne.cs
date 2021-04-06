using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeTelethon
{
    public class Personne
    {
       protected string nom;
       protected string prenom;

        public Personne(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public override string ToString()
        {
            return " : [ Prénom : " + this.prenom + " ] [ Nom : " + this.nom+" ]";
        }
    }
}
