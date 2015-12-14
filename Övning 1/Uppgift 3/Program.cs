using System;

namespace Simple
{

    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Three inters are {1} and {2}.", 3, 6); // {1}, {0} and {1}. Den skickar in värdet 3 på poisition 0, och skickar in värdet 6 på postion 1. {1} and {2} så blir det error eftersom att det inte finns något på position 2, utan bara på position 0 och 1.
            //Console.WriteLine("The value: {0}.", 500); // visar The value: 500 eftersom att 500 är på porition 0.
            Console.WriteLine("The value: {0:C}.", 500, 56); // visar The value: 500.00 eftersom att Cet står för currency.
            Console.ReadLine();
        }
    }
}
