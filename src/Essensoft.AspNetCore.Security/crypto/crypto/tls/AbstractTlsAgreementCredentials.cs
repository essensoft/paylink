namespace Essensoft.AspNetCore.Security.Tls
{
    public abstract class AbstractTlsAgreementCredentials
        :   AbstractTlsCredentials, TlsAgreementCredentials
    {
        /// <exception cref="IOException"></exception>
        public abstract byte[] GenerateAgreement(AsymmetricKeyParameter peerPublicKey);
    }
}
