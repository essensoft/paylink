using System;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    /// <summary>
    /// Alipay 异常。
    /// </summary>
    public class AlipayException : Exception
    {
        public AlipayException(string messages) : base(messages)
        {
        }
    }
}
