using System;

namespace Essensoft.AspNetCore.Payment.JDPay
{
    /// <summary>
    /// JDPay 异常。
    /// </summary>
    public class JDPayException : Exception
    {
        public JDPayException()
        {
        }

        public JDPayException(string messages) : base(messages)
        {
        }

        public JDPayException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
