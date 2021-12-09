using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Student:Person, IObserver
    {
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        //public string Name { get; }

        public Student(string name) : base (name)
        {
            //Name = name;       
        }
        public void Update(object sender, EventArgs e)
        {
          if(sender is Academy academyInfo)
          Console.WriteLine("Studerende {0} modtog nyheden {1} fra akademiet {2}", Name, academyInfo.Message, academyInfo.Name);

        }
    }
}
