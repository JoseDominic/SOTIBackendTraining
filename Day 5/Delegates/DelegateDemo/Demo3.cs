using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//passing functions inline to delegates

namespace DelegateDemo
{
    delegate void printName(string name);
    delegate int addNumber(int a, int b);
    class Demo3
    {
        static void Main3(string[] args)
        {
            //using delegate keyword
            printName pd = delegate (string name) { Console.WriteLine("Hello" + name); };

            //using lambda function
            addNumber addDel = (a, b) => { return a + b; };

            int sum = addDel(3, 4);
            Console.WriteLine(sum);
            pd("Jose");
            Console.ReadKey();
        }
    }
}
