//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Disaheim
//{
//    public class CourseRepository
//    {

//        // Måske cirkuler dependency
//        // IValuable course = new course();
//        private List<Course> courses = new List<Course>();

//        public void AddCourse(Course course)
//        {
//            courses.Add(course);
//        }

//        public Course GetCourse(string name)
//        {
//            return courses.Find(x => x.Name.Contains(name));
//        }

//        public double GetTotalValue()
//        {
//            double totalPrice = 0;
//            foreach (Course c in courses)
//            {
//                totalPrice += Course.CourseHourValue(c);
//            }
//            return totalPrice;
//        }
//    }
//}
