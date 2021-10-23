using System;

namespace Opg_3___CSharp_Data
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hældnings udregning, indtast venligst Start for x1 og y1: ");
            string x_1 = Console.ReadLine();
            Double.TryParse(x_1, out double ParsedDouble_x_1);
            string y_1 = Console.ReadLine(); Convert.ToDouble(y_1);
            Double.TryParse(y_1, out double ParsedDouble_y_1);
            Console.Clear();
            Console.WriteLine("Hældnings udregning, indtast venligst Start for x2 og y2: ");
            string x_2 = Console.ReadLine(); Convert.ToDouble(x_2);
            Double.TryParse(x_2, out double ParsedDouble_x_2);
            string y_2 = Console.ReadLine(); Convert.ToDouble(y_2);
            Double.TryParse(y_2, out double ParsedDouble_y_2);
            Console.Clear();

            double Double_x_1 = ParsedDouble_x_1;
            double Double_y_1 = ParsedDouble_y_1;
            double Double_x_2 = ParsedDouble_x_2;
            double Double_y_2 = ParsedDouble_y_2;

            double Hældning = (Double_y_2 - Double_y_1) / (Double_x_2 - Double_x_1);

            string Message = "Din hældning er: ";
            Console.WriteLine(Message + Hældning);
            Console.ReadLine();


        }
    }
}
