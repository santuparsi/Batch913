using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    internal class Demo1
    {
        static void Main()
        {
            #region Demo on Exception Properties
            try
            {
                int[] n = { 12, 23, 34, 45, 56, 67, 78, 89 };
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Array value: " + n[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Project Name: " + ex.Source);
                Console.WriteLine("Method Name: " + ex.TargetSite);
                Console.WriteLine("Error Info: " + ex.StackTrace);
               
            }
            #endregion
        }
    }
}
