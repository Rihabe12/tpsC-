using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie1c_.tp2
{
    class Programmeur
    {
        public int Id;
        public string Nom;
        public int[] ConsommationCafe;

        public Programmeur(int id, string nom, int duree)
        {
            Id = id;
            Nom = nom;
            ConsommationCafe = new int[duree]; // Durée en semaines
        }

        public void AjouterConsommation(int semaine, int tasses)
        {
            if (semaine >= 0 && semaine < ConsommationCafe.Length)
            {
                ConsommationCafe[semaine] += tasses;
            }
            else
            {
                Console.WriteLine("Semaine invalide.");
            }
        }

        public int TotalCafe()
        {
            int total = 0;
            foreach (int tasses in ConsommationCafe)
            {
                total += tasses;
            }
            return total;
        }
    }
}
