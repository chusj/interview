using System;

namespace SimpleFactoryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct product = SimpleFactory.ShowProduct("B");
            product.Show();

            Console.WriteLine("Hello World!");
        }
    }

    /// <summary>
    /// 产品接口 （抽象）
    /// </summary>
    public interface IProduct
    {
        void Show();
    }

    #region 具体产品

    public class ProductA : IProduct
    {
        public void Show()
        {
            Console.WriteLine("具体产品A，展示……");
        }
    }

    public class ProductB : IProduct
    {
        public void Show()
        {
            Console.WriteLine("具体产品B，展示……");
        }
    }

    public class ProductC : IProduct
    {
        public void Show()
        {
            Console.WriteLine("具体产品C，展示……");
        }
    }

    #endregion

    /// <summary>
    /// 简单工厂 —— 违背了开闭原则
    /// </summary>
    public static class SimpleFactory
    {
        public static IProduct ShowProduct(string productParam)
        {
            if(productParam =="A")
            {
                return new ProductA();
            }
            else if(productParam =="B")
            {
                return new ProductB();
            }
            else //if(productParam =="C")
            {
                return new ProductC();
            }
        }
    }
}
