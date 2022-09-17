using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    class Demo1
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the File Path");
                string path = Console.ReadLine();
                FileInfo obj = new FileInfo(path);
                if (obj.Exists)
                {
                    Console.WriteLine("Name: " + obj.Name);
                   // obj.CopyTo("D://Demo1.txt"); //Demo1.txt should not exisit
                   obj.CopyTo("D://Demo1.txt",true); //override the file if it is exist
                    Console.WriteLine("Created Date: "+obj.CreationTime);
                    Console.WriteLine($"Size in {obj.Length}KB");
                }
                else
                    Console.WriteLine("Invalid File Path");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
