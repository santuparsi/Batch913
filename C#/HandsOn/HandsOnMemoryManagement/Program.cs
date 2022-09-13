using System.IO;
namespace HandsOnMemoryManagement
{
    class Sample : IDisposable
    {
        public void Dispose()
        {
            //clean up code.
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader("");
                string content=sr.ReadToEnd();
                sr.Dispose();
                //after execution object memery is disposed autimatically
                using(StreamWriter sw = new StreamWriter(""))
                {
                    sw.WriteLine(content);
                }
                using (Sample s = new Sample())
                {
                   
                }
                Sample s1 = new Sample();
                s1.Dispose();
            }
            catch (Exception ex)
            {

            }
        }
    }
}