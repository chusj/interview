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
        /// </summary>
        public void SimpleFactory()
        {
            //优点：将对象的创建交给专门的工厂类负责，实现了对象的创建和对象的使用分离。
            HumanFacotry facotry = new HumanFacotry();
            Console.WriteLine("女娲开始造人了，时间太久……");
            IHuman human = facotry.CreateHuman(1); //缺点：工厂类不够灵活，增加新的具体产品需要修改工厂类的判断逻辑代码
            human.SkinColor();
            human.Say();

            Console.WriteLine("+++++++++++再来一次++++++++++++");

            Console.WriteLine("又开始造人了，时间短了……");
            human = facotry.CreateHuman(2);
            human.SkinColor();
            human.Say();
        }
    }
}
