using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie3c_
{
    public abstract class Personnel : Personne
    {
        private String bureau;
        private double salaire;
        private double prime;
        public Personnel(string code, string nom, string prenom , string bureau, double salaire, double prime) : base(code, nom, prenom)
        {
            this.bureau = bureau;
            this.salaire = salaire;
            this.prime = prime;
        }
        public String Bureau
        {
            get { return bureau; }
            set { bureau = value; }
        }
        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }
        public double Prime
        {
            get { return prime; }
            set { prime = value; }
        }

        public abstract double CalculerSalaire();
    }
}
