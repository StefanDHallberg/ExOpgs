using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace persistens
{
    public class DataHandler
    {
        private string _dataFileName;

        public string DataFileName
        {
            get { return _dataFileName; }
        }

        public DataHandler(string dataFileName) 
        {
            this._dataFileName = dataFileName;
        }

        public void SavePerson(Person person)
        {
            StreamWriter sw = new StreamWriter(DataFileName);
            sw.WriteLine(person.MakeTitle());
            sw.Close();
        }

        public Person LoadPerson()
        {
            StreamReader sw = new StreamReader(DataFileName);

            string[] attributes = sw.ReadLine().Split(";");
   
            string Name = attributes[0];
            DateTime Birthdate = DateTime.Parse(attributes[1]);
            double Height = Convert.ToDouble(attributes[2]);
            bool IsMarried = Convert.ToBoolean(attributes[3]);
            int NoOfChildren = Convert.ToInt32(attributes[4]);

            Person person = new Person(Name, Birthdate, Height, IsMarried, NoOfChildren);
            sw.Close();

            return person;
        }
    }
}
