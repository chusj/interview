using System;

namespace GOFConsoleApp.AbstractFactory
{
    class WhiteMan: Man
    {
        public override void SkinColor()
        {
            Console.WriteLine("肤色：白色");
        }
    }
}
