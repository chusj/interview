using System;

namespace AbountFactoryConsoleApp
{
    class BFactory : IFactory
    {
        public IProduct Create()
        {
            Console.WriteLine("具体工厂B,生成-->具体产品B..");

            return new ProductB();
        }
    }
}
