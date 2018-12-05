using System;

namespace Essensoft.AspNetCore.Payment.QPay
{
    /// <summary>
    /// QPay 异常。
    /// </summary>
    public class QPayException : Exception
    {
        public QPayException(string messages) : base(messages)
        {
        }
    }
}
