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
    class ClientASendMsgImpl : ISendMessage
    {
        public int GetBalance(string accountId)
        {
            //...
            //访问移动云MAS短信平台
            throw new NotImplementedException();
        }

        public string SendMessage(string contents, List<string> mobiles)
        {
            throw new NotImplementedException();
        }
    }
}
