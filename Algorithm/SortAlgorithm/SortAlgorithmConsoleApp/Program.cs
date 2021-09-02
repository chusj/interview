using System;

namespace SortAlgorithmConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = { 56,4,33,22,18 };
            //int sum = Recursion.GetSum(arr, arr.Length);
            //Console.WriteLine(sum);

            PrintArray(BubbleSort.Sort(arr));

            Console.ReadKey();
        }


        private static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item);
                Console.Write("、");
            }
        }
    }
}
