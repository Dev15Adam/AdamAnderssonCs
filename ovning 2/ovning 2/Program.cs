using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dowJonesInterest = 4, nasdaqInterest = 4, stockholmInterest = 2, milanoInterest = 6, parisInterest = 5;
            Console.WriteLine("{0},{1},{2},{3},{4}", dowJonesInterest, nasdaqInterest, stockholmInterest, milanoInterest, parisInterest);
            dowJonesInterest = 4.6;
            nasdaqInterest = 4.1;
            stockholmInterest = -2.4;
            milanoInterest = -6.7;
            parisInterest = -5.5;
            string theTextContent = "Dow Jones sjönk med {0} procent och Nasdaq med {1} procent.Stockholm {2} procent, Milano {3} procent, Paris {4} procent.";
            Console.WriteLine(theTextContent, dowJonesInterest, nasdaqInterest, stockholmInterest, milanoInterest, parisInterest);

            double piWithNineDecimales = Math.PI;
            double piRounded = 3.33;
            int piRoughRounded = 5;
            Console.WriteLine("{0},{1},{2}", piWithNineDecimales, piRounded, piRoughRounded);
            piWithNineDecimales = 3.141592654;
            piRounded = 3.14;
            piRoughRounded = 3;
            string textContentForPi = "Talet pi är cirka {0} men kan avrundas till {1} och kan lite grovt skrivas som {2}.";
            Console.WriteLine(textContentForPi, piWithNineDecimales, piRounded, piRoughRounded);

            string textContentOfJonas = "Han heter Jonas";
            Console.WriteLine(textContentOfJonas);
            textContentOfJonas = "Han heter Jonas och bor i Helsingborg på Stattena vid Hemköp";
            Console.WriteLine(textContentOfJonas);
        }
    }
}
