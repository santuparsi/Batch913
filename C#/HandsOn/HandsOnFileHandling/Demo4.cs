using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    //Working with Binary data
    internal class Demo4
    {
        public static void WriteData(string path) //Writing binary data
        {
            string content = "FileHandling with Binary data.";
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write)) 
            {
                byte[] data = new UTF8Encoding().GetBytes(content); //convert string into binary
                fs.Write(data, 0, data.Length);
            }
        }
        public static void ReadDate(string path) //Reading binary data
        {
            string content = "";
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] data = new byte[fs.Length]; //fs.Lenght returs file lenth
                fs.Read(data, 0, data.Length); //Read method reads binary data to the Byte array
                //Convert byte data to string
                content=new UTF8Encoding().GetString(data);
                Console.WriteLine(content);
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter Path");
            string path=Console.ReadLine();
            //WriteData(path);
            ReadDate(path); 
            
        }
    }
}
