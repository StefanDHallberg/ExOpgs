using System;

namespace Menu33
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuPrint = "Min fantastiske menu:\n\n" +
                "1. Gør dit\n2. Gør dat\n3. Gør noget\n4. Få svaret på livet, universet og alting\n\n" +
                "(Tryk menupunkt 1, 2, 3 eller 4)";
            Console.WriteLine(menuPrint);

            string message = "";
            string choice = Console.ReadLine();
            if (choice == "1") message = "Gør dit";
            else if (choice == "2") message = "Gør dat";
            else if (choice == "3") message = "Gør noget";
            else if (choice == "4") message = "42";
            else message = "Forkert valg";

            Console.WriteLine("Punkt {0} er valgt: {1}", choice, message);
            Console.WriteLine();
        }
    }
}
