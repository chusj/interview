namespace GOFConsoleApp.AbstractFactory
{
    /// <summary>
    /// 人类抽象工厂
    /// </summary>
    abstract class AbstractHumanFactory
    {
        /// <summary>
        /// 创建男人
        /// </summary>
        /// <returns></returns>
        public abstract Man CreateMan();

        /// <summary>
        /// 创建女人
        /// </summary>
        /// <returns></returns>
        public abstract Woman CreateWoman();
    }

    /// <summary>
    /// 黑人工厂类
    /// </summary>
    class BlackHumanFactory : AbstractHumanFactory
    {
        public override Man CreateMan()
        {
            return new BlackMan(); ;
        }

        public override Woman CreateWoman()
        {
            return new BlackWoman();
        }
    }
    
    /// <summary>
    /// 白人工厂内
    /// </summary>
    class WhiteHumanFactory : AbstractHumanFactory
    {
        public override Man CreateMan()
        {
            return new WhiteMan();
        }

        public override Woman CreateWoman()
        {
            return new WhiteWoman();
        }
    }
}
