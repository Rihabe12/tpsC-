using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie3c_
{
    public abstract class Personne
    {
        private String code;
        private String nom;
        private String prenom;

        public Personne(string code, string nom, string prenom)
        {
            this.code = code;
            this.nom = nom;
            this.prenom = prenom;
        }

        public String Code
        {
            get { return code; }
            set { code = value; }
        }
        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public String Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
    }
}
