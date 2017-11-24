using System;

namespace Essensoft.AspNetCore.Alipay
{
    /// <summary>
    /// Alipay客户端异常。
    /// </summary>
    public class AlipayException : Exception
    {
        private string errorCode;
        private string errorMsg;

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
            this.errorCode = errorCode;
            this.errorMsg = errorMsg;
        }

        public string ErrorCode
        {
            get { return errorCode; }
        }

        public string ErrorMsg
        {
            get { return errorMsg; }
        }
    }
}
