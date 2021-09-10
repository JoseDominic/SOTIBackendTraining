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
            int x, y, sum, result;
            //type conversion examples
            string val1 = "21", val2 = "100.11";
            bool z = int.TryParse(val1,out result); //Try parse makes out variable false if conversion fails
            Console.WriteLine(result);
            Console.WriteLine(int.TryParse(val2,out result));
            Console.WriteLine(val2);
            Console.WriteLine("Enter first num:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second num:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"x={x} y={y}");
            sum = add(x, y);
            Console.WriteLine($"Sum = {sum}");
            Console.ReadLine();
        }
    }
}
