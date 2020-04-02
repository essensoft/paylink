using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserApplepayOtpresolutionmethodsQueryModel Data Structure.
    /// </summary>
    public class AlipayUserApplepayOtpresolutionmethodsQueryModel : AlipayObject
    {
        /// <summary>
        /// 卡id(由固定前缀+32位数字构成)
        /// </summary>
        [JsonPropertyName("provisioning_bundle_identifier")]
        public string ProvisioningBundleIdentifier { get; set; }
    }
}
