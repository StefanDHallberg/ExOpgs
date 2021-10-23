using System;

namespace Opg2_1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Console.Write("Indsæt navn: ");
             string Name = Console.ReadLine();
             Console.Clear();
             Console.Write("Indsæt Alder: ");
             string Age = Console.ReadLine();
             Console.Clear();
             int.TryParse(Age, out int parsedAge);

             int intAge = parsedAge - 10;

             Console.WriteLine(Name + " " + intAge + " år ");
             Console.ReadKey(); 
            */

            Console.Write("Navn: ");
            string Navn = Console.ReadLine();
            Console.Clear();
            Console.Write("Alder tak: ");
            string Alder = Console.ReadLine();
            Console.Clear();
            int.TryParse(Alder, out int ParsedAlder);

            int intAlder = ParsedAlder-15;

            Console.WriteLine("Hej {0}, {1} ", Navn, intAlder + " år ");
            Console.ReadKey();
        }
    }
}
