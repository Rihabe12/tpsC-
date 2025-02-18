using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie2c_.tp2
{
    class Livre : Document
    {
        public string Auteur;
        public int NbPages;

        public Livre(string titre, string auteur, int nbPages)
            : base(titre) // Appel du constructeur de Document
        {
            Auteur = auteur;
            NbPages = nbPages;
        }

        public override string Description()
        {
            return base.Description() + $" | Auteur: {Auteur} | Pages: {NbPages}";
        }
    }

}
