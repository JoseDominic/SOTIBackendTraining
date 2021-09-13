using System;

namespace Polymorphism
{
    class Calculator
    {
        public int num1, num2;

        public Calculator(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }
        //Operator overloading syntax
        //access modifier classname operator operator_symbol (parameter)
        public static Calculator operator -(Calculator c1)
        {
            c1.num1 = -c1.num1;
            c1.num2 = -c1.num2;
            return c1;
        }
    }

    class OpOverload
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(10, 20);
            calc = -calc;
            Console.WriteLine($"Num1:{calc.num1},Num2:{calc.num2}");
        }
    }
}
