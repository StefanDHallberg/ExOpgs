using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserversProject
{
    public class Student : Person, IObserver
    {
       // private Academy subject;

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
       // public string Name { get; }

        public Student(string name) : base(name)
        {
           // this.subject = subject;
        }
        public void Update(object sender, EventArgs e)
        {
            //academy.Message is Message;
           // Console.WriteLine($"Studerende {Name} modtog nyheden {subject.Message} fra akademiet {subject.Name}");
            if (sender is Academy academyInfo)
                Console.WriteLine($"Studerende {Name} modtog nyheden {academyInfo.Message} fra akademiet {academyInfo.Name}");
        }

    }
}
