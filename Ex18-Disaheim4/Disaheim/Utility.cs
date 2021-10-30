using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {

        public double LowQualityValue { get; set; } = 12.5;
        public double MediumQualityValue { get; set; } = 20;
        public double HighQualityValue { get; set; } = 27.5;
        public double CourseHourValue { get; set; } = 875;
        public double GetValueOfMerchandise(Merchandise merchandise)
        {   
            double result = 0;
            if (merchandise is Book book)
            {
                result = book.Price; 

            }
            if (merchandise is Amulet amulet)
            {
                switch (amulet.Quality)
                {
                    case Level.low:
                        result = 12.5;
                        break;
                    case Level.medium:
                        result = 20;
                        break;
                    case Level.high:
                        result = 27.5;
                        break;
                }
                

            }
            return result;
        }

        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        public double GetValueOfAmulet(Amulet amulet)
        {
            double value = 0;
            if (amulet.Quality == Level.low)
            {
                value = 12.5;
            }
            if (amulet.Quality == Level.medium)
            {
                value = 20;
            }
            if (amulet.Quality == Level.high)
            {
                value = 27.5;
            }
            return value;

        }
        public double GetValueOfCourse(Course course)
        {
            int CourseHoursStarted;
            CourseHoursStarted = course.DurationInMinutes / 60;

            int CoursePrice = CourseHoursStarted * 875;

            if (course.DurationInMinutes % 60 > 0)
            {
                CoursePrice = CoursePrice + 875;
            }

            return CoursePrice;
        }
    }
}
