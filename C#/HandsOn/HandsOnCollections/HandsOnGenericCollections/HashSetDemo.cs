using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class HashSetDemo
    {
        static void Main()
        {
            HashSet<int> hs1 = new HashSet<int>() { 12, 23, 34, 45,45 };
            HashSet<int> hs2 = new HashSet<int>() { 34, 45, 56, 67, 78, 89, 90, 89 };
            // hs1.UnionWith(hs2);
            hs1.IntersectWith(hs2);
            foreach(var k in hs1)
            {
                Console.WriteLine(k);
            }
        }
    }
}
