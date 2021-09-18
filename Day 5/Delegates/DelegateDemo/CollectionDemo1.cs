using System;
using System.Collections;
using System.Collections.Generic;


namespace DelegateDemo
{
    class CollectionDemo1
    {
        static void Main6(string[] args)
        {
            ArrayList al = new ArrayList(); //legacy collection from system.collection //dynamic and not typed
            al.Add("Hello");
            al.Add(10);
            al.Add(2.5);
            foreach (var item in al)
            {
                Console.Write(item + " ");              
            }
            Console.WriteLine();
            al.Insert(1, "World"); //Insert item at index 1
            foreach (var item in al)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //Many other methods are available like al.remove()// Check docs for all methods

            //Generic Collections // these are typed and a type need to be specified on initialization
            List<int> intList = new List<int>(); //any type can be specified instead of int including custom classes
            intList.Add(1);
            intList.Add(2);
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();

            //There are other generic collections like HashTable //check docs for more info
        }
    }
}
