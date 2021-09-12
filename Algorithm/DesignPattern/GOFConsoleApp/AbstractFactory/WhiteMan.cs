using System;

namespace GOFConsoleApp.AbstractFactory
{
    /// <summary>
    /// 白人男性
    /// </summary>
    class WhiteMan: Man
    {
        public override void SkinColor()
        {
            Console.WriteLine("肤色：白色");
        }
    }

    /// <summary>
    /// 白人女性
    /// </summary>
    class WhiteWoman : Woman
    {
        public override void SkinColor()
        {
            Console.WriteLine("肤色：白色");
        }
    }
}
