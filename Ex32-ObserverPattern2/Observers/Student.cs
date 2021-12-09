using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserversProject
{
    public class Student : Person, IObserver
    {
        private ISubject academy;

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
       // public string Name { get; }

        public Student(ISubject academy, string name) : base(name)
        {
            this.academy = academy;
           

        }
        public void Update()
        {
            //academy.Message is Message;
            // Console.WriteLine($"Studerende {Name} modtog nyheden {subject.Message} fra akademiet {subject.Name}");
            Console.WriteLine($"Studerende {Name} modtog nyheden {academy.Message} fra akademiet {academy.Name}");
        }

    }
}
