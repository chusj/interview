using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
