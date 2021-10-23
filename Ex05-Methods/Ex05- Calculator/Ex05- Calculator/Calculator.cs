using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05__Calculator
{
    class Calculator
    {
        public int Add(int NumA, int NumB)
        {
            return NumA + NumB;
        }

        public int Subtract(int NumA, int NumB)
        {
            return NumA - NumB;
        }

        public double Divide(double NumA, double NumB)
        {
            return NumA / NumB;
        }

        public int Multiply(int NumA, int NumB)
        {
            return NumA * NumB;
        }

    }
}
