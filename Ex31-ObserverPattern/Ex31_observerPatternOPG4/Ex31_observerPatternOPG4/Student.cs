using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_observerPatternOPG4
{
    public class Student : Person
    {
        private Academy subject;
        private string message;
        public string Message
        {
            get { return message; }
            set { this.message = value; }
        }
        public Student(Academy subject, string Name) : base(Name) //Constructor chaining
        {
            this.subject = subject;
        }
        public override void Update()
        {
            Message = subject.Message;
            Console.WriteLine("Studerende {0} modtog nyheden '{1}' fra akademiet {2}", Name, Message, subject.Name);
        }
    }
}
