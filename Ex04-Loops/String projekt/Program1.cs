using System;

namespace NavnAlder32
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bruges til endeligt konsol output.
            string consoleOutput = ""; 

            // Få fat i navn.
            Console.Write("Indtast dit navn\t: "); 
            string myName = Console.ReadLine();

            // Få fat i alder.
            Console.Write("Indtast din alder\t: "); 
            string tempStrAge = Console.ReadLine();
            // Alder er i string format, så vi gør klar til konvertering,
            // ved at allokere en uint (alder kan kun være positiv).
            uint myAge; 
            // Konvertering forgår ved TryParse, så vi kan tjekke efter fejl.
            if (uint.TryParse(tempStrAge,out myAge))
            {
                // Lagrer status strengen (fundet afhængig af alder.
                string statusStr = "";

                if (myAge < 12) statusStr = "et barn";
                else if (myAge < 19) statusStr = "en teeneager";
                else if (myAge < 25) statusStr = "en studerende";
                else if (myAge < 67) statusStr = "i arbejde";
                else statusStr = "en pensionist";

                // Samler status strengen, myAge og myName til een output sætning
                // og assigner den til vores endelige output string.
                consoleOutput = myName + " er " + myAge + " år gammel og er " + statusStr + ".";
            } else consoleOutput = "That was not a valid age!"; // Denne string bruges i stedet som output, hvis der var konverteringsfejl.

            Console.WriteLine(consoleOutput); // Output vores endelige output string.
        }
    }
}
