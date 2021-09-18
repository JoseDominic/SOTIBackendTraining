using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{

    //delegate declaration
    public delegate void AddNumberDelegate(int a, int b);
    public delegate string DisplayNameDelegate(string name);

    class Test
    {
        public void AddNumber(int a,int b)
        {
            Console.WriteLine(a + b);
        }

        public static string DisplayName(string name)
        {
            return ("Hello" + name);
        }

    }

    class Demo1
    {
        static void Main2(string[] args)
        {
            Test t1 = new Test();
            AddNumberDelegate add = t1.AddNumber;
            DisplayNameDelegate d = Test.DisplayName;
            add.Invoke(3, 4); //Invoke is optional... add(3,4) is also possible
            Console.WriteLine(d.Invoke("Jose"));
            Console.ReadKey();
        }
    }
}
