namespace Disaheim
{
    public class Amulet : Merchandise
    {  
        public static double LowQualityValue = 12.5;
        public static double MediumQualityValue = 20;
        public static double HighQualityValue = 27.5;

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
        public Amulet(string itemId) //: this(quality == Level.medium + "")
        {
            base.ItemId = itemId;
            this.quality = Level.medium;
            // this.design = design;
        }
        public Amulet(string itemId, Level quality) : this(itemId, quality, "")
        { }
        public Amulet(string itemId, Level quality, string design) : this(itemId)
        {
            base.ItemId = itemId;
            this.quality = quality;
            this.design = design;
        }
        
        
        public override string ToString() //Ctrl + k+c = comment -> ctrl + k + u = Uncomment
        {
            return $"ItemId: {ItemId}, Quality: {quality}, Design: {design}";
        }
        public override double GetValue()
        {
            if (Quality == Level.low)
            {
                return 12.5;
            }
            else if (Quality == Level.medium)
            {
                return 20;
            }
            else
            {
                return 27.5;
            }
        }
    }
}
