using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserApplepayOtpSendModel Data Structure.
    /// </summary>
    public class AlipayUserApplepayOtpSendModel : AlipayObject
    {
        /// <summary>
        /// 卡id(由固定前缀+32位数字构成)
        /// </summary>
        [JsonPropertyName("provisioning_bundle_identifier")]
        public string ProvisioningBundleIdentifier { get; set; }

        /// <summary>
        /// 校验方法标识
        /// </summary>
        [JsonPropertyName("resolution_method_identifier")]
        public string ResolutionMethodIdentifier { get; set; }
    }
}
