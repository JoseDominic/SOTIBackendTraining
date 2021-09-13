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

    abstract class User //classes that contain abstract methods are declared abstract //used to provide partial implementation
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
 
        void Enter() //use keyword virtual for overriding this method in sub class
        {
            Console.WriteLine("User entered");
        }

        //abstract method
        public abstract void Register();//abstract methods are meant to be overriden by subclasses
    }

    class Employee:User
    {
        public Employee(string name): base(name)
        {
            
        }
        public void Enter() //shadowing //polymorphism
        {
            Console.WriteLine("Enter inside employee"); 

        }

        public override void Register() // other imp keywords to learn (new, virtual)
        {
            Console.WriteLine("New Employee registered");
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
