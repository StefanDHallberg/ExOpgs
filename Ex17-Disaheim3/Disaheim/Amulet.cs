using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        private string design;
        public string Design
        {
            get { return design; }
            set { design = value; }
        }
        private Level quality;

        public Level Quality
        {
            set { quality = value; }
            get { return quality; }
            
        }
        public Amulet(string itemId, Level quality, string design) : this(itemId)
        {
            base.ItemId = itemId;
            this.quality = quality;
            this.design = design;
        }
        public Amulet(string itemId, Level quality) : this(itemId, quality, "")
        {
            
        }
        public  Amulet(string itemId) //: this(quality == Level.medium + "")
        {
            base.ItemId = itemId;
            this.quality = Level.medium;
           // this.design = design;
        }



        public override string ToString() //Ctrl + k+c = comment -> ctrl + k + u = Uncomment
        {
            return $"ItemId: {ItemId}, Quality: {quality}, Design: {design}";
        }



    }
}
