using System;

namespace Lommeregner_med_muligheder
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Afslut = false;
            Calculator Lom = new Calculator(); //tildelt object ny klasse
            double Num1 = 0, Num2 = 0;
            string MenuValg = "0";
            string Besked = "";
            while (!Afslut)
            {
                Console.Clear();
                Console.WriteLine("Hvad vil du gerne have udregnet?");
                Console.WriteLine("Indtast følgende Nummer: ");
                Console.WriteLine("1. Plus");
                Console.WriteLine("2. Minus");
                Console.WriteLine("3. Divider");
                Console.WriteLine("4. Gange");
                Console.WriteLine("9. Afslut program");
                try
                {
                    MenuValg = Convert.ToString(Console.ReadLine());
                    if (MenuValg == "1") Besked = "Plus";
                    else if (MenuValg == "2") Besked = "Minus";
                    else if (MenuValg == "3") Besked = "Divider";
                    else if (MenuValg == "4") MenuValg = "Gange";
                    else if (MenuValg == "9") MenuValg = "Afslutning af program.";
                    Console.Clear();
                    Console.WriteLine("Du har valgt: {0}. {1}", MenuValg, Besked);
                    Console.WriteLine("Indtast dit første tal: ");
                    Num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Indtast andet Tal: ");
                    Num2 = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Indtast venligst kun tal.");
                    Console.ReadKey();
                    continue;
                }
                switch(MenuValg) 
                {
                    case "1":
                        Console.WriteLine("Resultat: {0}", Lom.Plus(Num1, Num2)); //Kalder på Plus Metoden.
                        Console.WriteLine("Tryk på en vilkårlig tast for at komme tilbage til Menuen");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Resultat: {0}", Lom.Minus(Num1, Num2)); //Kalder på Minus Metoden.
                        Console.WriteLine("Tryk på en vilkårlig tast for at komme tilbage til Menuen");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Resultat: {0}", Lom.Divider(Num1, Num2)); //Kalder på Divider Metoden.
                        Console.WriteLine("Tryk på en vilkårlig tast for at komme tilbage til Menuen");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Resultat: {0}", Lom.Gange(Num1, Num2)); //Kalder på Gange Metoden.
                        Console.WriteLine("Tryk på en vilkårlig tast for at komme tilbage til Menuen");
                        Console.ReadKey();
                        break;
                    case "9":
                        Console.WriteLine("Tryk på en vilkårlig tast for at afslutte programmet."); //afslutter programmet ved at sætte min bool til true.
                        Afslut = true;
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
