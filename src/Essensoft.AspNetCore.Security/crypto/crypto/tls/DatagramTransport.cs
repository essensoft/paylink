using System;
using System.IO;

namespace Essensoft.AspNetCore.Security.Crypto.Tls
{
    public interface DatagramTransport
    {
        /// <exception cref="IOException"/>
        int GetReceiveLimit();

        /// <exception cref="IOException"/>
        int GetSendLimit();

        /// <exception cref="IOException"/>
        int Receive(byte[] buf, int off, int len, int waitMillis);

        /// <exception cref="IOException"/>
        void Send(byte[] buf, int off, int len);

        /// <exception cref="IOException"/>
        void Close();
    }
}
