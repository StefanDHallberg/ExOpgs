using System;

namespace String_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaration of data type
            bool result;

            // checking for decimal digit in
            // a string at a desired position
            string str1 = "GeeksforGeeks";
            result = Char.IsDigit(str1, 2);
            Console.WriteLine(result); */

            // checking for decimal digit in a
            // string at a desired position
            /*bool result;
            string str2 = "geeks5forgeeks";
            result = Char.IsDigit(str2, 5);
            Console.WriteLine(result); */

            Console.WriteLine("Prøver");
            string text = "g33ks5f6orgeeks";
            int counter = 0;
            while (counter < text.Length)
            {
                if (Char.IsDigit(text[counter]))
                {
                    Console.WriteLine("IndeksPlads:{0} > : Tallet:{1}", counter, text[counter]);
                }
                counter++;
            }

            /*
            string str = "stefanHallberg";
            char ch = str[1];
            int Counter = 1;

            while (str.Length > Counter)
            {
                Console.WriteLine(str[Counter]);
                Counter = Counter + 2;
            }
            Console.ReadLine();
            */

            /* string str = "abcdefg";
             char ch1 = str[1]; //b
             Console.WriteLine(ch1);
             char ch2 = str[3]; //d
             char ch3 = str[5]; //f
             Console.WriteLine("{0}, {1}", ch2,ch3); //FORKLARING
             Console.ReadLine();
             */



        }
    }
}
