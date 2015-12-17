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

        public static MyDoubleType operator +(MyDoubleType myDoubleType, MyDoubleType myDoubleTypeTwo)
        {
            return new MyDoubleType() { DoubleValue = myDoubleType.doubleValue + myDoubleTypeTwo.doubleValue };
        }

        public static MyDoubleType operator +(MyDoubleType myDoubleType, double dType)
        {
            return new MyDoubleType() { DoubleValue = myDoubleType.doubleValue + dType };
        }

        public static MyDoubleType operator +(double value, MyDoubleType myDoubleType)
        {
            return myDoubleType + value;
        }

        public static MyDoubleType operator -(MyDoubleType myDoubleType, MyDoubleType myDoubleTypeTwo)
        {
            return new MyDoubleType() {DoubleValue = myDoubleType.doubleValue - myDoubleType.doubleValue};
        }
        public static MyDoubleType operator -(MyDoubleType myDoubleType, double dType)
        {
            return new MyDoubleType() {DoubleValue = myDoubleType.doubleValue - dType};
        }

        public static MyDoubleType operator -(double value, MyDoubleType myDoubleType)
        {
            return myDoubleType - value;
        }

        public static MyDoubleType operator *(MyDoubleType myDoubleType, MyDoubleType myDoubleTypeTwo)
        {
            myDoubleType.doubleValue *= myDoubleType.doubleValue;
            return myDoubleType;
        }

        public static MyDoubleType operator *(MyDoubleType myDoubleType, double dType)
        {
            myDoubleType.doubleValue *= dType;
            return myDoubleType;
        }

        public static MyDoubleType operator /(MyDoubleType myDoubleType, MyDoubleType myDoubleTypeTwo)
        {
            myDoubleType.doubleValue /= myDoubleTypeTwo.doubleValue;
            return myDoubleType;
        }
        public static MyDoubleType operator /(MyDoubleType myDoubleType, double dType)
        {
            myDoubleType.doubleValue /= dType;
            return myDoubleType;
        }

        public static bool operator ==(MyDoubleType myDoubleType, MyDoubleType myDoubleTypeTwo)
        {
            return (myDoubleType.doubleValue == myDoubleTypeTwo.doubleValue);
        }

        public static bool operator !=(MyDoubleType myDoubleType, MyDoubleType myDoubleTypeTwo)
        {
            return !(myDoubleType == myDoubleTypeTwo);
        }

        public static bool operator ==(MyDoubleType myDoubleType, double dType)
        {
            return (myDoubleType.doubleValue == dType);
        }

        public static bool operator !=(MyDoubleType myDoubleType, double dType)
        {
            return !(myDoubleType == dType);
        }

        public static bool operator <(MyDoubleType myDoubleType, MyDoubleType myDoubleTypeTwo)
        {
            return (myDoubleType.doubleValue < myDoubleTypeTwo.doubleValue);
        }

        public static bool operator >(MyDoubleType myDoubleType, MyDoubleType myDoubleTypeTwo)
        {
            return (myDoubleType.doubleValue > myDoubleTypeTwo.doubleValue);
        }

        public static bool operator <(MyDoubleType myDoubleType, double dType)
        {
            return (myDoubleType.doubleValue < dType);
        }

        public static bool operator >(MyDoubleType myDoubleType, double dType)
        {
            return (myDoubleType.doubleValue > dType);
        }

        public static bool operator <=(MyDoubleType myDoubleType, MyDoubleType myDoubleTypeTwo)
        {
            return (myDoubleType.doubleValue <= myDoubleTypeTwo.doubleValue);
        }

        public static bool operator >=(MyDoubleType myDoubleType, MyDoubleType myDoubleTypeTwo)
        {
            return (myDoubleType.doubleValue >= myDoubleTypeTwo.doubleValue);
        }

        public static bool operator <=(MyDoubleType myDoubleType, double dType)
        {
            return (myDoubleType.doubleValue <= dType);
        }

        public static bool operator >=(MyDoubleType myDoubleType, double dType)
        {
            return (myDoubleType.doubleValue >= dType);
        }
    }
}
