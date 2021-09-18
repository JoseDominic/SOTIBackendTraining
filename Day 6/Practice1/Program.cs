using System;
using System.Linq;

namespace Practice1
{
    class Practice
    {
        public static void Reverse(ref string s)
        {
            var tempString = s.Reverse();
            s = "";
            foreach (var item in tempString)
            {
                s += item;
            }
        }

        public static int Highest(int[] arr)
        {
            int big = arr[0];
            foreach (var item in arr)
            {
                if (item > big)
                    big = item;
            }
            return big;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
    class Program
    {
        static void Main1(string[] args)
        {
            string str = "Hello World";
            int[] arr = { 1, 2, 3, 100, 20, 30, 8 };
            int a = 5, b = 10;
            Console.WriteLine("Before Reverse:{0}",str);
            Practice.Reverse(ref str);
            Console.WriteLine("After Reverse:{0}", str);
            Console.WriteLine("Highest Number is " + Practice.Highest(arr));
            Console.WriteLine("Before Swap, a:{0}, b:{1}", a, b);
            Practice.Swap(ref a, ref b);
            Console.WriteLine("After Swap, a:{0}, b:{1}", a, b);
            Console.ReadKey();
        }
    }


}
