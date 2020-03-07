using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCommoneventApplyModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignCommoneventApplyModel : AlipayObject
    {
        /// <summary>
        /// 与event关联的数据
        /// </summary>
        [JsonPropertyName("content_json")]
        public string ContentJson { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [JsonPropertyName("event")]
        public string Event { get; set; }
    }
}
