using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Disaheim
{
    public class Controller
    {
        //private List<Book> Books;
        //private List<Amulet> Amulets;
        //private List<Course> Courses;
        private List<IValuable> valuables = new List<IValuable>();

        public ValuableRepository ValuableRepo { get; set; }

       
        public Controller()//Dette er en constructor der hedder det samme som Klassen!
        {
            //initiating Book class to object to list?
            //Books = new List<Book>();
            //Amulets = new List<Amulet>();
            //Courses = new List<Course>();
            ValuableRepo = new ValuableRepository();
        }

        public void AddToList(IValuable valuable)
        {
           // valuables.Add(valuable);
        }
    }
}
