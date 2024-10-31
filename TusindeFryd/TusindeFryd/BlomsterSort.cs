using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TusindeFryd
{
    public class BlomsterSort
    {
        private string _name = "";
        private int _productionTimeInDays = 0; //Ay okay
        private int _halfLife = 0;
        private double _flowerSize = 0;
        //binary billede;

        public string Name { get { return _name; } set { _name = value; } }
        public int ProductionTimeInDays { get { return _productionTimeInDays; } set { _productionTimeInDays = value; } }
        public int HalfLife { get { return _halfLife; } set { _halfLife = value; } }
        public double FlowerSize { get { return _flowerSize; } set { _flowerSize = value; } }

        public BlomsterSort(string name)
        { 
            Name = name;

        }

        public BlomsterSort(string name, int productionsTimeInDays)
        {
            Name = name;
            ProductionTimeInDays = productionsTimeInDays;
        }

        public BlomsterSort(string name, int productionsTimeInDays, int halfLife)
        { 
            Name = name;
            ProductionTimeInDays = productionsTimeInDays;
            HalfLife = halfLife;
        }

        public BlomsterSort(string name, int productionsTimeInDays, int halfLife, double flowerSize)
        {
            Name = name;
            ProductionTimeInDays = productionsTimeInDays;
            HalfLife = halfLife;
            FlowerSize = flowerSize;
        }

        public override string ToString()
        {
            return $"Navn: {Name}, Produktions tid: {ProductionTimeInDays} dage, Halverings tid: {HalfLife}, Blomster størrelse: {FlowerSize}cm";
        }

    }
}
