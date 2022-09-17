using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    class ReadWrite
    {
        public static void Read(string path)
        {
            using(StreamReader sr=new StreamReader(path))
            {
                string content = sr.ReadToEnd(); //Reads all lines the file
                Console.WriteLine(content);
            }
        }
        public static void Write(string path)
        {
           using(StreamWriter sw=new StreamWriter(path,true)) //true for appending text to the file
            {
                string content = "All glitters are not gold..";
                sw.WriteLine(content); //to write text to the given file

            }
        }
        public static void WriteObject(string path) //add model data to the file
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                Student student = new Student() { Sid = 1, Sname = "Rohan", Age = 10 };
                sw.WriteLine(student); //to write text to the given file

            }
        }
        public static void WriteList(string path) //add list of model to the file
        {
            List<Student> list = new List<Student>()
            {
                new Student(){Sid=1,Sname="Rohan",Age=10},
                 new Student(){Sid=2,Sname="Charan",Age=10},
                  new Student(){Sid=3,Sname="Ram",Age=10},
            };
            foreach (Student item in list)
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                   
                    sw.WriteLine(item);

                }
            }
        }
    }

    class Test_ReadWrite
    {
        static void Main()
        {
            Console.WriteLine("Enter Path");
            string path = Console.ReadLine();
          // ReadWrite.Read(path);
           //ReadWrite.Write(path);
            //ReadWrite.WriteObject(path);
           ReadWrite.WriteList(path);
        }
    }
    
}
