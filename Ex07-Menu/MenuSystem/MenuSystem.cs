using System;

namespace MenuSystem
{
    public class MenuSystem
    {
       public static void Main(string[] args)
        {
            Menu mainMenu = new Menu("Min Fantastiske Menu: ");

            mainMenu.AddMenuItem("1. Gør dit: ");
            mainMenu.AddMenuItem("2. Gør dat: ");
            mainMenu.AddMenuItem("3. Gør noget: ");
            mainMenu.AddMenuItem("4. få svaret på livet, universet og alting!: ");
            

            mainMenu.Show();

            int itemID = mainMenu.SelectMenuItem();

            while (itemID != 0)
            {
                switch (itemID)
                {
                    case 0:
                        break;

                    case 1:
                        Console.WriteLine("Gør dit");
                        break;
                    case 2:
                        Console.WriteLine("Gør dat");
                        break;
                    case 3:
                        Console.WriteLine("Gør noget");
                        break;
                    case 4:
                        Console.WriteLine("42");
                        break;
                    default:
                        Console.WriteLine("Den er ikke helt god den der.");
                        break;
                }
                Console.WriteLine("For continuation press Enter.");
                Console.ReadLine();
                Console.Clear();
                mainMenu.Show();
                itemID = mainMenu.SelectMenuItem();
            }
        }
    }
}
