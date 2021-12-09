using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_observerPatternOPG4
{
    public abstract class Organization : Subject
    {
        private string name;
        public string Name
        {
            get { return name; }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public Organization(string Name)
        {
            this.name = Name;
        }
    }
}
