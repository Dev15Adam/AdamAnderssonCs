using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labboration_C
{
    class Mc
    {
        private int numberOfHp;
        private int numberOfGears;
        private int coolor;
        private string brand;
        private string name;
        static int instanceCounter;


        public string Name
        {
            get { return name; }
            set {
                var firstCharUpperCase = value[0].ToString().ToUpper() == value[0].ToString();
                var validValue = value != null && firstCharUpperCase;
                if (validValue)
                name = value;
                else
                    throw new Exception("Not a valid first char must be uppercase");
            }
        }


        public string Brand
        {
            get { return brand; }
            set {
                var firstCharUpperCase = value[0].ToString().ToUpper() == value[0].ToString();
                var validValue = value != null && firstCharUpperCase;
                if (validValue)
                brand = value;
                else
                    throw new Exception("Not a valid first char must be uppercase");
            }
        }


        public int Coolor
        {
            get { return coolor; }
            set { coolor = value % 360; }
        }


        public int NumberOfGears
        {
            get { return numberOfGears; }
            set {
                if (value >= 3 && value <= 6)
                    numberOfGears = value;
                else
                    throw new Exception("Not a valid value choose between 3-6");
            }
        }

        public int NumberOfHp
        {
            get { return numberOfHp; }
            set {
                var validNumberOfHp = value >= 5 && value <= 95;
                if (validNumberOfHp)
                numberOfHp = value;
                else
                    throw new Exception("Not a valid value choose between 5-95");
            }
        }

        static Mc()
        {
            instanceCounter = 0;
        }

        public Mc()
        {
            numberOfGears = 6;
            numberOfHp = 55;
            coolor = 123;
            brand = "Honda";
            name = "Betan";
            instanceCounter++;
        }

        public Mc(int numberOfGears, int numberOfHp, int coolor, string brand, string name)
        {
            NumberOfGears = numberOfGears;
            NumberOfHp = numberOfHp;
            Coolor = coolor;
            Brand = brand;
            Name = name;
            instanceCounter++;
        }
        public override string ToString() => $"";

    }
}
