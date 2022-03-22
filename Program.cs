using System;

namespace day13_find_max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to find the max number");
            Console.WriteLine("enter three numbers");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int c=int.Parse(Console.ReadLine());
            Console.WriteLine("the maximum number among three number is :");
            Console.WriteLine(FindMax(a, b, c));
            Console.WriteLine("enter three double numbers");
            double d=double.Parse(Console.ReadLine());
            double e=double.Parse(Console.ReadLine());
            double f=double.Parse(Console.ReadLine());
            Console.WriteLine("the maximum double number among three number is :");
            Console.WriteLine(FindMaxDouble(d, e, f));


        }
        public static int FindMax(int a,int b,int c)
        {
            if(a.CompareTo(b) > 0&& a.CompareTo(c) > 0||a.CompareTo(b)>=0&&a.CompareTo(c)>0||a.CompareTo(b)>0&&a.CompareTo(c)>=0)
            {
                return a;
            }
            else if(b.CompareTo(a) > 0 && b.CompareTo(c) > 0 || b.CompareTo(a) >= 0 && b.CompareTo(c) > 0 || b.CompareTo(a) > 0 && b.CompareTo(c) >= 0)
            {
                return b;
            }
            else if(c.CompareTo(b) > 0 && c.CompareTo(a) > 0 || c.CompareTo(b) >= 0 && c.CompareTo(a) > 0 || c.CompareTo(b) > 0 && c.CompareTo(a) >= 0)
            {
                return c;
            }
            return a;
        }
        public static double FindMaxDouble(double a, double b, double c)
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
