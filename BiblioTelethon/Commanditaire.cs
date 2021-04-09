using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeTelethon
{
    public class Commanditaire : Personne
    {
        protected string iDCommanditaire;
        protected int x;
        static int count = 1;

        public Commanditaire(string nom, string prenom, string iDCommand) : base(nom,prenom)
        {
            iDCommanditaire = iDCommand;
            x = count++;
        }


        public string IDCommanditaire
        {
            get { return this.IDCommanditaire; }
            set { this.iDCommanditaire = value; }
        }
        public override string ToString()
        {
            return "Commanditaire #"+x+" : "+" Id Commanditaire : "+iDCommanditaire+" "+base.ToString();
        }

       
    }
}
