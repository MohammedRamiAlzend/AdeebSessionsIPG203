using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AdeebSessionsIPG203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape rect = new Shape(1,2);
            Console.WriteLine(rect.Area());
        }
        static void Display()
        {
            Console.WriteLine("Hello");
        }
        static void Display(string message) {
            Console.WriteLine(message);
        }
        static void Display(string message,int age)
        {
            Console.WriteLine("{0} {1}",message,age);
        }
        static void Display( int age, string message)
        {
            Console.WriteLine("{0}", age);
        }
    }
}



