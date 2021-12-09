using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Organization
    {
        public string Name { get;}
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Organization(string name)
        {
            this.Name = name;
          
        }
    }
}
