using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public abstract class Merchandise : IValuable
    {
        public string ItemId { get; set; }

        public override string ToString() //Ctrl + k+c = comment -> ctrl + k + u = Uncomment
        {
            return $"ItemId: {ItemId}";
        }
        public abstract double GetValue();


    }
}

