using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class Person
    {
        private string name;
        private DateTime birthDate;
        private double height;
        private bool isMarried;
        private int noOfChildren;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public bool IsMarried
        {
            get { return isMarried; }
            set { isMarried = value; }

        }

        public int NoOfChildren
        {
            get { return noOfChildren; }
            set { noOfChildren = value; }

        }

        public Person(string name, DateTime birthDate, double height,
            bool isMarried, int noOfChildren)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.height = height;
            this.isMarried = isMarried;
            this.noOfChildren = noOfChildren;
        }

        public string MakeTitle()
        {
            //return (name + ";" + birthDate + ";" + height + ";" + isMarried + ";" + noOfChildren);
           string Result = name + ";" + birthDate + ";" + height + ";" + isMarried + ";" + noOfChildren;
           return Result;


        }

    }
}





//return String.Format("{0};{1};{2};{3};{4}", _name, _birthdate, _height, _isMarried, _noOfChildren);
