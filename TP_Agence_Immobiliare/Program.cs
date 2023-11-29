using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Agence_Immobiliare
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bien> Appartements = new List<Bien>();
            List<Bien> Maisons = new List<Bien>();
            string numBien, suppr;
            bool existe = false;
            Bien bien1 = new Bien("1a","Rouen, 76000", 100, 5, "A", "AL", 650);
            Bien bien2 = new Bien("1b", "Paris, 75000", 150, 6, "A", "V", 1900);
            Bien bien3 = new Bien("2a", "Yville sur Seine, 76530", 550, 9, "M", "AV", 180000);
            Bien bien4 = new Bien("1c", "Rouen, 76000", 95, 4, "M", "L", 600);
            Agence agence1 = new Agence();
            agence1.ajoute(bien1);
            agence1.ajoute(bien2);
            agence1.ajoute(bien3);
            agence1.ajoute(bien4);
            
            agence1.afficheTouslesBiens();

            Console.WriteLine("Les biens qui sont des appartements sont : ");
            foreach (Bien unBien in Appartements) { Appartements = agence1.DonneTouslesApparts();}
            Console.WriteLine("Les biens qui sont des maisons sont : ");
            foreach (Bien unBien in Maisons) { Maisons = agence1.DonneToutesLesMaisons(); }
            Console.WriteLine("Quel est le numéro de bien ?");
            numBien = Console.ReadLine();
            existe = agence1.EstPresent(numBien);
            if (existe == true)
            {
                Console.WriteLine("Le bien est présent");
            }
            else
            {
                Console.WriteLine("Le bien n'est pas présent");
            }
            
            Console.WriteLine("Voulez-vous supprimer un bien ? (o/n)");
            suppr = Console.ReadLine();
            if (suppr == "o")
            {
                Console.WriteLine("Quel bien voulez-vous supprimer ?");
                numBien = Console.ReadLine();
                agence1.SupprimeBien(numBien);
                Console.WriteLine("Le bien " + numBien + " a bien été supprimé");
                Console.WriteLine("----------------------------------");
                agence1.afficheTouslesBiens();
            }
            else
            {
                agence1.afficheTouslesBiens();
            }
            Console.ReadLine();
        }
    }
}
