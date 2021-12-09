using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_observerPatternOPG4
{
    public class Academy : Organization
    {
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value;
                Notify();
            }
        }
        public Academy(string name) : base(name) //Constructor chaining
        {
            
        }
    }
}
