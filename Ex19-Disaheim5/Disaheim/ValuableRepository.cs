using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository
    {
        private List<IValuable> valuables = new List<IValuable>();
        private List<Book> books = new List<Book>();
        private List<Amulet> amulets = new List<Amulet>();
        //private List<Amulet> a = new List<Amulet>();
        //= new List<Amulet>();

        // Utility utility = new Utility();
        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            IValuable result = null;

            foreach (IValuable I in valuables)
            {
                if (I is Merchandise M)
                {
                    if (id == M.ItemId)
                    {
                        return M;
                    }
                }
                else if (I is Course C)
                {
                    if (id == C.Name)
                    {
                        return C;
                    }
                }
                
            }
            //return amulets.Find(x => x.ItemId.Contains(itemId));  //lambda constructor => expressions.
            //return books.Find(x => x.ItemId.Contains(itemId));
            return result;
        }
        public double GetTotalValue()
        {

            double totalValue = 0;
            foreach (IValuable I in valuables)
            {
                if (I is Merchandise M)
                { totalValue += M.GetValue(); }

                else if (I is Course C)
                { totalValue += C.GetValue(); }
            }
            return totalValue;
        }

        public int Count()
        {
            return valuables.Count;
        }




    }
}
