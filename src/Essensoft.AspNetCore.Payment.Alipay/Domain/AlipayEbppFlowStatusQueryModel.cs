using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppFlowStatusQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppFlowStatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_msg")]
        public string ExtMsg { get; set; }

        /// <summary>
        /// 内部订单号
        /// </summary>
        [JsonPropertyName("merchant_order_id")]
        public string MerchantOrderId { get; set; }

        /// <summary>
        /// 手机号码，15158886666
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 外部交易号
        /// </summary>
        [JsonPropertyName("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
