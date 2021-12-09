using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserversProject
{
    public delegate void NotifyHandler();
    public class Academy : Organization
    {
       
        public NotifyHandler MessageChanged;
        //private List<IObserver> students = new List<IObserver>();
        
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
                    OnMessageChanged();
                }
            }
        }
        public Academy(string address, string name) : base(name)
        {
            this.Address = address;
        }

        
        public void OnMessageChanged()
        {
            if (MessageChanged != null)
                MessageChanged.Invoke();
            //Invoke kalder på alle tilknyttet metoder i delegaten - Altså -NotifyHandler MessageChanged.
            //præcis som bare at kalde på MessageChanged();
            //if (MessageChanged != null)
            //MessageChanged();

        }
    }
}
