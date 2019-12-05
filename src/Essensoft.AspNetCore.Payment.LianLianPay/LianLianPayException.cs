using System;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    /// <summary>
    /// LianLianPay 异常。
    /// </summary>
    public class LianLianPayException : Exception
    {
        public LianLianPayException()
        {
        }

        public LianLianPayException(string messages) : base(messages)
        {
        }

        public LianLianPayException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
