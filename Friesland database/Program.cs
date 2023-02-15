using System;
using System.Collections.Generic;

namespace Friesland_database
{
    class Program
    {
        public static List<Friesland> landen = new List<Friesland>();
        public static string userinput;
        public static string name, milk, bread;
        static void Main(string[] args) {
            landen.Add(new Friesland() {Naam = "Orgineel", Brood = "Suikerbrood", Melk = "Karnemelk" });
            while (true) {
                Console.Clear();
                Console.WriteLine("Friesland bekijken of toevoegen(B of T)");
                userinput = Console.ReadKey(true).Key.ToString();
                if (userinput == "B") {
                    FrieslandBegluren();
                } else if (userinput == "T") {
                    FrieslandGenerator();
                } else {
                    Console.WriteLine("Error Input Not Correct");
                } 
                Console.ReadKey(true); 
            }
        }
        public static void FrieslandGenerator() {
            Console.WriteLine("Hoe gaat je nieuwe friesland heten?");
            name = Console.ReadLine();
            Console.WriteLine("Wat voor melk hebben ze daar?");
            milk = Console.ReadLine();
            Console.WriteLine("Wat voor brood eten ze daar?");
            bread = Console.ReadLine();
            landen.Add(new Friesland(name, milk, bread));
            Console.WriteLine("Dankuwel je nieuwe friesland staat klaar");
        }
        public static void FrieslandBegluren() {
            foreach (Friesland Land in landen) {
                Console.WriteLine(Land.Naam + " : Hier hebben ze " + Land.Brood + " en " + Land.Melk);
            }
        }
    } 
}




    public class Friesland
    {
        public string Naam;
        public string Melk;
        public string Brood;

        //Constructors
        public Friesland() {
            
        }
        public Friesland(string naam,string melk, string brood) {
            Melk = melk;
            Brood = brood;
            Naam = naam;
        }
    }
