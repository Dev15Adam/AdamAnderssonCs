using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labboration_C
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Bilar();
            Radios();
            //Mc();
        }

        private static void Mc()
        {
            var honda = new Mc();
            var yamaha = new Mc(numberOfGears: 4, numberOfHp: 15, coolor: 290, brand: "Yamaha", name: "Batata");
            var kawasaki = new Mc(numberOfGears: 6, numberOfHp: 55, coolor: 290, brand: "Yamaha", name: "Batata");
        }

        private static void Radios()
        {
            var radio = new Radio();
            var radio2 = new Radio(frekvens: 101.3, volym: 10, radioOn: true);
            var radio3 = new Radio(volym: 82, radioOn: false, frekvens: 85.0);
            var radio4 = new Radio(radioOn: true, frekvens: 122.9, volym: 55);

            Console.WriteLine(radio);
            Console.WriteLine(radio2);
            Console.WriteLine(radio3);
            Console.WriteLine(radio4);
            Console.ReadLine();
        }

        private static void Bilar()
        {
            var volvo = new Bil(typ: "kombi", marke: "Volvo", antalVaxlar: 5, farg: 250);
            Console.WriteLine(volvo);
            Console.ReadLine();
        }
    }
}
