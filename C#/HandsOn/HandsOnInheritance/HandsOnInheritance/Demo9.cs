using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    //sealed methods are not going to overriddern in chile class
    //sealed methods should be override methods
    class AAA
    {
        public virtual void Details()
        {

        }
    }
    class BBB:AAA
    {
        public  sealed override void Details()
        {
            base.Details();
        }
    }
    class CCC : BBB {
        //public override void Details() //details can not be override becuase it is sealed in BBB
        //{
        //    base.Details();
        //}
    }

    internal class Demo9
    {
        static void Main()
        {

        }
    }
}
