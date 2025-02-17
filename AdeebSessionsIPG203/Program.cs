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
        // [private] DT name;
        int id;
        public Hero hero;
        public int Id
        {
            get => id;

            set => id = value;
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name { get; set; }
        public void PrintInfo()
        {
            Id = 10;
            Console.WriteLine("The name is {0}, The age is: {1} {2}", Name, Age , hero.Id);
        }

    }

    class Hero
    {
        public int Id { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.hero = new Hero();
            student.PrintInfo();    
        }
    }
}
