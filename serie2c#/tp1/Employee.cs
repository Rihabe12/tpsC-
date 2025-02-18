using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie2c_.tp1
{
    class Employee
    {
        public string Nom;
        public double Salaire;
        public string Poste;
        public DateTime DateEmbauche;

        public Employee(string nom, double salaire, string poste, DateTime dateEmbauche)
        {
            Nom = nom;
            Salaire = salaire;
            Poste = poste;
            DateEmbauche = dateEmbauche;
        }

       
    }
}
