using System;
using System.IO;

namespace Essensoft.AspNetCore.Security.Crypto.Tls
{
    public interface TlsEncryptionCredentials
        :   TlsCredentials
    {
        /// <exception cref="IOException"></exception>
        byte[] DecryptPreMasterSecret(byte[] encryptedPreMasterSecret);
    }
}
