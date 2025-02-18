using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie2c_.tp1
{
    class Directeur
    {
        private static Directeur instance;
        private GestionEmployes gestionEmployes;

        private Directeur()
        {
            gestionEmployes = new GestionEmployes();
        }

        public static Directeur GetInstance()
        {
            if (instance == null)
                instance = new Directeur();
            return instance;
        }

        public GestionEmployes GetGestionEmployes()
        {
            return gestionEmployes;
        }
    }
}
