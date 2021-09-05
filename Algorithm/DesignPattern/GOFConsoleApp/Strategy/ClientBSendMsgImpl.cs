using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFConsoleApp.Strategy
{
    /// <summary>
    /// A客户短信发送
    /// </summary>
    class ClientBSendMsgImpl : ISendMessage
    {
        public int GetBalance(string accountId)
        {
            throw new NotImplementedException();
        }

        public string SendMessage(string contents, List<string> mobiles)
        {
            throw new NotImplementedException();
        }
    }
}
