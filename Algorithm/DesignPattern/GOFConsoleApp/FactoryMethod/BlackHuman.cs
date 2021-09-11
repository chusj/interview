using System;

namespace GOFConsoleApp.FactoryMethod
{
    class BlackHuman : IHuman
    {
        public void Say()
        {
            Console.WriteLine("我来自非洲");
        }

        public void SkinColor()
        {
            Console.WriteLine("我的皮肤是黑色");
        }
    }
}
