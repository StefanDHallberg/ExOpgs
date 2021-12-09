using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserversProject
{
    public class Academy : Organization, ISubject
    {
        private List<IObserver> students = new List<IObserver>();
        //private List<IObserver> students;
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
        public Academy(string address, string name) : base(name)
        {
            this.Address = address;
        }

        public virtual void Attach(IObserver o)
        {
            students.Add(o);
        } //observers.Append(o);
        public virtual void Detach(IObserver o)
        {
            students.Remove(o);
        }
        public void Notify()
        {
            foreach (IObserver o in students)
            {
                o.Update();
            }
        }
    }
}
