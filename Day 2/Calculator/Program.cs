using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {   static int add(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int x, y, sum;
            Console.WriteLine("Enter first num:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second num:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"x={x} y={y}");
            sum = add(x, y);
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
