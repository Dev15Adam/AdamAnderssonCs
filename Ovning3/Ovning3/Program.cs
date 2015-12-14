using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point3D point = new Point3D();
            //Console.WriteLine("Set x:");
            //point.SetX(int.Parse(Console.ReadLine()));
            //Console.WriteLine("Set y:");
            //point.SetY(int.Parse(Console.ReadLine()));
            //Console.WriteLine("Set z:");
            //point.SetZ(int.Parse(Console.ReadLine()));
            //Console.WriteLine($"x:{point.GetX()}, y:{point.GetY()}, z:{point.GetZ()}");


            Person person = new Person();
            Console.WriteLine("Set name:");
            person.SetName(Console.ReadLine());
            Console.WriteLine("Your name is: " + person.GetName());

            Point point = new Point();
            Console.WriteLine("Set x:");
            point.SetX(int.Parse(Console.ReadLine()));
            Console.WriteLine("Set y:");
            point.SetY(int.Parse(Console.ReadLine()));
            Console.WriteLine("Your x point = " + point.GetX() + " " + "Your y point = " + point.GetY());

            Circle circle = new Circle();
            Console.WriteLine("Set diameter: ");
            circle.SetDiameter(double.Parse(Console.ReadLine()));
            circle.SetCenter(point);
            Console.WriteLine("Diameter = " + circle.GetDiameter() + "Circumference =" + circle.GetCircumference());
            Console.WriteLine("Circle x point = " + circle.GetCenter().GetX());




        }
    }
}
