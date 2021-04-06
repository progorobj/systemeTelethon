using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeTelethon
{
    public class Prix
    {
        private string idPrix;
        private string description;
        private double valeur;
        private int qteOriginale;
        private int qteDisponible;
        private string idCommanditaire;

        public Prix(string idPrix, string description, double valeur,
            int qteOriginale, string idCommanditaire)
        {
            this.idPrix = idPrix;
            this.description = description;
            this.valeur = valeur;
            this.qteOriginale = qteOriginale;
            this.qteDisponible = qteOriginale;
            this.idCommanditaire = idCommanditaire;
        }

        public string IdPrix
        {
            get { return this.idPrix; }
            set { this.idPrix = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public double Valeur
        {
            get { return this.valeur; }
            set { this.valeur = value; }
        }
        public int QteOriginale
        {
            get { return this.qteOriginale; }
            set { this.qteOriginale = value; }
        }

        public int QteDisponible
        {
            get { return this.qteDisponible; }
            set { this.qteDisponible = value; }
        }
        public string IdCommanditaire
        {
            get { return this.idCommanditaire; }
            set { this.idCommanditaire = value; }
        }

        public void Deduire(int qteDeduite)
        {
            this.qteDisponible -= qteDeduite;
        }



        public override string ToString()
        {
            return "Prix : Id prix : "+idPrix+" , Description : "+description
                +" , Id commanditaire :"+idCommanditaire+" , Valeur : "+valeur+" \t\tQuantite originale : "+qteOriginale
                +" , Quantité disponible : "+qteDisponible;
        }
    }
}
