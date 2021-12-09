using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public delegate void NotifyHandler();
    public class Academy:Organization
    {
        //public string  Name { get;}

        public NotifyHandler MessageChanged;

        private string message;

        public string Message
        {
            get { return message; }
            set
            {
                if (message != value)
                {
                    message = value;
                    OnMessageChanged();
                }
            }     
        }

        public Academy(string name, string address): base(name)
        {
            Address = address;
            //this.Name = name;
        }
        //public void Attach(IObserver o)
        //{
        //    Students += o.Update;
        //}
        //public void Detach(IObserver o)
        //{
        //    Students -= o.Update;
        //}
        public void OnMessageChanged()
        {
            MessageChanged.Invoke();
        }
    }
}
