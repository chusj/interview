using System;

namespace GOFConsoleApp.AbstractFactory
{
    /// <summary>
    /// 男人
    /// </summary>
    abstract class Man : IHuman
    {
        public void Gender()
        {
            Console.WriteLine("性别：男");
        }

        /// <summary>
        /// 肤色
        /// </summary>
        public abstract void SkinColor();
    }
}
