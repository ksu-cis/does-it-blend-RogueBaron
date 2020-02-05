using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var b = new Banana();
            var s = new Strawberry();
            var m = new Mango();
            var c = new IceCubes();
            var p = new CellPhone();

            Console.WriteLine(b.Blend());
            Console.WriteLine(s.Blend());
            Console.WriteLine(m.Blend());

            List<IBlendable> blub = new List<IBlendable>() { b, s, m, c, p};

            foreach(var bl in blub)
            {
                Console.WriteLine(bl.GetType());
                Console.WriteLine(bl.Blend());
            }

        }
    }
}
