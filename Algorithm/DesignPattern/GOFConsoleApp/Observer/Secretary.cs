using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFConsoleApp.Observer
{
    public class Secretary
    {
        private List<StockObserver> observers = new List<StockObserver>();
        private string action;

        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }

        public string SecretaryAction
        {
            get { return action; }
            set { action = value; }
        }

        public void Attach(StockObserver observer)
        {
            observers.Add(observer);
        }
    }
}
