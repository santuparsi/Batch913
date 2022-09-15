using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    class Demo4
    {
        public static int Div(int a,int b)
        {
            try
            {
                int result = a / b;
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
         finally
            {
                Console.WriteLine("Hay Exception Handling!!");
            }
        }
        static void Main()
        {
            #region Demo on Finally block
            Console.WriteLine("Enter a,b values");
            try
            {
                byte i = byte.Parse(Console.ReadLine());
                byte j = byte.Parse(Console.ReadLine());
                int result = i / j;
                Console.WriteLine("Divison: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("J value should not be 0");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("enter only no's");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            finally
            {
                Console.WriteLine("ExceptionHandling Demo's");
                Console.WriteLine("Hay Guys Good Morning");
                //closing connections objects
                //closing file objects
            }
            #endregion
            //Console.WriteLine(Div(4, 2));
        }
    }
}
