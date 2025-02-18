using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie1c_.tp5
{
    class CompteBancaire
    {
        public string NumCompte;
        public string Titulaire;
        public double Solde;
        public List<string> HistoriqueTransactions;

        public CompteBancaire(string numCompte, string titulaire, double soldeInitial)
        {
            NumCompte = numCompte;
            Titulaire = titulaire;
            Solde = soldeInitial;
            HistoriqueTransactions = new List<string>();
            AjouterTransaction($"Création du compte avec {soldeInitial} Dhs.");
        }

        private void AjouterTransaction(string transaction)
        {
            HistoriqueTransactions.Add($"{DateTime.Now}: {transaction}");
        }

        public void Crediter(double montant)
        {
            Solde += montant;
            AjouterTransaction($"Crédit de {montant} Dhs. Nouveau solde: {Solde} Dhs.");
        }

        public bool Debiter(double montant)
        {
            if (montant > Solde)
            {
                Console.WriteLine("Fonds insuffisants !");
                return false;
            }
            Solde -= montant;
            AjouterTransaction($"Débit de {montant} Dhs. Nouveau solde: {Solde} Dhs.");
            return true;
        }

        public void AfficherHistorique()
        {
            Console.WriteLine($"Historique des transactions pour {Titulaire} ({NumCompte}):");
            foreach (var transaction in HistoriqueTransactions)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}
