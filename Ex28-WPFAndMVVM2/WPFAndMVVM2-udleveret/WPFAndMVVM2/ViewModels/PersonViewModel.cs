using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class PersonViewModel
    {
        //private Person person = new Person();
        //private List<Person> person = new List<Person>();
        private Person person = new Person();

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public PersonViewModel(Person person)
        {
            //Vær opmærksom på implementeringen af PersonViewModel-klassens constructor,
            //som skal sørge for at initialisere alle klassens medlemmer.

            this.person = person;
            this.FirstName = person.FirstName;
            this.LastName = person.LastName;
            this.Age = person.Age;
            Phone = person.Phone;
        }
        public void DeletePerson(PersonRepository personRepo)
        {
            personRepo.Remove(this.person.Id);
        }
    }
}
