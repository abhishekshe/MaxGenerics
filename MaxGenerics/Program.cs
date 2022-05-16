using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 112, 22, 222, 432, 555, 678 };

            GenericMaximum<int> generic = new GenericMaximum<int>(arr);
            generic.PrintMaxValue();

            //Console.WriteLine("find max problem");

            //int maxInt = NonGenericClass.MaxIntegerNumber(23, 24, 22);
            //Console.WriteLine("max integer value is\t" + maxInt);

            //Console.WriteLine("find max problem");

            //double maxDouble = NonGenericClass.MaxDoubleNumber(23.4, 24.7, 22.1);
            //Console.WriteLine("max integer value is\t" + maxDouble);

            //Console.WriteLine("find max problem");

            //string maxString = NonGenericClass.MaxString("Apple", "Peach", "Banana");
            //Console.WriteLine("max integer value is\t" + maxString);


        }
    }
}