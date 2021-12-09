using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserversProject
{
    public abstract class Subject
    {
        // private Observer[] observers = new Observer[] { };
        //public virtual void Attach(Observer[] o) { }
        //public virtual void Detach(Observer[] o) { }
        //public virtual void Notify() { }
        private List<Observer> observers = new List<Observer>();
        public virtual void Attach(Observer o)
        { 
            observers.Add(o);
        } //observers.Append(o);
        public virtual void Detach(Observer o)
        { 
            observers.Remove(o); 
        } 
        public virtual void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }
       
    }

}
