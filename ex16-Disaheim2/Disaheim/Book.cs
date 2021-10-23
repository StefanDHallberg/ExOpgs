using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book
    {
        private string itemID;

        public string ItemID
        {
            get { return itemID; }
           // set { itemID = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
         //   set { title = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
          //  set { price = value; }
        }
        public Book(string itemID)
        {
            this.itemID = itemID;
        }
        public Book(string itemID, string title)
        {
            this.itemID = itemID;
            this.title = title;
        }
        public Book(string itemID, string title, double price)
        {
            this.itemID = itemID;
            this.title = title;
            this.price = price;
        }
        public override string ToString() //Ctrl + k+c = comment -> ctrl + k + u = Uncomment
        {
            return $"ItemId: {itemID}, Title: {title}, Price: {price}";
        }

    }
}
