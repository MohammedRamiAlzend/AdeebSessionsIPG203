using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AdeebSessionsIPG203
{
    class Student
    {
        //declare fields 
        private string id;
        private string name;
        private int age;
        private string email;
        private decimal salary;
        private bool hasSalary;
        //default constructer
        public Student()
        {
            id = "";
            name = "";
            age = 0;
            email = "";
            salary = 0;
            hasSalary = false;
        }
        //overloaded consturecters
        public Student(string vId, string name, int age, string email, decimal salary)
        {
            id = vId;
            this.name = name;
            this.age = age;
            this.email = email;
            this.salary = salary;
            hasSalary = true;
        }
        public Student(string vId, string name, int age, string email)
        {
            id = vId;
            this.name = name;
            this.age = age;
            this.email = email;
            hasSalary= false;
        }
        //declare properties
        public decimal Salary { get => salary; set => salary = value; }
        public string Id { get => id; set => id = value; }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Email { get { return email; } set { email = value; } }
        public void PrintInformations()
        {
            Console.WriteLine($"The Id is :{id}");
            Console.WriteLine($"The Name is :{name}");
            Console.WriteLine($"The Age is :{age}");
            Console.WriteLine($"The Email is :{email}");
            if (hasSalary == true)
                Console.WriteLine($"The Salary is :{Salary}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("21", "Rami", 24, "ramialzend@gmail.com", 0);
            student.PrintInformations();
            Console.WriteLine("---------------------------------------------");
            Student student2 = new Student("22", "adeeb", 24, "adeebmansour@gmail.com");
            student2.PrintInformations();

        }
    }

}



