using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class DictionarlyDemo
    {
        static void Main()
        {
            Dictionary<int, string> obj = new Dictionary<int, string>()
            {
                [12234]="Suren",
                [5678]="Jessi",
                [09089]="Peter"
            };
            Student s1 = new Student() { Sid = 1, Sname = "Rohan", Age = 20 };
            Student s2 = new Student() { Sid = 2, Sname = "Charan", Age = 12 };
            

            obj.Add(1234, "Rohan");
            string ename = obj[5678];
            foreach(KeyValuePair<int,string> item in obj)
            {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
            }
            Dictionary<int, Student> obj1 = new Dictionary<int, Student>();
            obj1.Add(s1.Sid, s1);
            obj1.Add(s2.Sid, s2);
            Dictionary<string, List<string>> obj2 = new Dictionary<string, List<string>>();
            obj2.Add("India", new List<string> { "Delhi", "Mumbai", "Chennai" });
            obj2.Add("USA", new List<string> { "Chicago", "NewJersy", "Newyork" });
        }
    }
}
