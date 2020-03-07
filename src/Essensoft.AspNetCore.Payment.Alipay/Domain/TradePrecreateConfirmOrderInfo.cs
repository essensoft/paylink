using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TradePrecreateConfirmOrderInfo Data Structure.
    /// </summary>
    public class TradePrecreateConfirmOrderInfo : AlipayObject
    {
        /// <summary>
        /// 对交易或商品的描述
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// 支付超时的绝对时间
        /// </summary>
        [JsonPropertyName("pay_expire_time")]
        public string PayExpireTime { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }
    }
}
