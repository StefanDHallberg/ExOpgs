using System;
using TotallySafeLib;

namespace CustomExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //outofrange in array?
            
            try
            {
                int posValue = TotallySafe.GetValueAtPosition(-2); //intArray = { 1, 2, 3, 4, 5 } alt over og under er ikke muligt.
                 

                Console.WriteLine(posValue);
                Console.ReadLine();
            }
            catch (NegativeIndexOutOfRangeException ex)
            {
                //new NegativeIndexOutOfRangeException ("Cannot be below 0.", ex);
                Console.WriteLine(ex.Message);
            }




        }
    }
}
