﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HansOnDataTypes
{
    internal class Demo2
    {
        //Var types are not used as class-variables and method parameters
        public void M(dynamic a,dynamic b)
        {

        }
        static void Main()
        {
            //implicitly typed variable
            var i = 100;
            i = 90;
            i = 98;
            var a = 'c';
            var b = "Rohan";
            var obj = new Demo1();
           

            //dynamic
            dynamic d = 230;
          
            d = "Ram";
            string s = d;
            d = 23.45;
            double d1 = d;
            dynamic ob = new Demo1();
           
        }
    }
}
