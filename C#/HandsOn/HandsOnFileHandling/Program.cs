using System;
using System.IO;
namespace HandsOnFileHandling
{
    class Program
    {
        public static void Create(string path)
        {
            File.Create(path); //Createa new file in the given path.
        }
        public static void ReadFile(string path)
        {
            try
            {
                //string content = File.ReadAllText(path); //retruns file content in string form
                                                         // Console.WriteLine(content);
                string[] content = File.ReadAllLines(path); //feturns file content in string array form
                foreach (var c in content)
                {
                    Console.WriteLine(c);
                }
            }
            catch(IOException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void WriteFile(string path,string content)
        {
            try
            {
                //string content = "Always +ve";
               // File.WriteAllText(path, content); //text always override
               File.AppendAllText(path, content+Environment.NewLine); //alway append the text
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                // Console.WriteLine("Enter the filepath to create");
                Console.WriteLine("Enter file path");
                string path = Console.ReadLine();
                //Console.WriteLine("Enter the Content");
                //string content=Console.ReadLine();
               // Create(path);
               // ReadFile(path);
                WriteFile(path,"Welcome to world of C#.net");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
