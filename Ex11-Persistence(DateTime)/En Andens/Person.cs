using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace persistens
{
   public class Person
    {
        private string _name;
        private DateTime _birthdate;
        private double _height;
        private bool _isMarried;
        private int _noOfChildren; 

        public Person(string name, DateTime birthDate, double height,
            bool isMarried, int noOfChildren)
        {
            this._name = name;
            this._birthdate = birthDate;
            this._height = height;
            this._isMarried = isMarried;
            this._noOfChildren = noOfChildren;
        }

        public string Name
        {
            get { return _name; }
            set { value = _name; }
        }

        public DateTime BirthDate
        {
            get { return _birthdate; }
            set { value = _birthdate; }
        }

        public double Height
        {
            get { return _height; }
            set { value = _height; }
        }

        public bool IsMarried
        {
            get { return _isMarried; }
            set { value = _isMarried; }
        }

        public int NoOfChildren
        {
            get { return _noOfChildren; }
            set { value = _noOfChildren; }
        }

        public string MakeTitle() 
        {
            return String.Format("{0};{1};{2};{3};{4}", _name, _birthdate, 
                _height, _isMarried, _noOfChildren); 
        }
    }
}
