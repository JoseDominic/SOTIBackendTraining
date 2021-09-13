using System;

namespace Calculator
{
    class Program
    {   
        //assignment 1 - square function
        static int squareFn(int y)
        {
            return ( (y*y) + (2*y) +1 );
        }
        
        static int add(int a,int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int x, y, sum, result;
            //type conversion examples
            //int.Parse(), int.TryParse(), Using Convert
            //string val1 = "21", val2 = "100.11";
            //bool z = int.TryParse(val1,out result); //Try parse makes out variable false if conversion fails
            //Console.WriteLine(result);
            //Console.WriteLine(int.TryParse(val2,out result));
            //Console.WriteLine(val2);
            //Console.WriteLine("Enter first num:");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second num:");
            //y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"x={x} y={y}");
            //sum = add(x, y);
            //Console.WriteLine($"Sum = {sum}");
            //Console.ReadLine();

            //Unboxing
            Object MyObj = 30;
            int i = (int)MyObj;
            // Console.WriteLine(i);

            //Simlple fun calculator
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Enter input:");
            //        string inp = Console.ReadLine();
            //        if (inp == "q")
            //        {
            //            break;
            //        }
            //        if (!int.TryParse(inp, out result))
            //        {
            //            throw new Exception();
            //        }
            //        Console.WriteLine($"Function output:{squareFn(result)}");
            //        Console.WriteLine("Press q to exit or any other value to continue..");
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Enter an integer only!!");
            //    }

            //}

            Array3d.arrayTest();
            
        }
    }
}
