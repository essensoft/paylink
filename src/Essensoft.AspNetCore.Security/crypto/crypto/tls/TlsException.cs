using System;
using System.IO;

namespace Essensoft.AspNetCore.Security.Tls
{
    public class TlsException
        : IOException
    {
        public TlsException(string message, Exception cause)
            : base(message, cause)
        {
        }
    }
}
