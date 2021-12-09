using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserversProject
{
    public class Student : Observer
    {
        private Academy subject;

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public string Name { get; }

        public Student(Academy subject, string name)
        {
            this.subject = subject;
            Name = name;

        }

        public override void Update()
        {
            Console.WriteLine($"Studerende {Name} modtog nyheden {subject.Message} fra akademiet {subject.Name}");
        }

    }
}
