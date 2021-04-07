﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeTelethon
{
    public class Don
    {
        protected String IdDon;
        protected String DateDuDon;
        protected String IdDonateur;
        protected Double Montant;
        protected int x;
        static int count = 1;

        public string IdDon1 { get => IdDon; set => IdDon = value; }

        public Don(string idDon, string dateDuDon, string idDonateur, double montant)
        {
            this.IdDon = idDon;
            DateDuDon = dateDuDon;
            IdDonateur = idDonateur;
            Montant = montant;
            x = count++;
        }
        public override string ToString()
        {
            return "Don #" + x +" [ Id Don : " + IdDon + " ] [ Date du don : " + DateDuDon + " ] [ Id donateur : " + IdDonateur + "] [ Montant du don : " + Montant+"$]";
        }
    }
}