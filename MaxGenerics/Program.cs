using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("find max problem");

            int maxInt = NonGenericClass.MaxIntegerNumber(23, 24, 22);
            Console.WriteLine("max integer value is\t" + maxInt);

           
        }
    }
}