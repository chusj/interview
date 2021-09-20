using System;

namespace GOFConsoleApp.Observer
{
    public class StockObserver
    {
        private string name;
        private Secretary secretary;

        public StockObserver(string name, Secretary secretary)
        {
            this.name = name;
            this.secretary = secretary;
        }

        public void Update()
        {
            Console.WriteLine("{0}{1} 关闭股票行情，继续工作！", secretary.SecretaryAction, name);
        }
    }
}