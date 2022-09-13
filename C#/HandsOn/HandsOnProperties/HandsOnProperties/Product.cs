using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    internal class Product
    {
        private int pid;
        private string pname;

        public Product(int pid, string pname)
        {
            this.pid = pid;
            this.pname = pname;
        }
        //Read-Only properties
        public int PID { get { return pid; } }
        public string PName { get { return pname; } }
    }
    internal class Customer
    {
        private int cid;
        private string name;
        //Write-Only Properties
        public int CID { set { cid = value; } }
        public string NAME { set { name = value; } }
        public void Details()
        {
            Console.WriteLine($"ID:{cid} Name:{name}");
        }

    }

}
