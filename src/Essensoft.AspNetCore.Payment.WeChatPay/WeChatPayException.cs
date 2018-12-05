using System;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// WeChatPay 异常。
    /// </summary>
    public class WeChatPayException : Exception
    {
        public WeChatPayException(string messages) : base(messages)
        {
        }
    }
}
