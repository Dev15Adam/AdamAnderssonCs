using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labboration_C
{
    class Radio
    {
        private byte volym;
        private bool radioOn;
        private double frekvens;
        static int instanceCount;
        public double Frekvens
        {
            get { return frekvens; }
            set
            {
                if (value >= 80.0 && value <= 123.4)
                    frekvens = value;
                else
                    throw new Exception("Frekvens kan vara mellan 88.0 - 123.4");
            }
        }

        public bool RadioOn
        {
            get { return radioOn; }
            set { radioOn = value; }
        }

        public byte Volym
        {
            get { return volym; }
            set
            {
                if (value >= 0 && value <= 100)
                    volym = value;
                else
                    throw new Exception("Volymen kan vara mellan 0 - 100");
            }
        }
        static Radio()
        {
            instanceCount = 0;
        }
        public Radio()
        {
            Frekvens = 93.5;
            Volym = 15;
            RadioOn = true;
            instanceCount++;
        }

        public Radio(double frekvens, byte volym) : this()
        {
            Frekvens = frekvens;
            Volym = volym;
        }
        public Radio(double frekvens, byte volym, bool radioOn): this(frekvens,volym)
        {
           
            RadioOn = radioOn;
        }
        public override string ToString() => $"Frekvens: {Frekvens} Volym: {Volym} RadioOn: {RadioOn} Instance count: {instanceCount}";


    }
}
