using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenApiPassStatus Data Structure.
    /// </summary>
    public class OpenApiPassStatus : AlipayObject
    {
        /// <summary>
        /// 卡id(由固定前缀+32位数字构成)
        /// </summary>
        [JsonPropertyName("provisioning_bundle_identifier")]
        public string ProvisioningBundleIdentifier { get; set; }

        /// <summary>
        /// 卡状态
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}
