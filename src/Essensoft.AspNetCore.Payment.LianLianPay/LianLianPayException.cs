using System;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    /// <summary>
    /// LianLianPay 异常。
    /// </summary>
    public class LianLianPayException : Exception
    {
        public LianLianPayException(string messages) : base(messages)
        {
        }
    }
}
