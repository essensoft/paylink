using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BuyerPayDetail Data Structure.
    /// </summary>
    public class BuyerPayDetail : AlipayObject
    {
        /// <summary>
        /// 买家支付金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [JsonPropertyName("pay_channel")]
        public string PayChannel { get; set; }
    }
}
