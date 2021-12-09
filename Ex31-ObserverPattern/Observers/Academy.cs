using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserversProject
{
    public class Academy : Subject
    {
        public string Name { get; }
        private string message;

        public string Message
        {
            get { return message; }
            set 
            {
               if (message != value)
                {
                    message = value;
                        Notify();
                }
            }
        }

        public Academy(string name)
        {
            Name = name;
        }
    }
}
