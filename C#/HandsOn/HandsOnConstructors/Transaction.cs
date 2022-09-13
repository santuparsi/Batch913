using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructors
{
    internal class Transaction
    {
        private Transaction() //prevents create object
        {

        }
        public static Transaction CreateObject()
        {
            return new Transaction();
        }
        public void F()
        {
            Console.WriteLine("I am a functions");
        }
    }
    class Test
    {
        static void Main()
        {
            //Transaction obj = new Transaction(); //Prevent object creation
            Transaction obj = Transaction.CreateObject();
            obj.F();
        }
    }
}
