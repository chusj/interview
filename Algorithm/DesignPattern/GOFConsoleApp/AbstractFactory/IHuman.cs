using System;

namespace GOFConsoleApp.AbstractFactory
{
    interface IHuman
    {
        /// <summary>
        /// 性别
        /// </summary>
        void Gender();
    }


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
