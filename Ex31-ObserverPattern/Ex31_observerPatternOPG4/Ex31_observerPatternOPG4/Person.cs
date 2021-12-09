using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_observerPatternOPG4
{
    public abstract class Person : Observer
    {
        public string Name { get; }
        public Person(string Name)
        {
            this.Name = Name;
        }
    }
}
