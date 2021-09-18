using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Student:IComparable<Student>
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public int CompareTo(Student other)
        {
            if (this.age > other.age)
                return 1;
            else if (this.age < other.age)
                return -1;
            else
                return 0;
        }
    }

    class SortStudByName:IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.name.CompareTo(y.name);
        }
    }
    class Demo2
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student() { id=3,name="Caleum",age=24});
            studentList.Add(new Student() { id = 10, name = "Zetsu", age = 20 });
            studentList.Add(new Student() { id = 5, name = "Bjorn", age = 22 });
            studentList.Add(new Student() { id = 1, name = "Johan", age = 23 });
            studentList.Add(new Student() { id = 9, name = "Aron", age = 21 });
            Console.WriteLine("Before sorting.. \n");
            foreach (var stud in studentList)
            {
                Console.WriteLine("ID:{0}, Name:{1}, Age:{2}", stud.id, stud.name, stud.age);
            }
            Console.WriteLine("\nAfter sorting based on age.. \n");
            studentList.Sort();
            foreach (var stud in studentList)
            {
                Console.WriteLine("ID:{0}, Name:{1}, Age:{2}", stud.id, stud.name, stud.age);
            }
            Console.WriteLine("\nAfter sorting by name.. \n");
            studentList.Sort(new SortStudByName());
            foreach (var stud in studentList)
            {
                Console.WriteLine("ID:{0}, Name:{1}, Age:{2}", stud.id, stud.name, stud.age);
            }
            Console.ReadKey();
       

        }
    }
}
