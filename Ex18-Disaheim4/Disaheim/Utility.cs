using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
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
