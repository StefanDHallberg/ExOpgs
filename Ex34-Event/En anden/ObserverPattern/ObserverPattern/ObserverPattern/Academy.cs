using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public delegate void EventHandler(object sender, EventArgs e);
    public class Academy : Organization, INotifyPropertyChanged
    {
        //public string  Name { get;}

        //public event EventHandler MessageChanged;

        public event PropertyChangedEventHandler PropertyChanged;

        private string message;

        public string Message
        {
            get { return message; }
            set
            {
                if (message != value)
                {
                    message = value;
                    OnMessageChanged("Message");
                }
            }
        }

        public Academy(string name, string address) : base(name)
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
        protected void OnMessageChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
