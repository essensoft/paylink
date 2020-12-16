using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BizOrderInfo Data Structure.
    /// </summary>
    public class BizOrderInfo : AlipayObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 订单扩展参数
        /// </summary>
        [JsonPropertyName("ext_params")]
        public BizExtInfo ExtParams { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }
    }
}
