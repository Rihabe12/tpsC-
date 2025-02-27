using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie3c_
{
    class Groupe
    {
        private String nom;
        private List<Etudiant> etudiants= new List<Etudiant> ();

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public Groupe(string nom, List<Etudiant> etudiants)
        {
            this.nom = nom;
            this.etudiants = etudiants;
        }

        public void AjouterEtudiant(Etudiant etu)
        {
            etudiants.Add(etu);
        }

        public void AfficherEtudiants()
        {
            for (int i=0; i < etudiants.Count; i++)
            {
                Console.WriteLine($" {etudiants[i].Nom} {etudiants[i].Prenom}, Niveau: {etudiants[i].Niveau}, et de moyenne {etudiants[i].Moyenne}");
            }
        }


    }
}
