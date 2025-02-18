using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie2c_.tp2
{
    class Biblio
    {
        private List<Document> documents = new List<Document>();

        public void AjouterDocument(Document doc)
        {
            documents.Add(doc);
        }

        public void AfficherDictionnaires()
        {
            Console.WriteLine("\nDictionnaires :");
            foreach (var doc in documents)
            {
                if (doc is Dictionnaire)
                    Console.WriteLine(doc.Description());
            }
        }

        public void AfficherTousLesAuteurs()
        {
            Console.WriteLine("\nAuteurs des livres :");
            foreach (var doc in documents)
            {
                if (doc is Livre livre)
                    Console.WriteLine($"ID: {livre.ID} | Auteur: {livre.Auteur}");
            }
        }

        public void AfficherToutesLesDescriptions()
        {
            Console.WriteLine("\nListe des documents :");
            foreach (var doc in documents)
            {
                Console.WriteLine(doc.Description());
            }
        }
    }
}
