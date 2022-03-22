using System;

namespace day13_find_max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to find the max number");
            Console.WriteLine("enter the values");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] =int.Parse(Console.ReadLine());
            }
            GenericClass<int> intMax=new GenericClass<int>(arr);
            Console.WriteLine(intMax.MaxMethod());
            Console.WriteLine("enter the float values");
            float[] arrFloat=new float[5];
            for(int i = 0; i < arrFloat.Length; i++)
            {
                arrFloat[i]= float.Parse(Console.ReadLine());
            }
            GenericClass<float> floatMax=new GenericClass<float>(arrFloat);
            Console.WriteLine(floatMax.MaxMethod());
            Console.WriteLine("enter the string values");
            string [] arrString=new string[5];
            for(int i=0; i < arrString.Length; i++)
            {
                arrString[i]= Console.ReadLine();
            }
            GenericClass<string> stringMax=new GenericClass<string>(arrString);
            Console.WriteLine(stringMax.MaxMethod());

        }
       
    }
}
