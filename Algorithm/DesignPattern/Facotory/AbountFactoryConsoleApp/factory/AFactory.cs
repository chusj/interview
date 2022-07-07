using System;

namespace AbountFactoryConsoleApp
{
    class AFactory : IAbstractFactory
    {
        public IProduct Create()
        {
            Console.WriteLine("具体工厂A,生成-->具体产品A..");

            return new ProductA();
        }
    }
}
