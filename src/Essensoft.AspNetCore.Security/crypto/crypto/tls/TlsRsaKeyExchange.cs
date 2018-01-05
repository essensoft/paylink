using System;
using System.Collections;
using System.IO;

using Essensoft.AspNetCore.Security.Asn1;
using Essensoft.AspNetCore.Security.Asn1.X509;
using Essensoft.AspNetCore.Security.Crypto.Encodings;
using Essensoft.AspNetCore.Security.Crypto.Engines;
using Essensoft.AspNetCore.Security.Crypto.Parameters;
using Essensoft.AspNetCore.Security.Security;
using Essensoft.AspNetCore.Security.Utilities.IO;

namespace Essensoft.AspNetCore.Security.Crypto.Tls
{
    /// <summary>(D)TLS and SSLv3 RSA key exchange.</summary>
    public class TlsRsaKeyExchange
        :   AbstractTlsKeyExchange
    {
        protected AsymmetricKeyParameter mServerPublicKey = null;

        protected RsaKeyParameters mRsaServerPublicKey = null;

        protected TlsEncryptionCredentials mServerCredentials = null;

        protected byte[] mPremasterSecret;

        public TlsRsaKeyExchange(IList supportedSignatureAlgorithms)
            :   base(KeyExchangeAlgorithm.RSA, supportedSignatureAlgorithms)
        {
        }

        public override void SkipServerCredentials()
        {
            throw new TlsFatalAlert(AlertDescription.unexpected_message);
        }

        public override void ProcessServerCredentials(TlsCredentials serverCredentials)
        {
            if (!(serverCredentials is TlsEncryptionCredentials))
                throw new TlsFatalAlert(AlertDescription.internal_error);

            ProcessServerCertificate(serverCredentials.Certificate);

            this.mServerCredentials = (TlsEncryptionCredentials)serverCredentials;
        }

        public override void ProcessServerCertificate(Certificate serverCertificate)
        {
            if (serverCertificate.IsEmpty)
                throw new TlsFatalAlert(AlertDescription.bad_certificate);

            X509CertificateStructure x509Cert = serverCertificate.GetCertificateAt(0);

            SubjectPublicKeyInfo keyInfo = x509Cert.SubjectPublicKeyInfo;
            try
            {
                this.mServerPublicKey = PublicKeyFactory.CreateKey(keyInfo);
            }
            catch (Exception e)
            {
                throw new TlsFatalAlert(AlertDescription.unsupported_certificate, e);
            }

            // Sanity check the PublicKeyFactory
            if (this.mServerPublicKey.IsPrivate)
                throw new TlsFatalAlert(AlertDescription.internal_error);

            this.mRsaServerPublicKey = ValidateRsaPublicKey((RsaKeyParameters)this.mServerPublicKey);

            TlsUtilities.ValidateKeyUsage(x509Cert, KeyUsage.KeyEncipherment);

            base.ProcessServerCertificate(serverCertificate);
        }

        public override void ValidateCertificateRequest(CertificateRequest certificateRequest)
        {
            byte[] types = certificateRequest.CertificateTypes;
            for (int i = 0; i < types.Length; ++i)
            {
                switch (types[i])
                {
                case ClientCertificateType.rsa_sign:
                case ClientCertificateType.dss_sign:
                case ClientCertificateType.ecdsa_sign:
                    break;
                default:
                    throw new TlsFatalAlert(AlertDescription.illegal_parameter);
                }
            }
        }

        public override void ProcessClientCredentials(TlsCredentials clientCredentials)
        {
            if (!(clientCredentials is TlsSignerCredentials))
                throw new TlsFatalAlert(AlertDescription.internal_error);
        }

        public override void GenerateClientKeyExchange(Stream output)
        {
            this.mPremasterSecret = TlsRsaUtilities.GenerateEncryptedPreMasterSecret(mContext, mRsaServerPublicKey, output);
        }

        public override void ProcessClientKeyExchange(Stream input)
        {
            byte[] encryptedPreMasterSecret;
            if (TlsUtilities.IsSsl(mContext))
            {
                // TODO Do any SSLv3 clients actually include the length?
                encryptedPreMasterSecret = Streams.ReadAll(input);
            }
            else
            {
                encryptedPreMasterSecret = TlsUtilities.ReadOpaque16(input);
            }

            this.mPremasterSecret = mServerCredentials.DecryptPreMasterSecret(encryptedPreMasterSecret);
        }

        public override byte[] GeneratePremasterSecret()
        {
            if (this.mPremasterSecret == null)
                throw new TlsFatalAlert(AlertDescription.internal_error);

            byte[] tmp = this.mPremasterSecret;
            this.mPremasterSecret = null;
            return tmp;
        }

        protected virtual RsaKeyParameters ValidateRsaPublicKey(RsaKeyParameters key)
        {
            // TODO What is the minimum bit length required?
            // key.Modulus.BitLength;

            if (!key.Exponent.IsProbablePrime(2))
                throw new TlsFatalAlert(AlertDescription.illegal_parameter);

            return key;
        }
    }
}
