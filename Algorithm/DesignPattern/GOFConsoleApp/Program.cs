using System;
using System.Collections.Generic;
using GOFConsoleApp.Strategy

namespace GOFConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //策略模式
            string ClientId = "";

            Console.WriteLine("Hello World!");
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
    }
}
