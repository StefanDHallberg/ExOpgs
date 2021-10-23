using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Disaheim
{
    public class Controller
    {
        private List<Book> Books;
        private List<Amulet> Amulets;
        private List<Course> Courses;

        public Controller()//Dette er en constructor der hedder det samme som Klassen!
        {
            //initiating Book class to object to list?
            Books = new List<Book>();
            Amulets = new List<Amulet>();
            Courses = new List<Course>();
    }
}
