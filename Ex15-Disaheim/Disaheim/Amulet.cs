using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet
    {
        private string itemID;

        public string ItemID
        {
            get { return itemID; }
         //   set { itemID = value; }
        }
        private string design;

        public string Design
        {
            get { return design; }
         //   set { design = value; }
        }
        private Level quality;

        public Level Quality
        {
            set { quality = value; }
            get { return quality; }
            
        }
        public Amulet(string itemID, Level quality, string design)
        {
            this.itemID = itemID;
            this.quality = quality;
            this.design = design;
        }
        public Amulet(string itemID, Level quality) : this(itemID, quality, "")
        {
            
        }
        public Amulet(string itemID) : this(itemID, Level.medium, "")
        {
            
        }

       
        
        public override string ToString() //Ctrl + k+c = comment -> ctrl + k + u = Uncomment
        {
            return $"ItemId: {itemID}, Quality: {quality}, Design: {design}";
        }



    }
}
