using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorreCSharrp
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodHidding mh = new MethodHidding();
            mh.DisplayEmployeeName();

            Console.ReadLine();
        }
    }
}
