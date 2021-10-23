using System;
using System.Collections.Generic;
using System.Text;

namespace MenuSystem
{
    class Menu
    {
        public string Title;

        public int ItemCount = 0;

        public MenuItem[] MenuItems;

        public void Show()
        {
            Console.WriteLine(Title + "\n");
            for (int i = 0; i < ItemCount; i++)
            {
                Console.WriteLine("  " + MenuItems[i].Title);   
            }
            Console.WriteLine("\nTryk menupunkt eller 0 for at afslutte");
        }
    }
}
