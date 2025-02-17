using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RamiSessionsIPG203;
namespace AdeebSessionsIPG203
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetName("Rami");
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetName());

            student.SetName("Adeeb");
            Console.WriteLine(student.GetName());

            Console.WriteLine("Hello Adeeb");
        }
    }
    class Student
    {
        private string name;

        public void SetName(string newName)
        {
            name = newName;
        }
        public string GetName()
        {
            return name;
        }
    }
}
