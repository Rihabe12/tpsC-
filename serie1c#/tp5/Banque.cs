using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie1c_.tp5
{
    class Banque
    {
        private List<CompteBancaire> comptes = new List<CompteBancaire>();

        public void CreerCompte(string numCompte, string titulaire, double soldeInitial)
        {
            comptes.Add(new CompteBancaire(numCompte, titulaire, soldeInitial));
            Console.WriteLine($"Compte {numCompte} créé avec succès !");
        }

        public CompteBancaire RechercherCompte(string numCompte)
        {
            return comptes.Find(c => c.NumCompte == numCompte);
        }

        public void AfficherTousLesComptes()
        {
            if (comptes.Count == 0)
            {
                Console.WriteLine("Aucun compte bancaire enregistré.");
                return;
            }

            Console.WriteLine("Liste des comptes :");
            foreach (var compte in comptes)
            {
                Console.WriteLine($"- {compte.NumCompte} | {compte.Titulaire} | {compte.Solde} Dhs");
            }
        }

        public void SupprimerCompte(string numCompte)
        {
            var compte = RechercherCompte(numCompte);
            if (compte != null)
            {
                comptes.Remove(compte);
                Console.WriteLine($"Compte {numCompte} supprimé !");
            }
            else
            {
                Console.WriteLine("Compte introuvable !");
            }
        }

        public void Transfert(string sourceNum, string destinationNum, double montant)
        {
            var source = RechercherCompte(sourceNum);
            var destination = RechercherCompte(destinationNum);

            if (source == null || destination == null)
            {
                Console.WriteLine("L'un des comptes n'existe pas.");
                return;
            }

            if (source.Debiter(montant))
            {
                destination.Crediter(montant);
                Console.WriteLine($"Transfert de {montant} Dhs de {sourceNum} vers {destinationNum} réussi.");
            }
        }
    }
}
