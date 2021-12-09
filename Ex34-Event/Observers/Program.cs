using System;

namespace ObserversProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Academy p = new Academy("UCL", "Seebladsgade");

            //Student s1 = new Student(p, "Jens");
            //Student s2 = new Student(p, "Niels");
            //Student s3 = new Student(p, "Susan");

            //p.Attach(s1);
            //p.Attach(s2);
            //p.Attach(s3);

            //p.Message = "Så er der julefrokost!";

            //p.Detach(s2);

            //p.Message = "Så er der fredagsbar!";
            //Console.ReadLine();

            //Academy p = new Academy("UCL", "Seebladsgade");

            //Student s1 = new Student(p, "Jens");
            //Student s2 = new Student(p, "Niels");
            //Student s3 = new Student(p, "Susan");

            //p.Students += s1.Update;
            //p.Students += s2.Update;
            //p.Students += s3.Update;

            //p.Message = "Så er der julefrokost!";

            //p.Students -= s2.Update;

            //p.Message = "Så er der fredagsbar!";
            //Console.ReadLine();


            Academy p = new Academy("UCL", "Seebladsgade");

            Student s1 = new Student("Jens");
            Student s2 = new Student("Niels");
            Student s3 = new Student("Susan");

            
            p.PropertyChanged += s1.Update;
            p.PropertyChanged += s2.Update;
            p.PropertyChanged += null; //-> sætter man den "=" så sletter man tidligere bindninger derfor kun s3 vil blive sat. (Kun i delegates)
            p.PropertyChanged += s3.Update;

            p.Message = "Så er der julefrokost!";
            p.PropertyChanged -= s2.Update;

            p.Message = "Så er der fredagsbar!";

            Console.ReadLine();



        }
    }
}