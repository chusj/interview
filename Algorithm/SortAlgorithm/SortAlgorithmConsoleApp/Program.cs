using System;

namespace SortAlgorithmConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = Recursion.GetSum(arr, arr.Length);

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
