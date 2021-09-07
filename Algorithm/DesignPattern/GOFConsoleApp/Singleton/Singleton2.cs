using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFConsoleApp.Singleton
{
    public class Singleton2
    {
        private static Singleton2 instance;

        private static readonly object locker = new object();

        public Singleton2()
        {

        }

        public Singleton2 GetInstance()
        {
            /**
             * 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
             * 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
             * lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            */

            if (instance == null)  //避免锁所增加的额外开销 “双重锁定”
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Singleton2();
                    }
                }
            }
            return instance;
        }
    }
}
