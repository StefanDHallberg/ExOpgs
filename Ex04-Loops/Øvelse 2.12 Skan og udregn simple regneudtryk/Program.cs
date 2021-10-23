using System;

namespace Øvelse_2._12_Skan_og_udregn_simple_regneudtryk
{
    class Program
    {
        public static double Sum(double nummer1, double nummer2, double nummer3)
        {
            double total;
            total = nummer1 + nummer2 + nummer3;
            return total;
        }
        static void Main(string[] args)
        {
            Console.Write("\n\nUdregnelse af 3 numre vha. Static Method. (kun + & -) \n" +
            "--------------------------------------------------\n");
            Console.Write("Indtast Først Nummer: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Indtast Andet Nummer: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Indtast Tredje Nummer: ");
            double n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDin udregnelsen: {0} \n", Sum(n1, n2, n3));
            Console.ReadKey();




        }
    }
}
