using System;
using serie1c_.tp1;
using serie1c_.tp2;
using serie1c_.tp5;

class Program
{
    static void Main()
    {
        // Repertoire rep = new Repertoire("Documents");


        //rep.Ajouter(new Fichier("Rapport", "pdf", 500));
        //rep.Ajouter(new Fichier("Code", "cs", 120));
        //rep.Ajouter(new Fichier("Dessin", "jpg", 800));

        //rep.Afficher();


        //Console.WriteLine("\nRecherche du fichier 'Rapport' :");
        //int index = rep.Rechercher("Rapport");
        //Console.WriteLine(index != -1 ? $"Fichier trouvé à l'indice {index}." : "Fichier introuvable.");


        //Console.WriteLine("\nAffichage des fichiers PDF :");
        //rep.AfficherPDFs();

        //rep.ModifierTaille("Rapport", 600);

        //rep.Renommer("Code", "Script");

        //rep.Supprimer("Dessin");

        //Console.WriteLine("\nRépertoire après modifications :");
        //rep.Afficher();

        //Console.WriteLine($"\nTaille totale du répertoire: {rep.GetTaille()} MO");
        //Projet projet = new Projet("P123", "Développement d'une application", 4);

        //projet.AjouterProgrammeur(new Programmeur(1, "Alice", 4));
        //projet.AjouterProgrammeur(new Programmeur(2, "Bob", 4));
        //projet.AjouterProgrammeur(new Programmeur(3, "Charlie", 4));

        //projet.AfficherListeProgrammeurs();

        // projet.AjouterConsommationCafe(1, 0, 5); // Alice boit 5 tasses en semaine 1
        //projet.AjouterConsommationCafe(2, 0, 8); // Bob boit 8 tasses en semaine 1
        //projet.AjouterConsommationCafe(3, 1, 3); // Charlie boit 3 tasses en semaine 2

        // Console.WriteLine("\nCafé total consommé en semaine 1 : " + projet.CafeTotalSemaine(0));


        //Console.WriteLine("\nDétails du programmeur 1:");
        //projet.AfficherProgrammeur(1);


        //Console.WriteLine("\nSuppression de Bob...");
        // projet.SupprimerProgrammeur(2);

        //projet.AfficherListeProgrammeurs();

        Banque banque = new Banque();
        bool quitter = false;

        while (!quitter)
        {
            Console.WriteLine("\n===== MENU PRINCIPAL =====");
            Console.WriteLine("1. Créer un compte");
            Console.WriteLine("2. Afficher tous les comptes");
            Console.WriteLine("3. Rechercher un compte");
            Console.WriteLine("4. Créditer un compte");
            Console.WriteLine("5. Débiter un compte");
            Console.WriteLine("6. Afficher l'historique des transactions");
            Console.WriteLine("7. Transférer de l'argent");
            Console.WriteLine("8. Supprimer un compte");
            Console.WriteLine("9. Quitter");
            Console.Write("Votre choix : ");

            string choix = Console.ReadLine();
            Console.WriteLine();

            switch (choix)
            {
                case "1":
                    Console.Write("Numéro du compte : ");
                    string numCompte = Console.ReadLine();
                    Console.Write("Nom du titulaire : ");
                    string titulaire = Console.ReadLine();
                    Console.Write("Solde initial : ");
                    double solde = double.Parse(Console.ReadLine());
                    banque.CreerCompte(numCompte, titulaire, solde);
                    break;

                case "2":
                    banque.AfficherTousLesComptes();
                    break;

                case "3":
                    Console.Write("Numéro du compte : ");
                    var compte = banque.RechercherCompte(Console.ReadLine());
                    if (compte != null)
                        Console.WriteLine($"{compte.NumCompte} | {compte.Titulaire} | {compte.Solde} Dhs");
                    else
                        Console.WriteLine("Compte introuvable.");
                    break;

                case "4":
                    Console.Write("Numéro du compte : ");
                    var compteCredit = banque.RechercherCompte(Console.ReadLine());
                    if (compteCredit != null)
                    {
                        Console.Write("Montant à créditer : ");
                        double montant = double.Parse(Console.ReadLine());
                        compteCredit.Crediter(montant);
                    }
                    else
                        Console.WriteLine("Compte introuvable.");
                    break;

                case "5":
                    Console.Write("Numéro du compte : ");
                    var compteDebit = banque.RechercherCompte(Console.ReadLine());
                    if (compteDebit != null)
                    {
                        Console.Write("Montant à débiter : ");
                        double montant = double.Parse(Console.ReadLine());
                        compteDebit.Debiter(montant);
                    }
                    else
                        Console.WriteLine("Compte introuvable.");
                    break;

                case "6":
                    Console.Write("Numéro du compte : ");
                    var compteHist = banque.RechercherCompte(Console.ReadLine());
                    if (compteHist != null)
                        compteHist.AfficherHistorique();
                    else
                        Console.WriteLine("Compte introuvable.");
                    break;

                case "7":
                    Console.Write("Numéro du compte source : ");
                    string source = Console.ReadLine();
                    Console.Write("Numéro du compte destination : ");
                    string destination = Console.ReadLine();
                    Console.Write("Montant à transférer : ");
                    double montantTransfert = double.Parse(Console.ReadLine());
                    banque.Transfert(source, destination, montantTransfert);
                    break;

                case "8":
                    Console.Write("Numéro du compte à supprimer : ");
                    banque.SupprimerCompte(Console.ReadLine());
                    break;

                case "9":
                    quitter = true;
                    break;

                default:
                    Console.WriteLine("Choix invalide !");
                    break;
            }
        }
    }
}

