using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie1c_.tp2
{
    class Projet
    {
        public string Code;
        public string Sujet;
        public int Duree;
        private List<Programmeur> Programmeurs;

        public Projet(string code, string sujet, int duree)
        {
            Code = code;
            Sujet = sujet;
            Duree = duree;
            Programmeurs = new List<Programmeur>();
        }

        public void AjouterProgrammeur(Programmeur p)
        {
            Programmeurs.Add(p);
        }

        public Programmeur RechercherProgrammeur(int id)
        {
            return Programmeurs.Find(p => p.Id == id);
        }

        public void AfficherProgrammeur(int id)
        {
            Programmeur p = RechercherProgrammeur(id);
            if (p != null)
            {
                Console.WriteLine(p);
            }
            else
            {
                Console.WriteLine("Programmeur introuvable.");
            }
        }

        public void AfficherListeProgrammeurs()
        {
            if (Programmeurs.Count == 0)
            {
                Console.WriteLine("Aucun programmeur dans le projet.");
            }
            else
            {
                Console.WriteLine("Liste des programmeurs :");
                foreach (var p in Programmeurs)
                {
                    Console.WriteLine(p);
                }
            }
        }

        public void SupprimerProgrammeur(int id)
        {
            Programmeur p = RechercherProgrammeur(id);
            if (p != null)
            {
                Programmeurs.Remove(p);
                Console.WriteLine($"Programmeur {p.Nom} supprimé.");
            }
            else
            {
                Console.WriteLine("Programmeur introuvable.");
            }
        }

        public void AjouterConsommationCafe(int id, int semaine, int tasses)
        {
            Programmeur p = RechercherProgrammeur(id);
            if (p != null)
            {
                p.AjouterConsommation(semaine, tasses);
            }
            else
            {
                Console.WriteLine("Programmeur introuvable.");
            }
        }

        public int CafeTotalSemaine(int semaine)
        {
            int total = 0;
            foreach (var p in Programmeurs)
            {
                if (semaine >= 0 && semaine < Duree)
                {
                    total += p.ConsommationCafe[semaine];
                }
            }
            return total;
        }
    }
}
