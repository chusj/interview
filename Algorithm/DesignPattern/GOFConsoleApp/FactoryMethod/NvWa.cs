using System;

namespace GOFConsoleApp.FactoryMethod
{
    /// <summary>
    /// 女娲
    /// </summary>
    class NvWa
    {
        /// <summary>
        /// 简单工厂模式
        /// 优点：将对象的创建交给专门的工厂类负责，实现了对象的创建和对象的使用分离。
        /// 缺点：工厂类不够灵活，增加新的具体产品需要修改工厂类的判断逻辑代码
        /// </summary>
        public void SimpleFactory()
        {
            //优点：将对象的创建交给专门的工厂类负责，实现了对象的创建和对象的使用分离。
            HumanFacotry facotry = new HumanFacotry();
            Console.WriteLine("女娲 SimpleFactory() 造人了，时间太久……");
            IHuman human = facotry.CreateHuman(1); //缺点：工厂类不够灵活，增加新的具体产品需要修改工厂类的判断逻辑代码
            human.SkinColor();
            human.Say();

            Console.WriteLine("+++++++++++再来一次++++++++++++");

            Console.WriteLine("又开始造人了，时间短了……");
            human = facotry.CreateHuman(2);
            human.SkinColor();
            human.Say();
        }

        /// <summary>
        /// 工厂模式
        ///  优点：遵循了开闭原则，扩展性极强
        ///  缺点：增加了类的数量
        /// </summary>
        public void Factory()
        {
            Console.WriteLine("女娲  Factory() 造人了，时间太久……");
            AbstractHumanFacotry facotry = new BlackHumanFactory();
            IHuman human = facotry.CreateHuman();
            human.SkinColor();
            human.Say();

            Console.WriteLine("+++++++++++再来一次++++++++++++");

            Console.WriteLine("又开始造人了，时间短了……");
            AbstractHumanFacotry facotry2 = new WhiteHumanFactory();
            human = facotry2.CreateHuman();
            human.SkinColor();
            human.Say();
        }
    }
}
