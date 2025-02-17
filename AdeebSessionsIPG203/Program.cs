using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeebSessionsIPG203
{
    class StudentClass
    {
        public string Name { get; set; }
    }
    struct StudentStruct
    {
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- Referance Type ----------------");
            StudentClass student = new StudentClass();
            student.Name = "Adeeb";
            Console.WriteLine(student.Name);

            StudentClass student2 = student;
            student2.Name = "Rami";
            Console.WriteLine(student.Name);
            Console.WriteLine("--------------- Referance Type ----------------");
            /*********************************************/
            Console.WriteLine("/**********************************************/");
            Console.WriteLine("--------------- Value Type ----------------");
            StudentStruct studentstruct = new StudentStruct();
            studentstruct.Name = "Adeeb";
            Console.WriteLine(studentstruct.Name);

            StudentStruct student2struct = studentstruct;
            student2struct.Name = "Rami";
            Console.WriteLine(studentstruct.Name);
            Console.WriteLine("--------------- Value Type ----------------");

        }
    }
}
