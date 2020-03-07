using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPayCodecApplepayCredentialsGetModel Data Structure.
    /// </summary>
    public class AlipayPayCodecApplepayCredentialsGetModel : AlipayObject
    {
        /// <summary>
        /// ECC算法、PKCS#7的签名。{Base 64 encoded signature from Apple authorizing the return of the credentials. PKCS#7 detached ECC signature covering the SHA 256 hash of the concatenation of the UTF-8 values of provisioningBundleIdentifier , lastUsedCredentialIdentifier , numberToFetch and hasZeroQRCodes .}
        /// </summary>
        [JsonPropertyName("apple_signature")]
        public string AppleSignature { get; set; }

        /// <summary>
        /// 加密证书hash值，用于证书验证。 The public key hash of the leaf certificate of the barcodeEncryptionCertChain to indicate the public key that should be used for the encryption of payment credentials.
        /// </summary>
        [JsonPropertyName("encryption_public_key_hash")]
        public string EncryptionPublicKeyHash { get; set; }

        /// <summary>
        /// 风控信息。 Fraud data provided by Apple as outlined in separate Fraud SIA document, if applicable
        /// </summary>
        [JsonPropertyName("fraud_data")]
        public CredentialsFraudData FraudData { get; set; }

        /// <summary>
        /// hasZeroQRCodes，本地已经没有付款码。{This parameter indicates if there are anymore QR codes left on the device or not. True means that there are no more QR codes left on the device.}
        /// </summary>
        [JsonPropertyName("has_zero_qr_codes")]
        public bool HasZeroQrCodes { get; set; }

        /// <summary>
        /// 上一个展示过的码id，-1个可做失效处理。{The identifier of the most recently consumed payment credential}
        /// </summary>
        [JsonPropertyName("last_used_credential_identifier")]
        public string LastUsedCredentialIdentifier { get; set; }

        /// <summary>
        /// 希望下发的码个数。{The desired number of payment credentials to be returned}
        /// </summary>
        [JsonPropertyName("number_to_fetch")]
        public long NumberToFetch { get; set; }

        /// <summary>
        /// 码类型。 {To enable QR code and barcode functionality}
        /// </summary>
        [JsonPropertyName("payment_credential_type")]
        public string PaymentCredentialType { get; set; }

        /// <summary>
        /// SAM pass的bundleId，唯一标识一张卡片。{The identifier on the device for which the payment credentials are destined}
        /// </summary>
        [JsonPropertyName("provisioning_bundle_identifier")]
        public string ProvisioningBundleIdentifier { get; set; }
    }
}
