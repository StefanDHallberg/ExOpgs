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

        // Implement the rest of this MainViewModel class below to 
        // establish the foundation for data binding !
        public ObservableCollection<PersonViewModel> PersonsVM { get; set; }

        private PersonViewModel selectedPerson;
        public PersonViewModel SelectedPerson
        {
            get { return selectedPerson; }
            set 
            { 
                if (selectedPerson != value)
                { 
                selectedPerson = value;
                OnPropertyChanged("SelectedPerson");
                }
            }
        }


        //Initialisér PersonsVM-property’en i MainViewModel’s constructor, dvs. sørg for i PersonsVM at
        //oprette et korrekt initialiseret PersonViewModel - objekt for hvert Person-objekt i personRepo.
        public MainViewModel()
        {
           PersonsVM = new ObservableCollection<PersonViewModel>(); //Initilizing PersonVM

            List<Person> persons = personRepo.GetAll();
            foreach (Person p in persons)
            {
                PersonsVM.Add(new PersonViewModel(p));
            }

        }

        public void AddDefaultPerson()
        {
            personRepo.Add("Specify FirstName", "Specify LastName", 0, "Specify Phone");
            List<Person> persons = personRepo.GetAll();
            PersonsVM.Add(new PersonViewModel(persons[persons.Count - 1]));
            SelectedPerson = PersonsVM[PersonsVM.Count - 1];
        }


        public void DeleteSelectedPerson()
        {
            SelectedPerson.DeletePerson(personRepo);
            PersonsVM.Remove(SelectedPerson);
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
    }
}
