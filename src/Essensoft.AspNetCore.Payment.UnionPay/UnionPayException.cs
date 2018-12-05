using System;

namespace Essensoft.AspNetCore.Payment.UnionPay
{
    /// <summary>
    /// UnionPay 异常。
    /// </summary>
    public class UnionPayException : Exception
    {
        public UnionPayException(string messages) : base(messages)
        {
        }
    }
}
