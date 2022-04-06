using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is where we will instatiate the class and create  an object
            Calculator calc = new Calculator();
            //we have to create a local variable to hold the answer
            int x = 3; int y = 5; int c = 8; int d = 6;
            int e = 4; int f = 2; int g = 20; int j = 5;
            int sum = 0;
            int sub = 0;
            int mul = 0;
            int div = 0;
            sum = calc.Add(x, y);
            sub = calc.Sub(c, d);
            mul = calc.Mul(e, f);
            div = calc.Div(g, j);
            Console.WriteLine("sum of {0} + {1} = {2}", x, y ,sum);
            Console.WriteLine("substarction of {0} - {1} = {2}", c, d, sub);
            Console.WriteLine("multiplication of {0} * {1} = {2}", e, f, mul);
            Console.WriteLine("division of {0} / {1} = {2}", g, j, div);
            Console.ReadLine();

        }
    }
}
