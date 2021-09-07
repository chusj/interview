namespace GOFConsoleApp.Singleton
{
    class SingletonDemo
    {
        private static SingletonDemo instance;

        private SingletonDemo()
        {
            //设置私有，禁止被实例化
        }

        /// <summary>
        /// 获取实例
        /// </summary>
        /// <returns></returns>
        public static SingletonDemo GetInstance()
        {
            //在多线程的情况下会得到多个Singleton实例,因为在两个线程同时运行GetInstance方法时，此时两个线程判断(uniqueInstance ==null)这个条件时都返回真
            if (instance == null)
            {
                instance = new SingletonDemo();
            }

            return instance;
        }
    }
}
