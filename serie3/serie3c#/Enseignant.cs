using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace serie3c_
{
    class Enseignant : Personnel
    {
        private Grade grade;
        private float VH;
        private float heures_supp;
        private Dictionary<String,List<Etudiant>> groupes= new Dictionary<String , List<Etudiant>>();

        
        public Enseignant(string code, string nom, string prenom, string bureau, double salaire, double prime, 
            Grade grade,float VH,float h) : base(code, nom, prenom, bureau, salaire, prime)
        {
            this.grade = grade;
            this.VH = VH;
            heures_supp = h;
          
        }
        public Grade grades
        {
            get { return grade; }
            set { grade = value; }
        }
        public float vh
        {
            get { return VH; }
            set { VH = value; }
        }
        public float HEURES_S
        {
            get { return heures_supp; }
            set { heures_supp = value; }
        }

        public override double CalculerSalaire()
        {
            return Salaire+ Prime+(VH * (int) grade);
        }

        public void AjouterGroupe(String Nom)
        {
            groupes[Nom] = new List<Etudiant>();
        }
        public void AfficherGroupe()
        {
            
            Console.WriteLine($" Enseignant{Nom} {Prenom}, Grade: {grade}");
            foreach (var i in groupes)
            {
                Console.WriteLine($" groupe {i.Key}");
                foreach( var etudiant in i.Value)
                {
                    Console.WriteLine($" {etudiant.Nom} {etudiant.Prenom}, Niveau: {etudiant.Niveau}, et de moyenne {etudiant.Moyenne}");
                }
            }

        }
    }
}
