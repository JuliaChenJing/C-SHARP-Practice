using System;
namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /* my first program in C# */
            Console.WriteLine("Hello World");
            Console.WriteLine("a+b= " + add(3, 2));
            Console.WriteLine("a-b= " + CSharpPractice.Calculator.subtract(3, 2));
            Console.ReadKey();
        }

        private static int add(int v1, int v2)
        {
            return v1 + v2;
        }
    }
}