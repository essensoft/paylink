using System;

namespace Essensoft.AspNetCore.Payment.JDPay
{
    /// <summary>
    /// JDPay 异常。
    /// </summary>
    public class JDPayException : Exception
    {
        public JDPayException(string messages) : base(messages)
        {
        }
    }
}
