using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labboration_C
{
    class Bil
    {

        private string typ;
        private string marke;
        private int antalVaxlar;
        private int farg;

        public string Typ
        {
            get { return typ; }
            set
            {
                if (value != null && value == "kupe" || value == "kombi")
                    typ = value;
                else
                    throw new Exception("Endast kupe eller kombi");
            }
        }
        public int Farg
        {
            get { return farg; }
            set { farg = value % 360; }
        }

        public int AntalVavlar
        {
            get { return antalVaxlar; }
            set
            {
                var validNumberOfSwitches = value >= 1 && value <= 6;
                if (validNumberOfSwitches)
                    antalVaxlar = value;
                else
                    throw new Exception("Antal växlar 1-6");
            }
        }

        public string Marke
        {
            get { return marke; }
            set
            {
                var firstCharIsUppercase = value[0].ToString().ToUpper() == value[0].ToString();
                var validValue = value != null && firstCharIsUppercase;
                if (validValue)
                    marke = value;
                else
                    throw new Exception("Börja med stor bokstav");
            }
        }
        public Bil(string typ, string marke, int antalVaxlar = 5, int farg = 100)
        {
            Typ = typ;
            Marke = marke;
            AntalVavlar = antalVaxlar;
            Farg = farg;
        }
        public override string ToString() => $"Typ: {Typ} Märke: {Marke} Antalväxlar: {AntalVavlar} Färg: {Farg}";

    }
}
