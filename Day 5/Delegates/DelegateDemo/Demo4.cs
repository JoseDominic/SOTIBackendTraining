using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//multicasting in delegates (using 1 delegate for functions with similar signature)

namespace DelegateDemo
{
    delegate void numDelegate(double width, double Height);

    class MultiCast
    {
        public void Area(double w, double h)
        {
            Console.WriteLine("Area:" + (w * h));
        }

        public void Perimeter(double w, double h)
        {
            Console.WriteLine("Perimeter:" + (w + h));
        }
    }
    class Demo4
    {
 
        static void Main4(string[] args)
        {
            MultiCast M = new MultiCast();
            numDelegate nd = M.Area;
            nd += M.Perimeter;
            nd.Invoke(3,4); //this will call both methods attatched to the delegate
            Console.ReadKey();
        }
    }
}
