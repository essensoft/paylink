using System;
using System.IO;

namespace Essensoft.AspNetCore.Security.Crypto.Tls
{
    public abstract class AbstractTlsEncryptionCredentials
        : AbstractTlsCredentials, TlsEncryptionCredentials
    {
        /// <exception cref="IOException"></exception>
        public abstract byte[] DecryptPreMasterSecret(byte[] encryptedPreMasterSecret);
    }
}
