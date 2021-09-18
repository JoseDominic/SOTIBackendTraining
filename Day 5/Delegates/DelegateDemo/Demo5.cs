using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Inbuilt delegates example
//Csharp library provides inbluild generic delegates Func<>,Action<>and Predicate<> to be used
//Func<> can take upto 16 inp and 1 op
//Action<> returns void and can take up to 16 inp
//Predicate<> returns a boolean

namespace DelegateDemo
{
    class GenDelDemo
    {
        public static double AddNumber1(int x, float y, double z)
        {
            return x + y + z;
        }
        public static void AddNumber2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }

        public static bool stringCheck(string str)
        {
            if (str.Length > 5)
                return true;
            else
                return false;
        }
    }
    class Demo5
    {
        static void Main5(string[] args)
        {
            Func<int, float, double, double> d1 = GenDelDemo.AddNumber1;
            Action<int, float, double> d2 = GenDelDemo.AddNumber2;
            Predicate<string> d3 = GenDelDemo.stringCheck;
            double result = d1(1,2.5f,3);
            Console.WriteLine(result);
            d2(1,2.5f,3);
            bool check = d3("Hello World");
            Console.WriteLine(check);
            Console.ReadKey();

        }
    }
}
