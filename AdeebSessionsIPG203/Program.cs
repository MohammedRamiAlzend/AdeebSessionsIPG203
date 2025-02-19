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
        int x;
        public Program()
        {
            x = 55;
        }
        public Program(int number)
        {
            x= number;
        }
        static void Main(string[] args)
        {
            Program o2 = new Program();
            Program o = new Program(33);
            Console.WriteLine(o2.x);
            Console.WriteLine(o.x);
        }
    }
}
