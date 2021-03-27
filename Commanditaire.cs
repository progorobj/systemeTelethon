using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemeTelethon
{
    class Commanditaire : Personne
    {
       private string IDCommanditaire;
        private int x;
        static int count = 1;

        public Commanditaire(string nom, string prenom, string iDCommanditaire) : base(nom,prenom)
        {
            IDCommanditaire = iDCommanditaire;
            x = count++;
        }

        public override string ToString()
        {
            return "Commanditaire #"+x+" : "+" Id Commanditaire : "+this.IDCommanditaire+" "+base.ToString();
        }

       
    }
}
