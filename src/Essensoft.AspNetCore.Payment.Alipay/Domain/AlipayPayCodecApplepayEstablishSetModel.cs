using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPayCodecApplepayEstablishSetModel Data Structure.
    /// </summary>
    public class AlipayPayCodecApplepayEstablishSetModel : AlipayObject
    {
        /// <summary>
        /// 数字签名。 The Base 64 encoded signature generated on Apple server. PKCS#7 detached ECC signature covering the SHA 256 hash of the concatenation of the UTF-8 value of provisioningBundleIdentifier and certificatesRequested and Base 64 decoded values of barcodeEncryptionCertificate , deviceSignatureCertificate .
        /// </summary>
        [JsonPropertyName("apple_signature")]
        public string AppleSignature { get; set; }

        /// <summary>
        /// JSON格式，base64的证书链List。只有leaf证书结构，能被imediately和root证书验过。第0个证书用于二维码加密使用。 Base 64 encoded X.509 encryption certificate chain containing the intermediate and leaf certificates. Encryption shall be performed using the first certificate in the list.
        /// </summary>
        [JsonPropertyName("barcode_encryption_cert_chain")]
        public List<string> BarcodeEncryptionCertChain { get; set; }

        /// <summary>
        /// JSON格式，base64的证书链List。只有leaf证书结构，能被imediately和root证书验过。第0个证书用于二维码上报加签使用。 Base 64 encoded X.509 signature certificate chain containing the intermediate and leaf certificates. The device will sign a payload each time it displays a QR code on the screen using the private key of this key pair. The public key of the first certificate should be used to verify that signature.
        /// </summary>
        [JsonPropertyName("device_signature_cert_chain")]
        public List<string> DeviceSignatureCertChain { get; set; }

        /// <summary>
        /// 风控信息。 Fraud data provided by Apple as outlined in separate Fraud SIA document, if applicable
        /// </summary>
        [JsonPropertyName("fraud_data")]
        public EstablishFraudData FraudData { get; set; }

        /// <summary>
        /// SAM pass的bundleId，唯一标识一张卡片。 The identifier for which the feature is being enabled.
        /// </summary>
        [JsonPropertyName("provisioning_bundle_identifier")]
        public string ProvisioningBundleIdentifier { get; set; }
    }
}
