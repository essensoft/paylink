using System;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayException : Exception
    {
        public WeChatPayException(string messages) : base(messages)
        {
        }
    }
}
