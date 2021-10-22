using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFM
{
    class Core
    {
        public void Run()
        {
            double a;
            double b;
            double c;
            Console.Write("A: ");
            double.TryParse(Console.ReadLine(), out a);
            Console.Write("B: ");
            double.TryParse(Console.ReadLine(), out b);
            Console.Write("C: ");
            double.TryParse(Console.ReadLine(), out c);
            double[] input = new double[] { a, b, c };
            var app = new Polynom() { _input = input };
            Console.Write("Solving: ");
            if (a > 1)
            {
                Console.Write($"{a}x^2 ");
                if (b > 1) { Console.Write($"+ {b}x "); }
                if (b == 1) { Console.Write($"+ x "); }
                if (b == -1) { Console.Write($"- x "); }
                if (b < 0) { Console.Write($"{b}x "); }
                if (c > 1) { Console.Write($"+ {c} = 0"); }
                if (c == 1) { Console.Write($"+ {c} = 0"); }
                if (c <= -1) { Console.Write($"{c} = 0"); }
            }
            if (a == 1)
            {
                Console.Write($"x^2 ");
                if (b > 1) { Console.Write($"+ {b}x "); }
                if (b == 1) { Console.Write($"+ x "); }
                if (b == -1) { Console.Write($"- x "); }
                if (b < 0) { Console.Write($"{b}x "); }
                if (c > 1) { Console.Write($"+ {c} = 0"); }
                if (c == 1) { Console.Write($"+ {c} = 0"); }
                if (c <= -1) { Console.Write($"{c} = 0"); }
            }
            Console.WriteLine("\n------------------------");
            app.Solve();
        }
    }
}
