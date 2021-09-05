using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFConsoleApp.Strategy
{
    /// <summary>
    /// 短信发送（默认）
    /// </summary>
    class SendMsgImpl : ISendMessage
    {
        public int GetBalance(string accountId)
        {
            //此处略过，实现方法体
            //...
            throw new NotImplementedException();
        }


        public string SendMessage(string contents, List<string> mobiles)
        {
            //此处略过，实现方法体
            //...
            throw new NotImplementedException();
        }
    }
}
