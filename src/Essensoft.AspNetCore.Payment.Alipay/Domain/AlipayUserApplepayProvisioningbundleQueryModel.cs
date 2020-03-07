using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserApplepayProvisioningbundleQueryModel Data Structure.
    /// </summary>
    public class AlipayUserApplepayProvisioningbundleQueryModel : AlipayObject
    {
        /// <summary>
        /// 加密证书链
        /// </summary>
        [JsonPropertyName("encryption_cert_chain")]
        public List<string> EncryptionCertChain { get; set; }

        /// <summary>
        /// 加密版本号
        /// </summary>
        [JsonPropertyName("encryption_version")]
        public string EncryptionVersion { get; set; }

        /// <summary>
        /// 风控数据
        /// </summary>
        [JsonPropertyName("fraud_data")]
        public FraudData FraudData { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// 隐私数据加密证书链
        /// </summary>
        [JsonPropertyName("private_encryption_cert_chain")]
        public List<string> PrivateEncryptionCertChain { get; set; }

        /// <summary>
        /// 卡id(由固定前缀+32位数字构成)
        /// </summary>
        [JsonPropertyName("provisioning_bundle_identifier")]
        public string ProvisioningBundleIdentifier { get; set; }

        /// <summary>
        /// 卡的用户id(由固定前缀+支付宝用户id组成)
        /// </summary>
        [JsonPropertyName("reference_identifier")]
        public string ReferenceIdentifier { get; set; }

        /// <summary>
        /// 卡的x-pod
        /// </summary>
        [JsonPropertyName("x_pod")]
        public string XPod { get; set; }
    }
}
