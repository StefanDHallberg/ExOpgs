using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
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

        public static double CourseHourValue = 875.0;
        public double GetValue()
        {
            if (DurationInMinutes == 0)
            {
                return 0;
            }
            else if (DurationInMinutes % 60 > 0)
            {
                return ((DurationInMinutes / 60) + 1) * CourseHourValue;
            }
            else
            {
                return (DurationInMinutes / 60) * CourseHourValue;
            }
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
            return $"Name: {Name}, Duration in Minutes: {durationInMinutes}, Value: {GetValue()}";
        }
    }
}
