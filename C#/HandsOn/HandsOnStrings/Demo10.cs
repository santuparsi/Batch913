using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class Student { }
    class Demo10
    {
        static void Main()
        {
            //Immutable string
            string str = "Good Morning Users";
            str.Replace("Morning", "Evening");
            Console.WriteLine(str);
            //Mutable strings
            StringBuilder obj = new StringBuilder("Good Morning ");
            obj.AppendLine("Users");
            Console.WriteLine(obj);
            obj.Replace("Morning", "Evening");
            Console.WriteLine(obj);

        }
    }
}
