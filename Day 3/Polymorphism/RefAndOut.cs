using System;


namespace Polymorphism
{
    class RefAndOutDemo
    {
        public static void Main(string[] arr)
        {
            OutDemo();
            RefDemo();
        }

        private static void RefDemo()
        {
            string ogString = "Original";
            SetValue(ref ogString); //pass by reference
            Console.WriteLine($"String:{ogString}");
        }

        private static void SetValue(ref string paramString)
        {
            paramString = "Modified";
        }

        private static void OutDemo()
        {
            int result;
            Add(out result);
            Console.WriteLine($"Out demo result:{result}");
        }

        public static bool Add(out int a) //out demo
        {
            a = 20;
            a = a + a;
            return true;
        }
    }
}
