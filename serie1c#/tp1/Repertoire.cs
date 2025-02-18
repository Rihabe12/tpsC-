﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie1c_.tp1
{
    class Repertoire
    {
        public string Nom;
        private Fichier[] fichiers;
        private int Nbr_fichiers;
        public Repertoire(string nom)
        {
            Nom = nom;
            fichiers = new Fichier[30];
            Nbr_fichiers = 0;
        }
        public void Afficher()
        {
            Console.WriteLine($"Répertoire: {Nom}");
            if (Nbr_fichiers == 0)
            {
                Console.WriteLine("Aucun fichier.");
            }
            else
            {
                for (int i = 0; i < Nbr_fichiers; i++)
                {
                    Console.WriteLine($"- {fichiers[i]}");
                }
            }
        }

          public int Rechercher(string nom)
        {
            for (int i = 0; i < Nbr_fichiers; i++)
            {
                if (fichiers[i].Nom.Equals(nom, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }

           public void Ajouter(Fichier fichier)
        {
            if (Nbr_fichiers < 30)
            {
                fichiers[Nbr_fichiers] = fichier;
                Nbr_fichiers++;
            }
            else
            {
                Console.WriteLine("Le répertoire est plein !");
            }
        }

        public void AfficherPDFs()
        {
            Console.WriteLine("Fichiers PDF :");
            bool found = false;
            for (int i = 0; i < Nbr_fichiers; i++)
            {
                if (fichiers[i].Extension.ToLower() == "pdf")
                {
                    Console.WriteLine($"- {fichiers[i]}");
                    found = true;
                }
            }
            if (!found) Console.WriteLine("Aucun fichier PDF trouvé.");
        }

          public void Supprimer(string nom)
        {
            int index = Rechercher(nom);
            if (index != -1)
            {
                for (int i = index; i < Nbr_fichiers - 1; i++)
                {
                    fichiers[i] = fichiers[i + 1];
                }
                fichiers[Nbr_fichiers - 1] = null;
                Nbr_fichiers--;
                Console.WriteLine($"Fichier '{nom}' supprimé.");
            }
            else
            {
                Console.WriteLine("Fichier introuvable.");
            }
        }

        public void Renommer(string ancienNom, string nouveauNom)
        {
            int index = Rechercher(ancienNom);
            if (index != -1)
            {
                fichiers[index].Nom = nouveauNom;
                Console.WriteLine($"Fichier renommé en '{nouveauNom}'.");
            }
            else
            {
                Console.WriteLine("Fichier introuvable.");
            }
        }
        public void ModifierTaille(string nom, float nouvelleTaille)
        {
            int index = Rechercher(nom);
            if (index != -1)
            {
                fichiers[index].Taille = nouvelleTaille;
                Console.WriteLine($"Taille du fichier '{nom}' modifiée.");
            }
            else
            {
                Console.WriteLine("Fichier introuvable.");
            }
        }

        public float GetTaille()
        {
            float total = 0;
            for (int i = 0; i < Nbr_fichiers; i++)
            {
                total += fichiers[i].Taille;
            }
            return total / 1024; // Conversion en MO
        }

    }
}
