using System;

namespace Persistens
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Anders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);
            Person person1 = new Person("BBBnders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);
            Person person2 = new Person("CCCnders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);
            Person person3 = new Person("DDDDnders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);
            Person person4 = new Person("QQQQQnders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);
            Person[] persons = new Person[5];
            persons[0] = person;
            persons[1] = person1;
            persons[2] = person2;
            persons[3] = person3;
            persons[4] = person4;


            DataHandler handler = new DataHandler("Data.txt");
            handler.SavePersons(persons);
            

            Console.Write("Writing Person: ");
            Console.WriteLine(person.MakeTitle());

            handler.LoadPersons();

            Console.ReadLine();

        }
    }
}
