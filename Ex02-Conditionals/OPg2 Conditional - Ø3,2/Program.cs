using System;

namespace OPg2_Conditional___Ø3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Alder: ");
            string Alder = Console.ReadLine();

            int.TryParse(Alder, out int ParseAlder);
            int intAlder = ParseAlder;
            string message = "";

            if (intAlder > 0 && intAlder <= 12)
                message = "et barn";
            else if
                 (intAlder > 13 && intAlder <= 19)
                message = "en teenager";
            else if
                 (intAlder > 20 && intAlder <= 25)
                message = "en studerende";
            else if
                 (intAlder > 26 && intAlder <= 67)
                message = "i arbejde";
            else if
            (intAlder >= 68)
                message = "fucker gammel";


            Console.WriteLine("Du er " + message);
            Console.ReadKey();
        }       
    }
}
