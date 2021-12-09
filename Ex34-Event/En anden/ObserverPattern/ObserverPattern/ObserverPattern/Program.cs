using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //var p = new Academy("UCL");

            //var s1 = new Student(p, "Jens");

            //var s2 = new Student(p, "Niels");

            //var s3 = new Student(p, "Susan");

            //p.Attach(s1);

            //p.Attach(s2);

            //p.Attach(s3);

            //p.Message = "Så er der julefrokost!";

            //p.Detach(s2);

            //p.Message = "Så er der fredagsbar!";

            //Console.ReadLine();

            Academy p = new Academy("UCL", "Seebladsgade");

            Student s1 = new Student("Jens");

            Student s2 = new Student("Niels");

            Student s3 = new Student("Susan");

            p.PropertyChanged += s1.Update;

            p.PropertyChanged += s2.Update;

            p.PropertyChanged += null;

            p.PropertyChanged += s3.Update;

            p.Message = "Så er der julefrokost!";

            p.PropertyChanged -= s2.Update;

            p.Message = "Så er der fredagsbar!";
        }
    }
}
