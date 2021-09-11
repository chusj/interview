using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
