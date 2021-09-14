using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientModule
{
    class Patient
    {
    }

    class IndexedClass
    {
        private String[] names = new string[10];
        static void Main(string[] args)
        {
            IndexedClass namesList = new IndexedClass();
            //syntactic sugar
            namesList[0] = "peanut";
            namesList[1] = "pollen";
            Console.WriteLine(namesList[1]);
            Console.Read();

            //IndexedClass patient2 = new IndexedClass();
            //patient2[1] = "allergy";


        }

        public string this[int index]
        {
            get
            {
                return ( index >= 0 && index <= 9)? names[index]:"";
            }
            set
            {
                if (index >= 0 && index <= 9)
                {
                    names[index] = value;
                }
            }
        }
    }
}
