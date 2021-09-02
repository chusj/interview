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

            ISort sort = new Selection();
            PrintArray(sort.Sort(arr));

            double[] doubleArray = { 1.5, 0.3, 3.4, 1.1, 0.1 };
            ISortGeneric sortGeneric = new Insertion();
            PrintArray(sortGeneric.Sort(doubleArray));

            Console.ReadKey();
        }


        private static void PrintArray<T> (T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item);
                Console.Write("、");
            }
        }
    }
}
