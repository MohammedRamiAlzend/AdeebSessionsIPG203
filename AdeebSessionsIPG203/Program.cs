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
        int id;
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
            Console.WriteLine("The name is {0}, The age is: {1}", Name, Age);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
