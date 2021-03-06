using System;
using System.Collections.Generic;
using GOFConsoleApp.Strategy;
using GOFConsoleApp.Singleton;
using GOFConsoleApp.FactoryMethod;
using GOFConsoleApp.AbstractFactory;
using GOFConsoleApp.Observer;

namespace GOFConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //NvWa nv = new NvWa();
            //nv.SimpleFactory();

            //Console.WriteLine("======================分割线=======================");
            //nv.Factory();

            //NvWa2 wa2 = new NvWa2();
            //wa2.Create();

            Program p = new Program();
            p.ObserverMode();

            Console.ReadKey();
        }

        /// <summary>
        /// 策略模式
        /// </summary>
        /// <param name="clientId"></param>
        private void StrategyMode(string clientId)
        {
            List<string> list = new List<string>();
            list.Add("");

            ISendMessage send;

            if (clientId == "A")
            {
                send = new ClientASendMsgImpl();
            }
            else if (clientId == "B")
            {
                send = new ClientBSendMsgImpl();
            }
            else
            {
                send = new SendMsgImpl();
            }

            send.SendMessage("", list);
        }

        /// <summary>
        /// 单例模式
        /// </summary>
        private void SingletonModel()
        {
            //无法实例化，编译错误
            //SingletonDemo singleton = new SingletonDemo();

            SingletonDemo demo =  SingletonDemo.GetInstance();
        }


        private void ObserverMode()
        {
            Secretary qiantai = new Secretary();
            StockObserver tongshi1 = new StockObserver("chusj",qiantai);
            StockObserver tongshi2 = new StockObserver("chenhao", qiantai);

            qiantai.Attach(tongshi1);
            qiantai.Attach(tongshi2);


            qiantai.SecretaryAction = "老板回来了……";
            qiantai.Notify();
        }
    }
}
