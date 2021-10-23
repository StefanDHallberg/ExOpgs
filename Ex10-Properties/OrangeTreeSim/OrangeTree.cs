using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrangeTreeSim;

namespace OrangeTreeSim
{
    public class OrangeTree
    { //starter med lillebogstav camel-case
        private int age = 0;
        private int height = 0;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public int Age
        {
            set
            { 
                //age = value; 
                if (value >= 0)
                {
                    try
                    {
                        this.age  = value;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Kun numre!!!");
                    }
                }
            }
            get { return age; }
        }
        public int Height
        {
            set { height = value; }
            get { return height; }
        }
        public bool TreeAlive
        {
            set { treeAlive = TreeAlive; }
            get { return treeAlive; }
        }
        public int NumOranges
        {
            get { return numOranges; }
        }
        public int OrangesEaten
        {
            get { return orangesEaten; }
        }

        public void OneYearPasses()
        {
            age++;
            orangesEaten = 0;
            if ((0 < age) && (age < 80))
            {
             //   treeAlive = true; er sat til true fra start af.
                height += 2;
            }
            else
            { treeAlive = false;
                numOranges = 0;
            }
            if ((age > 1) && (age < 80))
            {
                numOranges += 5;
                numOranges = (age - 1) * 5;
                 
            }
        }
        public void EatOrange(int count) //count er for året
        {
            orangesEaten += count;
            numOranges -= count;

        }

    }
}
