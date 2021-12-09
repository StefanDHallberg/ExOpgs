using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserversProject
{
    public class Student : Person, IObserver
    {
        private Academy subject;

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
       // public string Name { get; }

        public Student(Academy subject, string name) : base(name)
        {
            this.subject = subject;
           

        }
        public void Update()
        {
            //academy.Message is Message;
            // Console.WriteLine($"Studerende {Name} modtog nyheden {subject.Message} fra akademiet {subject.Name}");
            Console.WriteLine($"Studerende {Name} modtog nyheden {subject.Message} fra akademiet {subject.Name}");
        }

    }
}
