using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuestypeExample
{
    public struct MutablePoint
    {
        public int X;
        public int Y;

        public MutablePoint(int x, int y) => (X, Y) = (x, y);

        public override string ToString() => $"({X},{Y})";
    }
    public class Program
    {
        public static void Main(string[] args)  
        {
            var p1 = new MutablePoint(1, 2);
            var p2 = p1;
            p2.Y = 200;
            //p2.X = 100;
            Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified :{p1}");
            Console.WriteLine($"{nameof(p2)}: {p2}");

            MutateAndDisplpay(p2);
            Console.WriteLine($"{nameof(p2)} after passing to a method :{p2}");
            Console.ReadKey();
        }

        private static void MutateAndDisplpay(MutablePoint p)
        {
            p.X = 100;
            Console.WriteLine($"Point mutated in method : {p}");
        }
    }
}
