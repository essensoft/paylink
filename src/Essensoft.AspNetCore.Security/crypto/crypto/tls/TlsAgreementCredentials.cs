using System;
using System.IO;

namespace Essensoft.AspNetCore.Security.Crypto.Tls
{
    public interface TlsAgreementCredentials
        :   TlsCredentials
    {
        /// <exception cref="IOException"></exception>
        byte[] GenerateAgreement(AsymmetricKeyParameter peerPublicKey);
    }
}
