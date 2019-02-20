using System;

namespace Essensoft.AspNetCore.Payment.LcswPay
{
    /// <summary>
    /// 利楚商务扫呗支付异常信息
    /// </summary>
    public class LcswPayException : Exception
    {
        public LcswPayException(string message) : base(message) { }
    }
}
