using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserversProject
{
    public interface ISubject
    {
        string Name { get; }
        string Message { get; }
        abstract void Attach(IObserver o);
        abstract void Detach(IObserver o);
        abstract void Notify();
       
    }

}
