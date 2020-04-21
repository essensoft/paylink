using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserApplepayPbstatusQueryModel Data Structure.
    /// </summary>
    public class AlipayUserApplepayPbstatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备接受语言
        /// </summary>
        [JsonPropertyName("device_accept_language")]
        public string DeviceAcceptLanguage { get; set; }

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
    }
}
