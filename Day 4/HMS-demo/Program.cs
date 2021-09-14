using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_demo
{
    interface iUser
    {
        void work();
    }
    interface A : iUser
    {
        //extending interface example
    }
    class User:iUser
    {
        public int a
        {
            get => a;
            set => a = value;
        }
        public void work()
        {
            Console.WriteLine("Works");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
