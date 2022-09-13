using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    //sealed class are declard with sealed keywork
    //sealed class are not inherited to any other class
    //sealed class are instantiated
   class II
    {

    }
    sealed class JJ:II
    {
        public void M() { }
    }
    class KK
    {

    }
    internal class Demo8
    {
        static void Main()
        {
            JJ obj = new JJ(); //sealed classes are instantiated
            obj.M();
        }
    }
}
