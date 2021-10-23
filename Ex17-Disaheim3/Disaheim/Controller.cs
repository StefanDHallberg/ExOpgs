using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {

        //Implementér Controller-klassen i C#, hvor du anvender List<T>-datatypen i stedet for arrays til de to C#-properties Books og Amulets.
        //Overvej hvad <T> står for, og hvordan det udtrykkes i din kode.
        //De to properties Books og Amulets skal initialiseres i constructor’en for Controller-klassen.
        //Overvej hvad det indebærer.Hvad er nødvendigt for at initialisere de to properties?
        //Implementér de to operationer AddToList() i designklassen som C# metoder. Kigger du nærmere efter,
        //er der faktisk kun én operation, men med to forskellige typer af parametre. Dette kan løses med metode-overloading i C#

        public List<Book> Books;
        public List<Amulet> Amulets;
        public List<Course> Courses;

        public Controller() //Dette er en constructor der hedder det samme som Klassen!
        {
           Books = new List<Book>();
           Amulets = new List<Amulet>();
           Courses = new List<Course>();

        }

        public void AddToList(Book book)
        {
            Books.Add(book);
        }   
        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }
        public void AddToList(Course course)
        {
            Courses.Add(course);
        }
    }
}
