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

        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetHeight(int height)
        {
            this.height = height;
        }
        public int GetHeight()
        {
            return height;
        }
        public void SetTreeAlive(bool treeAlive)
        {
            this.treeAlive = treeAlive;
        }
        public bool GetTreeAlive()
        {
            return treeAlive;
        }
        public int GetNumOranges()
        {
            return numOranges;
        }
        public int GetOrangesEaten()
        {
            return orangesEaten;
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
