using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFConsoleApp.Strategy
{
    /// <summary>
    /// 短信发送接口
    /// </summary>
    interface ISendMessage
    {
        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="contents">手机内容</param>
        /// <param name="mobiles">手机号码列表</param>
        /// <returns></returns>
        string SendMessage(string contents, List<string> mobiles);

        /// <summary>
        /// 获取余额
        /// </summary>
        /// <param name="accountId">账号id</param>
        /// <returns></returns>
        int GetBalance(string accountId);
    }
}
