using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserversProject
{
    public delegate void EventHandler(object sender, EventArgs e);

    public class Academy : Organization, INotifyPropertyChanged
    {
        // public NotifyHandler MessageChanged;
        //public event EventHandler MessageChanged;

        private string message;

        public event PropertyChangedEventHandler PropertyChanged;

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
        public Academy(string address, string name) : base(name)
        {
            this.Address = address;
        }

        

        protected void OnMessageChanged(string propertyName)
        {

            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));

            }
            //if (MessageChanged != null)
            //    MessageChanged.Invoke();
            //Invoke kalder på alle tilknyttet metoder i delegaten - Altså -NotifyHandler MessageChanged.
            //præcis som bare at kalde på MessageChanged();
            //if (MessageChanged != null)
            //MessageChanged(); 
        }
    }
}
