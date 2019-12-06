using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAuthZhimaperInnerApplyModel Data Structure.
    /// </summary>
    public class AlipayUserAuthZhimaperInnerApplyModel : AlipayObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// IDENTITY_CARD :身份证
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 芝麻平台服务商模式下的二级商户标识，如果是直连商户调用该接口，不需要设置
        /// </summary>
        [JsonPropertyName("linked_merchant_id")]
        public string LinkedMerchantId { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
