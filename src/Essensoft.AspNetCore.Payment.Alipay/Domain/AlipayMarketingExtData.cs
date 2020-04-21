using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingExtData Data Structure.
    /// </summary>
    public class AlipayMarketingExtData : AlipayObject
    {
        /// <summary>
        /// 复杂模型
        /// </summary>
        [JsonPropertyName("lbs_info")]
        public AlipayMarketingIbsInfo LbsInfo { get; set; }

        /// <summary>
        /// 外部uid
        /// </summary>
        [JsonPropertyName("out_user_id")]
        public string OutUserId { get; set; }
    }
}
