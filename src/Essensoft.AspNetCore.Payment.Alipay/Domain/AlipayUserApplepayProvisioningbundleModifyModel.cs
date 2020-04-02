using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserApplepayProvisioningbundleModifyModel Data Structure.
    /// </summary>
    public class AlipayUserApplepayProvisioningbundleModifyModel : AlipayObject
    {
        /// <summary>
        /// 管理动作
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// otp的值
        /// </summary>
        [JsonPropertyName("otp_value")]
        public string OtpValue { get; set; }

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
