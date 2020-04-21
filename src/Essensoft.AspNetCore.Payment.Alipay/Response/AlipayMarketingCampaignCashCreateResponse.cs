using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCashCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignCashCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 生成的现金红包活动号
        /// </summary>
        [JsonPropertyName("crowd_no")]
        public string CrowdNo { get; set; }

        /// <summary>
        /// 原始活动号,商户排查问题时提供的活动依据
        /// </summary>
        [JsonPropertyName("origin_crowd_no")]
        public string OriginCrowdNo { get; set; }

        /// <summary>
        /// 活动创建后的付款链接，返回的是urlencode编码后的字符串。需要先进行urldecode解码，然后在浏览器中进行访问，会先进行支付宝登录引导，然后商户进行付款，付款有效期24小时。
        /// </summary>
        [JsonPropertyName("pay_url")]
        public string PayUrl { get; set; }
    }
}
