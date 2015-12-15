using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    struct MyDoubleType
    {
        private double doubleValue;

        public double DoubleValue
        {
            get { return doubleValue; }
            set { doubleValue = value; }
        }


        public MyDoubleType(double doubleValue)
        {
            this.doubleValue = doubleValue;
        }

        public override string ToString()
        {
            return this.doubleValue.ToString();
        }

    }
}
