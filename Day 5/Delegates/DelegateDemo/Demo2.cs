using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    delegate bool IsPromoted(Employee Employee);
    class Employee:IComparable<Employee>
    {
 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }

        public int CompareTo(Employee other)
        {
            //if (this.Age > other.Age)
            //    return 1;
            //else if (this.Age < other.Age)
            //    return -1;
            //else
            //    return 0;
            return this.Name.CompareTo(other.Name);
        }

        public static void PromotedEmployee(List<Employee> list, IsPromoted isPromoted)
        {
            foreach (Employee employee in list)
            {
                if (isPromoted(employee))
                {
                    Console.WriteLine(employee.Name + " - Promoted");
                }
            }
        }

    }

    class Demo2
    {
        static void Main2()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id = 101, Name = "Mark", Age=30, Salary = 5000, Experience = 3 });
            employees.Add(new Employee() { Id = 102, Name = "Smith", Age=25, Salary = 3000, Experience = 5 });
            employees.Add(new Employee() { Id = 103, Name = "Watson", Age=23, Salary = 6000, Experience = 8 });
            employees.Add(new Employee() { Id = 104, Name = "Paul",Age=50, Salary = 8000, Experience = 4 });

            IsPromoted isPromoted = new IsPromoted(PromotedLogic);

            Employee.PromotedEmployee(employees, isPromoted);


            Console.ReadKey();
        }

        public static bool PromotedLogic(Employee employee)
        {
            if (employee.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
