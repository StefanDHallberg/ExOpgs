using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TusindfrydWPF
{
    public class FlowerSort
    {
        private string name;
        private string filePath;
        private int productionTime;
        private int halfLifeTime;
        private int size;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public int ProductionTime
        {
            get { return productionTime; }
            set { productionTime = value; }
        }

        public int HalfLifeTime
        {
            get { return halfLifeTime; }
            set { halfLifeTime = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }


    }
}
