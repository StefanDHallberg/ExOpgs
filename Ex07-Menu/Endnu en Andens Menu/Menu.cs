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
        private MenuItem[] menuItems;
        private int itemCount = 0;

        public Menu(string title)
        {
            Title = title;
        }
        public void Show()
        {
            Console.WriteLine(Title);
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine(menuItems[i].Title);
            }
            Console.WriteLine("Vælg menupunkt eller 0 for at afslutte)");
        }

        public void AddMenuItem(string menuTitle)
        {
            if(menuItems == null)
            {
                menuItems = new MenuItem[10];
            }
            menuItems[itemCount] = new MenuItem(menuTitle);
            itemCount++;
        }

        public int SelectMenuItem()
        {
            string id;
            int itemID = 0;

            bool valid = false;
            while (!valid)
            {
                id = Console.ReadLine();
                if (int.TryParse(id, out itemID))
                {
                    itemID = Convert.ToInt32(id);
                    if (itemID >=0 && itemID <= itemCount)
                    {
                        valid = true;
                    }
                } if (!valid)
                {
                    Console.WriteLine("Your choice is invalid, try again boomer.");
                }
            }

            return itemID;
        }
    }
}
