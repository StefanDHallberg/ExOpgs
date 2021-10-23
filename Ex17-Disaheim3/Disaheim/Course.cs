using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private int durationInMinutes;
        public int DurationInMinutes
        {
            get { return durationInMinutes; }
            set { durationInMinutes = value; }
        }

        public Course(string name, int durationInMinutes)
        {
            this.name = name;
            this.durationInMinutes = durationInMinutes;
        }
        public Course(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {durationInMinutes}";
        }
    }
}
