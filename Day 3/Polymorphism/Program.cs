using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    enum role //use enums for properties that have fixed values
    {
        Developer, Delivery_Manager
    }

    class User
    {
        public role role { get; set; }
        const int age = 60; //instance constant
        public string name { get; } //read only, not setter allowed
        public User(string name)
        {
            const int age = 100;//local constant
            this.name = name;
            //Console.WriteLine($"Age:{age}", this.age);
        }
 
        public void Enter() //use keyword virtual for overriding this method in sub class
        {
            Console.WriteLine("User entered");
        }
    }

    class Employee:User
    {
        public Employee(string name): base(name)
        {
            
        }
        public new void Enter() //shadowing //polymorphism
        {
            Console.WriteLine("Enter inside employee"); 

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("John");
            e1.Enter();
            e1.role = role.Developer;
            Console.WriteLine($"Role:{e1.role}");
            string strRole = role.Delivery_Manager.ToString();
            Console.WriteLine($"String converted enum:{strRole}");
            //User u1 = new User();
            //u1.Enter();

            //User u2 = new Employee();
            //u2.Enter();
        }
    }
}
