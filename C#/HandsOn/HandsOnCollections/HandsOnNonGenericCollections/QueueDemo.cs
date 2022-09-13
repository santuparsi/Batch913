using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class QueueDemo
    {
        static void Main()
        {
            //Write Demo here to exaplin Queue methods.
            Queue obj = new Queue();
            obj.Enqueue(12);
            obj.Enqueue(22);
            obj.Enqueue(32);
            obj.Enqueue(42);
            obj.Enqueue(52);

            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(obj.Peek()); //returns first value
            obj.Dequeue(); //remove item
            Console.WriteLine();

            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }

        }
    }
}
