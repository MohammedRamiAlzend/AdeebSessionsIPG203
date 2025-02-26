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
            Person person1 = new Person("Ahmad");
            Person person2 = new Person("Ziad");
            Person person3 = new Person("Reem");
            Person.Organisation = "Univ.";
            Console.WriteLine("Using instances, Person Counter is : {0} ", Person.instances);
            Person.WritePersonNumber();
            Console.WriteLine("Person Organisation is : {0} ", Person.Organisation);
            Console.WriteLine("Person1 Counter is : {0} ", person1.GetInstances());
            Console.WriteLine("Person2 Counter is : {0} ", person2.GetInstances());
            Console.WriteLine("Person3 Counter is : {0} ", person3.GetInstances());
        }
    }

}



