using System;

namespace GOFConsoleApp.AbstractFactory
{
    /// <summary>
    /// 黑人男性
    /// </summary>
    class BlackMan : Man
    {
        public override void SkinColor()
        {
            Console.WriteLine("肤色：黑色");
        }
    }

    /// <summary>
    /// 黑人女性
    /// </summary>
    class BlackWoman : Woman
    {
        public override void SkinColor()
        {
            Console.WriteLine("肤色：黑色");

        }
    }
}
