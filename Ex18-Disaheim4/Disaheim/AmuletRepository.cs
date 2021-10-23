using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class AmuletRepository
    {

        private List<Amulet> amulets = new List<Amulet>();
        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemId)
        {
            return amulets.Find(x => x.ItemId.Contains(itemId));
        }

        public double GetTotalValue()
        { return GetTotalValue(); }

    }
}
