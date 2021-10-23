using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Persistens
{
    public class DataHandler
    {
        private string dataFileName;
        public string DataFileName
        {
            get { return dataFileName; }
        }
        public DataHandler(string dataFileName)
        {
            this.dataFileName = dataFileName;
        }

        public void SavePerson(Person person)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(dataFileName);
                //Write a line of text
                sw.WriteLine(person.MakeTitle());
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        public Person LoadPerson()
        {
            Person person;
            String line;
            string[] array = new string[5];
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(dataFileName);
                //Read the first line of text
                line = sr.ReadLine();
                array = line.Split(';');
                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            person = new Person(array[0], DateTime.Parse(array[1]), double.Parse(array[2]), bool.Parse(array[3]), int.Parse(array[4]));
            return person;
        }
        public void SavePersons(Person[] persons)
        {
            StreamWriter sw = new StreamWriter(dataFileName);

            foreach (Person person in persons)
            {
                sw.WriteLine(person.MakeTitle());
            }
            sw.Close();

        }
        //public Person[] LoadPersons(int personAmount) 
        //{
        //    Person[] persons = new Person[10];
        //    StreamReader sr = new StreamReader(dataFileName);
        //    String line;
        //    List<String> personList = new List<String>(); //laver en liste som kan læses udfra.
        //    while ((line = sr.ReadLine()) != null)
        //    {
        //        personList.Add(line);
        //    }
        //    sr.Close();
        //    for (int i = 0; i < personList.Count; i++)
        //    {
        //        String myLine;
        //        string[] array = new string[5];
        //        array = line.Split(';');
        //        Person myPerson = new Person(array[0], DateTime.Parse(array[1]), double.Parse(array[2]), bool.Parse(array[3]), int.Parse(array[4]));
        //        Console.WriteLine(myPerson);
        //    }


        //    return persons;
        //}
        public Person[] LoadPersons()
        {
            Person[] person = new Person[10];
            string line;
            int i = 0;
            string[] array = new string[5];
            StreamReader sr = new StreamReader(dataFileName);

            line = sr.ReadLine();
            while (line != null)
            {
                array = line.Split(';');
                person[i] = new Person(array[0], DateTime.Parse(array[1]), double.Parse(array[2]), bool.Parse(array[3]), int.Parse(array[4]));
                line = sr.ReadLine();
                Console.WriteLine(person[i].Name + " " + person[i].BirthDate + " " + person[i].Height + " " + person[i].IsMarried + " " + person[i].NoOfChildren);
                i++;

            }
            sr.Close();
            //Console.WriteLine(person[2].Height);
            
            return person;

        }
    }
}
