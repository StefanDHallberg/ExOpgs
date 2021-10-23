using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem
{
    class Menu
    {
        public String Title;
        private MenuItem[] menuItems = new MenuItem[10];
        private int itemCount = 0;

        public Menu(string title)
        {
            Title = title; //constructors (special method) gør 2 ting på 1.gang (præcis samme navn som den klasse den er i
                           //i samme øjeblik objekt bliver - lavet blir titlen lavet
        }
        public void Show()
        {
            Console.WriteLine(Title);

            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine(menuItems[i].Title);
            }
            Console.WriteLine("\n(Tryk menupunkt eller 0 for at afslutte)");
        }
        public void AddMenuItem(string menuTitle)
        {

            menuItems[itemCount] = new MenuItem(menuTitle);
            itemCount++; // Increment with one; same as: ItemCount = ItemCount + 1

        }
        public int SelectMenuItem()
        {
            string id;
            int itemID = 0;
            bool Validation = false;

            while (!Validation)
            {
                id = Console.ReadLine();
                if (int.TryParse(id, out itemID))
                {
                    itemID = Convert.ToInt32(id);
                    if (itemID >=0 && itemID <= itemCount)
                    {
                        Validation = true;
                    }
                } if (!Validation)
                {
                    Console.WriteLine("Valid numbers only.");
                }
            }

            return itemID;
        }
    }
}
