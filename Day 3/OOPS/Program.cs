using System;

namespace OOPS
{

    class Shape //super class
    {
        protected double Width;
        protected double Height;

        static Shape()
        {
            Console.WriteLine("Super construcor is called");
        }
    }

    class Triangle:Shape
    {   
        string kind;
        static long DateOfCreation;

        static Triangle() //Static construcor //Used for initialization //Cannot create objects
        {   //calls super constructor here (calle base in csharp)
            DateOfCreation = DateTime.Now.Ticks;
            Console.WriteLine($"Inside static constructor:{DateOfCreation}");
        }

        public Triangle(double Width1, double Width2):this(Width1) //parameterized constructor //calling below construcotr to avoid code rep
        {
            Height = Width2;
        }

        public Triangle(double Width1)
        {
            Width = Width1;
        }
        //private Triangle(double area)
        //{
        //    //private constructor
        //}

        public double Width { get; set; }
        public double Height { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(10.2,13.1); //t1 is reference to object
            Shape t2 = t1; //t1 and t2 refer to same object //Super class can refer to sub class
            Console.WriteLine(t1.Height);

        }
    }
}
