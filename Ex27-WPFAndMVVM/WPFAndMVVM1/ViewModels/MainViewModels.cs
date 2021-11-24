using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAndMVVM1.ViewModels
{
    public class MainViewModels : INotifyPropertyChanged
    {
        private string firstName = "Insert firstname here";

        public string FirstName
        {
            get { return firstName; }
            set { 
                firstName = value;
                OnPropertyChanged("FirstName");
                 }
        }

        private string lastName = "Insert lastname here";

        public string LastName
        {
            get { return lastName; }
            set { 
                lastName = value;
                //OnPropertyChanged("FirstName");
            }
        }

        private string fullName = "Insert fullname here";
        public string FullName
        {
            //get { return firstName + " " + lastName; }
            get { return fullName; }
            set
            {
                fullName = value;
                OnPropertyChanged("FullName");
            }
        }
        private int sliderBarText;

        public int SliderBarText
        {
            get { return sliderBarText; }
            set { 
                sliderBarText = value;
                OnPropertyChanged("FullName");
                }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged (string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));

            }

        }
    }
}
