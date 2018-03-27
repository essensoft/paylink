using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;

namespace Essensoft.AspNetCore.Payment.UnionPay.Utility
{
    public class UnionPayCertificate
    {
        public AsymmetricKeyParameter key;
        public X509Certificate cert;
        public string certId;
    }
}
