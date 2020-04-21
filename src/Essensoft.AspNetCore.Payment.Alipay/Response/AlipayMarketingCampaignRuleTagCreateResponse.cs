using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignRuleTagCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignRuleTagCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 自定义标签id（创建自定义规则时提供）
        /// </summary>
        [JsonPropertyName("customertag")]
        public string Customertag { get; set; }
    }
}
