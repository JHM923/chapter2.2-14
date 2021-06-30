using System;
using System.Collections.Generic;

namespace chapter2._2_14
{
    class Program
    {
        static IEnumberable<string> Iterator()
        {
            try{
                Console.WriteLine("Before first yield");
                yield return "first";
                Console.WriteLine("Between yields");
                yield return "second";
                Console.WriteLine("After second yield");
            }
            finally
            {
                Console.WriteLine("In finally block");
            }
        }
        static void Main()
        {
           foreach (string value in Iterator())
           {
               Console.WriteLine("Received value: {0}", value);
           }
           Console.ReadKey();
        }
    }
}
