using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemeTelethon
{
    class Commanditaire : Personne
    {
        string IDCommanditaire;

        public Commanditaire(string nom, string prenom, string iDCommanditaire) : base(nom,prenom)
        {
            IDCommanditaire = iDCommanditaire;
        }

        public override string ToString()
        {
            return "Commanditaire # : "+" Id Commanditaire : "+this.IDCommanditaire+" "+base.ToString();
        }

        public override string ToString()
        {
            return "Commanditaire # : " + " Id Commanditaire : " + this.IDCommanditaire + " " + base.ToString();
        }
    }
}
