using System;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    /// <summary>
    /// Alipay客户端异常。
    /// </summary>
    public class AlipayException : Exception
    {
        public AlipayException()
            : base()
        {
        }

        public AlipayException(string message)
            : base(message)
        {
        }

        public AlipayException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public AlipayException(string errorCode, string errorMsg)
            : base(errorCode + ":" + errorMsg)
        {
            ErrorCode = errorCode;
            ErrorMsg = errorMsg;
        }

        public string ErrorCode { get; }

        public string ErrorMsg { get; }
    }
}
