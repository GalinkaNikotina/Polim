using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfism
{
    class Tester
    {
        static void Main(string[] args)
        {
            Caller c = new Caller();
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);

            c.CallArea(r);
            c.CallArea(t);
            Console.ReadKey();
        }
        //{
        //    Rectangle r = new Rectangle(10, 7);
        //    double a = r.area();
        //    Console.WriteLine("Area: {0}", a);
        //    Console.ReadKey();
        //}
    }
}
