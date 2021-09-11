using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            HumanFacotry facotry = new HumanFacotry();
            Console.WriteLine("女娲开始造人了，时间太久……");
            IHuman human = facotry.CreateHuman(1);
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
