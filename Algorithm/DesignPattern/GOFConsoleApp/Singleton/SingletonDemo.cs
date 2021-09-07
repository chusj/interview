using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFConsoleApp.Singleton
{
    class SingletonDemo
    {

        private static SingletonDemo instance;

        private SingletonDemo()
        {
            //设置私有，禁止被实例化
        }

        public static SingletonDemo GetInstance()
        {
            if(instance == null)
            {
                instance = new SingletonDemo();
            }

            return instance;
        }
    }
}
