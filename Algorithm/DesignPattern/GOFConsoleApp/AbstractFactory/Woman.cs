using System;

namespace GOFConsoleApp.AbstractFactory
{
    abstract class Woman : IHuman
    {
        /// <summary>
        /// 女人
        /// </summary>
        public void Gender()
        {
            Console.WriteLine("性别：女");
        }

        /// <summary>
        /// 肤色
        /// </summary>
        public abstract void SkinColor();
    }
}
