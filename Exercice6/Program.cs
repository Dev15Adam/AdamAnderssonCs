using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point() {X = 5, Y = 5};
            Console.WriteLine($"Point:{point}");
            Point3D point3D = point;
            Console.WriteLine($"Point till 3D:{point3D}");
            point3D.Z = 10;
            Console.WriteLine($"Point3D+Z:{point3D}");
            point = (Point) point3D;
            Console.WriteLine($"3D till Point{point}");
            point += point;
            Console.WriteLine($"Point += {point.ToString()}");
            point += point3D;
            Console.WriteLine($"Point + 3D {point.ToString()}");

            //Literalerna();
            //StartDoubleMethod();
            Console.ReadLine();
        }

        private static void Literalerna()
        {
            //float flytTal = 5.5f;
            //long longTal = 456L;
            //char enChar = 'c';
            //string enString = "string here";
            //ulong ulongTal = 456UL;
        }

        private static void StartDoubleMethod()
        {
            MyDoubleType mdt1 = new MyDoubleType(5);
            MyDoubleType mdt2 = mdt1 + 5;
            MyDoubleType mdt3 = mdt1 + mdt2;
            MyDoubleType mdt4 = new MyDoubleType(5);
            Console.WriteLine("{0},{1},{2},{3},{4}", mdt1, mdt2, mdt3, mdt1 > mdt2, mdt1 == mdt4);
        }
    }
}
