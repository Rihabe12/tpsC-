using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie2c_.tp2
{
    class Document
    {
        private static int compteur = 1;
        public int ID;
        public string Titre; 

        public Document(string titre)
        {
            ID = compteur++;
            Titre = titre;
        }
        public virtual string Description()
        {
            return $"ID: {ID} | Titre: {Titre}";
        }
    }
}
