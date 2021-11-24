using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PersonRepository personRepo = new PersonRepository();

        public ObservableCollection<PersonViewModel> PersonVM { get; set; }

        private PersonViewModel selectedPerson;

        public PersonViewModel SelectedPerson
        {
            get { return selectedPerson; }
            set { selectedPerson = value;
                OnPropertyChanged("SelectedPerson");
            }
        }



        public MainViewModel()
        {
            List<Person> persons = personRepo.GetAll();
            PersonVM = new ObservableCollection<PersonViewModel>();
            foreach(Person p in persons)
            {
                PersonVM.Add(new PersonViewModel(p));
            }
        }

        public void AddDefaultPerson()
        {
            personRepo.Add("Specify FirstName", "Specify LastName", 0, "Specify Phone");
            List<Person> persons = personRepo.GetAll();
            PersonVM.Add(new PersonViewModel(persons[persons.Count-1]));
            SelectedPerson = PersonVM[PersonVM.Count - 1];
            
        }

        public void DeleteSelectedPerson()
        {
            SelectedPerson.DeletePerson(personRepo);
            PersonVM.Remove(SelectedPerson);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // Implement the rest of this MainViewModel class below to 
        // establish the foundation for data binding !

    }
}
