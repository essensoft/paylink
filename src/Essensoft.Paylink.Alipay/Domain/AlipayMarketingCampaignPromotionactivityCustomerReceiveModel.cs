using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionactivityCustomerReceiveModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignPromotionactivityCustomerReceiveModel : AlipayObject
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 风控字段apdid
        /// </summary>
        [JsonPropertyName("apdid")]
        public string Apdid { get; set; }

        /// <summary>
        /// 手机端客户端的ip
        /// </summary>
        [JsonPropertyName("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// 商户的pid 例如2088301847277786
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 外部请求号，用来保证幂等性， 需要权益唯一。 建议用UUID。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
