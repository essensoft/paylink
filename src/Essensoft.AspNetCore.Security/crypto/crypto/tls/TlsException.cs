using System;
using System.IO;

namespace Essensoft.AspNetCore.Security.Crypto.Tls
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
