using System;

namespace Essensoft.AspNetCore.Payment.UnionPay
{
    /// <summary>
    /// UnionPay 异常。
    /// </summary>
    public class UnionPayException : Exception
    {
        public UnionPayException()
        {
        }

        public UnionPayException(string messages) : base(messages)
        {
        }

        public UnionPayException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
