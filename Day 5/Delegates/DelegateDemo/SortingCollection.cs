using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    // check demo2.cs for employee class definition

    class SortEmployeeByAge : IComparer<Employee> //this custom class object can be passed to List.sort() to implement custom sorting
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }

    class SortingCollection
    {
        static void Main(string[] args)
        {
            var intList = new List<int> { 1, 20, 37, 23, 5, 3, 28 };
            Console.WriteLine("Before Sorting");
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            intList.Sort(); // Same can be applied on string ,float,double
            Console.WriteLine("After Sorting");
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Sorting example on custom data type lists
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Id = 101, Name = "Mark", Age = 30, Salary = 5000, Experience = 3 });
            empList.Add(new Employee() { Id = 102, Name = "Smith", Age = 25, Salary = 3000, Experience = 5 });
            empList.Add(new Employee() { Id = 103, Name = "Watson", Age = 23, Salary = 6000, Experience = 8 });
            empList.Add(new Employee() { Id = 104, Name = "Paul", Age = 50, Salary = 8000, Experience = 4 });

            //For custom data type the List.Sort() has 4 different overloads

            //method1 - use IComparable interface and implement CompareToMethod
            // check demo2.cs for employee class definition
            empList.Sort();
            foreach (var emp in empList)
            {
                Console.WriteLine("Id:{0}, Name:{1}, Age:{2}", emp.Id, emp.Name, emp.Age);
            }
            // second
            //SortEmployeeByAge sortEmployeeByAge = new SortEmployeeByAge();
            //employees.Sort(sortEmployeeByAge);


            // third
            Comparison<Employee> comparison = ComparisonById;

            //Comparison<Employee> comparison = delegate (Employee e1, Employee e2)
            //{
            //    return e1.Id.CompareTo(e2.Id);
            //};
            //Comparison<Employee> comparison = (e1, e2) => e1.Age.CompareTo(e2.Age); //using lambda expression
            empList.Sort(comparison);

            Console.WriteLine("After sorting by ID...");
            foreach (Employee employee in empList)
            {
                Console.WriteLine("Employee: Id = {0}, Name = {1}, Age={2}", employee.Id, employee.Name, employee.Age);
            }


            Console.ReadKey();
        }
        public static int ComparisonById(Employee e1, Employee e2)
        {
            return e1.Id.CompareTo(e2.Id);
        }


    }
}
