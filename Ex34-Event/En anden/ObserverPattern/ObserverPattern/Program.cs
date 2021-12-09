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

            Student s1 = new Student(p, "Jens");

            Student s2 = new Student(p, "Niels");

            Student s3 = new Student(p, "Susan");

            p.MessageChanged += s1.Update;

            p.MessageChanged += s2.Update;

            p.MessageChanged = null;

            p.MessageChanged += s3.Update;

            p.Message = "Så er der julefrokost!";

            p.MessageChanged -= s2.Update;

            p.Message = "Så er der fredagsbar!";
        }
    }
}
