using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserversProject
{
    public abstract class Organization 
    {

        public string Name { get; }

        public string Address { get; set; }
        public Organization(string name)
        {
            this.Name = name;
        }

    }
}
