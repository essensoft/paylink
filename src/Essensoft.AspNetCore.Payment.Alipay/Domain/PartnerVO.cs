using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PartnerVO Data Structure.
    /// </summary>
    public class PartnerVO : AlipayObject
    {
        /// <summary>
        /// 生效状态，EFFECTIVE：生效，INVALID：失效。
        /// </summary>
        [JsonPropertyName("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonPropertyName("partner_name")]
        public string PartnerName { get; set; }

        /// <summary>
        /// 商户简码
        /// </summary>
        [JsonPropertyName("short_code")]
        public string ShortCode { get; set; }
    }
}
