using System;

namespace GOFConsoleApp.FactoryMethod
{
    class WhiteHuman : IHuman
    {
        public void Say()
        {
            Console.WriteLine("我来自欧洲");
        }

        public void SkinColor()
        {
            Console.WriteLine("我的皮肤是白色");
        }
    }
}
