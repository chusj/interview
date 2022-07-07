using System;

namespace AbountFactoryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct product = SimpleFactory.ShowProduct("B");
            product.Show();

            Console.WriteLine("AbountFactoryConsoleApp Test ……");
        }
    }
}
