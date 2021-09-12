using System;

namespace GOFConsoleApp.AbstractFactory
{
    class WhiteWoman : Woman
    {
        public override void SkinColor()
        {
            Console.WriteLine("肤色：白色");
        }
    }
}
