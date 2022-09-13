using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMemoryManagement
{
    internal class Student
    {
        public Student()
        {
            Console.WriteLine("Object is Created");
        }
        ~ Student() //destructor
        {
            Console.WriteLine("Object is Disposed");
        }
        static void Main()
        {
            Student s = new Student();
            Console.ReadKey();
        }
    }
}
