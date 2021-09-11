namespace GOFConsoleApp.FactoryMethod
{
    abstract class AbstractHumanFacotry
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract IHuman CreateHuman();


        //优点：遵循了开闭原则，扩展性极强
        //缺点：增加了类的数量
    }
}
