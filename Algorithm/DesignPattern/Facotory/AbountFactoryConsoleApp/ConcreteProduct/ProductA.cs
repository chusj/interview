using System;

namespace AbountFactoryConsoleApp
{
    public class ProductA : IProduct
    {
        public void Show()
        {
            Console.WriteLine("产品A，显示……");
        }
    }
}
