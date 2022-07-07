using System;

namespace AbountFactoryConsoleApp
{
    class CFactory : IAbstractFactory
    {
        public IProduct Create()
        {
            Console.WriteLine("具体工厂C,生成-->具体产品C..");

            return new ProductC();
        }
    }
}
