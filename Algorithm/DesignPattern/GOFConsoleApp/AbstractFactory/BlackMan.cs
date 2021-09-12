using System;

namespace GOFConsoleApp.AbstractFactory
{
    class BlackMan : Man
    {
        public override void SkinColor()
        {
            Console.WriteLine("肤色：黑色");
        }
    }
}
