using System;


namespace Ex05__Calculator
{
    class Program       
    {
        static void Main(string[] args)
        { //VERSION 1.0.0
            bool EndProgram = false;
            Calculator calc = new Calculator(); //Declaring object of the Calculator class
            int UserChoice = 0;
            int NumA = 0;
            int NumB = 0;

            while (!EndProgram)
            {
                Console.Clear();
                Console.WriteLine("Calculator V1");
                Console.WriteLine("What would you like to do");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Divide");
                Console.WriteLine("4. Multiply");
                Console.WriteLine("0. Close program");
                try
                {
                    UserChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter your first number");
                    NumA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter your second number");
                    NumB = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Input must be an integer");
                    Console.ReadKey();
                    continue;
                }
                double DivideResult = Math.Round(calc.Divide(NumA, NumB), 2); //Rounding up the number to two decimals only after division
                    switch (UserChoice)
                    {
                        case 1:
                            Console.WriteLine("Result: {0}", calc.Add(NumA, NumB)); //Calling our Add method using our calc object
                            Console.WriteLine("\nPress any key to return to the menu.");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Result: {0}", calc.Subtract(NumA, NumB));
                            Console.WriteLine("\nPress any key to return to the menu.");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("Result: {0}", DivideResult);
                            Console.WriteLine("\nPress any key to return to the menu.");
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("Result: {0}", calc.Multiply(NumA, NumB));
                            Console.WriteLine("\nPress any key to return to the menu.");
                            Console.ReadKey();
                            break;
                        case 0:
                            Console.WriteLine("Press any key to continue closing the program.");
                            Console.ReadKey();
                            EndProgram = true;
                            break;
                    default:
                        Console.WriteLine("Input must be a number you see on the menu");
                        break;
                    }
            }
        }
    }
}

