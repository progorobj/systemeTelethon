using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeTelethon
{
    public class Commanditaire : Personne
    {
        protected string IDCommanditaire;
        protected int x;
        static int count = 1;

        public Commanditaire(string nom, string prenom, string iDCommanditaire) : base(nom,prenom)
        {
            IDCommanditaire = iDCommanditaire;
            x = count++;
        }
          public string GetIDCommanditaire()
        {
            return this.IDCommanditaire;
        }
        public override string ToString()
        {
            return "Commanditaire #"+x+" : "+" Id Commanditaire : "+IDCommanditaire+" "+base.ToString();
        }

       
    }
}
