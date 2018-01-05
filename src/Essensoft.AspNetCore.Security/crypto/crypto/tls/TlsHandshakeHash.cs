using System;

namespace Essensoft.AspNetCore.Security.Crypto.Tls
{
    public interface TlsHandshakeHash
        :   IDigest
    {
        void Init(TlsContext context);

        TlsHandshakeHash NotifyPrfDetermined();

        void TrackHashAlgorithm(byte hashAlgorithm);

        void SealHashAlgorithms();

        TlsHandshakeHash StopTracking();

        IDigest ForkPrfHash();

        byte[] GetFinalHash(byte hashAlgorithm);
    }
}
