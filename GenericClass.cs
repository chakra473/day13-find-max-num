using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13_find_max
{
    internal class GenericClass<T> where T : IComparable
    {
        public T[] value;
        public GenericClass(T[] value)
        {
            this.value = value;
        }
        public T[] sort(T[] values)
        {
            Array.Sort(values);
            return value;
        }
        public T MaxValue(params T[] values)
        {
            var sorted=sort(values);
            return sorted[^1];
        }
        public T MaxMethod()
        {
            var max=MaxValue(this.value);
            return max;
        }
    }
}
