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

            const double PI = Math.PI;
            //double piRounded =  PI;
            //int piRoughRounded = 5;
            Console.WriteLine("{0},{1},{2}", PI, PI, PI);
            //PI = 3.141592654;
            //piRounded = 3.14;
            //piRoughRounded = 3;
            string textContentForPi = "Talet pi är cirka {0} men kan avrundas till {1:f2} och kan lite grovt skrivas som {2:f0}.";
            Console.WriteLine(textContentForPi, PI, PI, PI);

            string jonasName = "Jonas";
            string jonasHomeTown = "Helsingborg";
            string jonasStore = "Hemköp";
            Console.WriteLine("Han heter {0} och bor i {1} på Stattena vid {2}", jonasName, jonasHomeTown, jonasStore);
        }
    }
}
