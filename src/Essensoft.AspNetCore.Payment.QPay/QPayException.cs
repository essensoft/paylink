using System;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public class QPayException : Exception
    {
        public QPayException(string messages) : base(messages)
        {
        }
    }
}
