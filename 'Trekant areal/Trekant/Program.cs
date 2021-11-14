using System;

namespace Trekant
{
    class Program
    {
        static void Main(string[] args)
        {
            //variabler
            Double H, G, A;

            //Input
            Console.WriteLine("Højde:");
            H = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("grundlinje:");
            G = Convert.ToDouble(Console.ReadLine());


            //Formler

            A = (H * G) / 2;

            //Print resultater
            Console.WriteLine("Areal: {0}", A);

            Console.ReadKey();
        }
    }
}
