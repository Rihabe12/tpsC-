using serie2c_.tp1;
using serie2c_.tp2;

internal class Program
{
    private static void Main(string[] args)
    {
        Directeur directeur = Directeur.GetInstance();
        GestionEmployes gestion = directeur.GetGestionEmployes();

        gestion.AjouterEmploye(new Employee("Alice", 12000, "Développeur", new DateTime(2020, 5, 12)));
        gestion.AjouterEmploye(new Employee("Bob", 15000, "Chef de projet", new DateTime(2018, 3, 22)));
        gestion.AjouterEmploye(new Employee("Charlie", 10000, "Technicien", new DateTime(2021, 8, 15)));

 
        Console.WriteLine("Liste des employés :");
        gestion.AfficherEmployes();

    
        Console.WriteLine($"\nSalaire total : {gestion.CalculerSalaireTotal()} Dhs");
        Console.WriteLine($"Salaire moyen : {gestion.CalculerSalaireMoyen()} Dhs");

        
        gestion.SupprimerEmploye("Alice");
        Console.WriteLine("\nAprès suppression d'Alice :");
        gestion.AfficherEmployes();



        //tp2
        Livre livre1 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", 120);
        Dictionnaire dico1 = new Dictionnaire("Larousse", "Français", 50000);

        Console.WriteLine(livre1.Description());
        Console.WriteLine(dico1.Description());

        Console.ReadLine();
    }
}