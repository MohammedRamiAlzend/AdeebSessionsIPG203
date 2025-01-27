using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeebSessionsIPG203
{
    internal class Adeeb
    {
        private static void DisplayAdeebName()
        {
            Program program = new Program();
            Console.WriteLine("Adeeb");
            program.IsOdd(10);
            program.DisplayHello();
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Beep();
        }
       public void DisplayHello()
        {
            Console.WriteLine("Hello");
        }
       public bool IsEven(int num)
        {
            bool result = num % 2 == 0;
            return result;
        }
       public void IsOdd(int num)
        {
            bool result = num % 2 == 1;
            Console.WriteLine(result);
        }
        /*
         * to declare function or method
         * [AccessModifire] [static or not static] ReturnType MethodName(parameters)
         * {
         * 
         * }
         * where i can declare a function?
         * any were in class scoop
         */
        /*
         * How I can declare an Object?
         * int x = 10;
         * DataType name = new Datatype();
         * Person adeeb = new Person("Adeeb","mansour",24 , etc...);
         */
    }
}
