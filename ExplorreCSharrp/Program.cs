using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorreCSharrp
{
    // ho here i introduce a helloPrinterDelegiate Where it is a void type cast and
    // it can point a function which return type is void and can take string as a parameteer 
    public delegate void helloPrinterDeligate(string ms);
    internal class Program
    {

        
        static void Main(string[] args)
        {
       
            Deligate de = new Deligate();
            helloPrinterDeligate d = new helloPrinterDeligate(de.helloPrinter);
            d("hi this is nazmul call from a delegeate");

            Console.ReadLine();
        }
    }
}
