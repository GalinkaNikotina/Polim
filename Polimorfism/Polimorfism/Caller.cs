using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfism
{
    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("Area: {0}", a);
        }
    }
}
