using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserversProject
{
    public class ConcreteSubject : Subject
    {
        private int state;

        public int State
        {
            get { return state; }
            set 
            {
                if(state != value)
                {
                    state = value;
                    Notify();

                }


            }
        }



    }
}
