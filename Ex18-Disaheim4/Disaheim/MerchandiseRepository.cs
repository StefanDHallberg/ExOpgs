using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Disaheim
{
    public class MerchandiseRepository : Merchandise
    {
        /*
         Ved nærmere eftersyn er det ikke heldigt, at Book og Amulet har hver deres repository samt metode i Utility til at returnere værdi.
         Hvis der kommer flere klasser til i arvehierarkiet under Merchandise, vil antallet af GetValueOfXX metoder samt repositories stige tilsvarende. 
         Da begge klasser er af typen Merchandise, burde det være muligt at lave et enkelt MerchandiseRepository, som erstatter de to: BookRepository og AmuletRepository. 

         På samme måde kan metoden GetValueOfMerchandise(Merchandise merchandise) erstatte de to metoder GetValueOfBook og GetValueOfAmulet i Utility-klassen.
         Denne metode skal naturligvis finde ud af, hvilken type parameteren merchandise virkelig er og så finde den korrekte værdi i forhold til de regler, der gælder for de pågældende typer.
         Udvalgte software designklasser fra DCD’et er vist forneden:
         */

        private List<Merchandise> merchandises = new List<Merchandise>();
        private List<Book> books = new List<Book>();
        private List<Amulet> amulets = new List<Amulet>();
        //private List<Amulet> a = new List<Amulet>();
        //= new List<Amulet>();

        Utility utility = new Utility();
        public void AddMerchandise(Merchandise merchandise)
        {
            //if (merchandise is Amulet amulet)
            //{
            //    amulets.Add(amulet);
            //}
            //if (merchandise is Book book)
            //{
            //    books.Add(book);
            //}
            merchandises.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemId)
        {
            Merchandise result = null;

            foreach (Merchandise a in merchandises)
            {
                if (a.ItemId == itemId)
                {
                    result = a;
                }
            }
            //return amulets.Find(x => x.ItemId.Contains(itemId));  //lambda constructor => expressions.
            //return books.Find(x => x.ItemId.Contains(itemId));
            return result;
        }
        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach (Merchandise a in merchandises)
            {
                totalValue += utility.GetValueOfMerchandise(a);
            }
            return totalValue;
        }

    }
}

