using System;
using System.Collections.Generic;

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
            GenericClass<int> IntMax=new GenericClass<int>(a,b,c);
            Console.WriteLine(IntMax.FindMaxMethod());
            Console.WriteLine("enter three double numbers");
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine("the maximum double number among three number is :");
            GenericClass<double> DoubleMax=new GenericClass<double>(d,e,f);
            Console.WriteLine(DoubleMax.FindMaxMethod());
            Console.WriteLine("the three string");
            string g = Console.ReadLine();
            string h = Console.ReadLine();
            string i = Console.ReadLine();
            Console.WriteLine("the maximum among three string is :");
            GenericClass<string> StringMax=new GenericClass<string>(g,h,i);
            Console.WriteLine(StringMax.FindMaxMethod());
            
            




        }
       
        
    }
}
