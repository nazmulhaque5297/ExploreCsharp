using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExplorreCSharrp
{

 
    internal class MultiCastDeligate
    {
        public static void sampleMethodOne()
        {
            Console.WriteLine("SameMethod One");
        }
        public static void sampleMethodTwo()
        {
            Console.WriteLine("SameMethod Two");
        }

        public static int sampleIntMethodOne()
        {
            return 1;
        }
        public static int sampleIntMethodTwo()
        {
            return 2;
        }


        public static void sampleParamMethodOne(out int number)
        {
            number = 1;
        }
        public static void sampleParamMethodTwo(out int number)
        {
            number = 2;
        }
    }
}
