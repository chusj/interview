using System;
using System.Collections.Generic;
using System.Text;

namespace AbountFactoryConsoleApp
{
    class SimpleFactory
    {
        public static IProduct ShowProduct(string productParam)
        {
            if (productParam == "A")
            {
                return new ProductA();
            }
            else if (productParam == "B")
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
