using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AdeebSessionsIPG203
{
    class Person
    {
        public static int instances = 0;
        private string name;
        public static string Organisation { get; set; }
        public int GetInstances()
        {
            return instances;
        }
        public static void WritePersonNumber()
        {
            Console.WriteLine("Using WritePersonNumber, Person Counter is : {0} ",
           instances);
        }
        public Person(string name)
        {
            instances++;
            this.name = name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public  void PrintInfo()
        {
            Console.WriteLine(instances);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.MyValue = 1;

            Test t2 = new Test();
            t2.MyValue = 3;

            Console.WriteLine(t.MyValue);
        }

    }
    public class Test
    {
        public int MyValue { get; set; }
    }
}



