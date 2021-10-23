using System;

namespace Opg2_IF_excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("WEEKEEEEND!");
            Console.Write("Vælg en dør: 1, 2 eller 3: ");
            string DørNr = Console.ReadLine();

            string Besked = "";

            if (DørNr == "1")
            {
                Besked = "Du har valgt NUMERO UNOOO!";
            }
            else if (DørNr == "2")
                Besked = "Du har valgt NUMERO DOOOO!";
            else if (DørNr == "3")
                Besked = "Du har valgt NUMERO TREEEEEEEES!";
            else
            {
                Besked = "Forkert valg, makker!";
            }
            Console.WriteLine(Besked);
            Console.ReadLine();
            */

            Console.WriteLine("WEEKEEEEND!");
            Console.Write("Vælg en dør: 1, 2 eller 3: ");
            string DørNr = Console.ReadLine();

            string Besked = (DørNr == "1") ? "Sø Ko" : "En traktor";
            Console.Write("Heldige vinder af {0}, da du valgte {1}.", Besked, DørNr);
            Console.ReadLine();


        }
    }
}
