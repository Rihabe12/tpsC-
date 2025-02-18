using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie2c_.tp2
{
    class Dictionnaire : Document
    {
        public string Langue;
        public int NbDefinitions;

        public Dictionnaire(string titre, string langue, int nbDefinitions)
            : base(titre)
        {
            Langue = langue;
            NbDefinitions = nbDefinitions;
        }
        class Dictionnaire : Document
        {
            public string Langue { get; set; }
            public int NbDefinitions { get; set; }

            public Dictionnaire(string titre, string langue, int nbDefinitions)
                : base(titre)
            {
                Langue = langue;
                NbDefinitions = nbDefinitions;
            }

            public override string Description()
            {
                return base.Description() + $" | Langue: {Langue} | Définitions: {NbDefinitions}";
            }
        }


    }

}
