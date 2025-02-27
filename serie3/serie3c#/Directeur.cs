using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie3c_
{
    class Directeur : Personnel
    {
        private static Directeur instance;
        public Directeur(string code, string nom, string prenom, string bureau, double salaire, double prime) : base(code, nom, prenom, bureau, salaire, prime)
        {
        }
        public override double CalculerSalaire()
        {
            return Salaire+Prime;
        }
    }
}
