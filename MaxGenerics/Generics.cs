using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class GenericMaximum<T> where T : IComparable
    {

        T[] Value;

        public GenericMaximum(T[] Value)
        {
            this.Value = Value;
        }

        public T[] Sort(T[] Value)
        {
            Array.Sort(Value);
            return Value;
        }

        public T MaxValue(params T[] Value)
        {
            var sorted_value = Sort(Value);
            return sorted_value[^1];
        }

        public T MaxMethod()
        {
            var  max = MaxValue(this.Value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.Value);
            Console.WriteLine("Max value is" + max);
        }
    }
}
