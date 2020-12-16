using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceDataCampaignSendResponse.
    /// </summary>
    public class AlipayCommerceDataCampaignSendResponse : AlipayResponse
    {
        /// <summary>
        /// 用户订阅消息状态，其中true：已订阅；false：未订阅；unknown：未知状态
        /// </summary>
        [JsonPropertyName("sub_status")]
        public string SubStatus { get; set; }
    }
}
