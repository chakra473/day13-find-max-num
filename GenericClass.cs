using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13_find_max
{
    internal class GenericClass<T> where T : IComparable
    {
        public  T FindMax(T a, T b, T c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0 || a.CompareTo(b) >= 0 && a.CompareTo(c) > 0 || a.CompareTo(b) > 0 && a.CompareTo(c) >= 0)
            {
                return a;
            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 || b.CompareTo(a) >= 0 && b.CompareTo(c) > 0 || b.CompareTo(a) > 0 && b.CompareTo(c) >= 0)
            {
                return b;
            }
            else if (c.CompareTo(b) > 0 && c.CompareTo(a) > 0 || c.CompareTo(b) >= 0 && c.CompareTo(a) > 0 || c.CompareTo(b) > 0 && c.CompareTo(a) >= 0)
            {
                return c;
            }
            return a;
        }
    }
}
