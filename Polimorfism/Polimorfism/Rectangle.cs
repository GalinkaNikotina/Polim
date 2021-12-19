using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfism
{
    class Rectangle: Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * height);
        }

        //private int length;
        //private int width;

        //public Rectangle(int a = 0, int b = 0)
        //{
        //    length = a;
        //    width = b;
        //}
        //public override int area()
        //{
        //    Console.WriteLine("Rectangle class area :");
        //    return (width * length);
        //}
    }
}

