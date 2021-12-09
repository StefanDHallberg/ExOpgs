using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Student:Person, IObserver
    {
        private Academy subject;

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        //public string Name { get; }

        public Student(Academy subject, string name) : base (name)
        {
            this.subject = subject;
            //Name = name;       
        }
        public void Update()
        {
            
          Console.WriteLine("Studerende {0} modtog nyheden {1} fra akademiet {2}", Name, subject.Message, subject.Name);

        }
    }
}
