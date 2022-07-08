using System;
using System.Xml;

namespace AbountFactoryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.FactoryInvoke();

            Console.WriteLine("AboutFactoryConsoleApp Test ……");
        }

        private void SimpleFactoryInvoke()
        {
            IProduct product = SimpleFactory.ShowProduct("B");
            product.Show();
        }

        private void FactoryInvoke()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("factoryconfig.xml");

            /*
            xn 代表一个结点
            xn.Name;//这个结点的名称 
            xn.Value;//这个结点的值 
            xn.ChildNodes;//这个结点的所有子结点 
            xn.ParentNode;//这个结点的父结点
            .......
            */

            string ProductName = string.Empty;

            XmlNode xn = xml.SelectSingleNode("config");
            foreach (XmlNode node in xn.ChildNodes)
            {
                if(node.HasChildNodes)
                {
                    ProductName = node.FirstChild.Value;
                }
            }
            
        }
    }
}
