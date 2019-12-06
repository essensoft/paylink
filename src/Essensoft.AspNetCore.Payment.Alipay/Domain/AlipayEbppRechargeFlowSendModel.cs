using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppRechargeFlowSendModel Data Structure.
    /// </summary>
    public class AlipayEbppRechargeFlowSendModel : AlipayObject
    {
        /// <summary>
        /// 绑定手机号
        /// </summary>
        [JsonPropertyName("bind_mobile")]
        public string BindMobile { get; set; }

        /// <summary>
        /// 扩展信息，json字符串
        /// </summary>
        [JsonPropertyName("ext_msg")]
        public string ExtMsg { get; set; }

        /// <summary>
        /// 移动兑换流量产品码
        /// </summary>
        [JsonPropertyName("trade_code")]
        public string TradeCode { get; set; }

        /// <summary>
        /// 兑换流量的外部订单号
        /// </summary>
        [JsonPropertyName("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 兑换交易时间
        /// </summary>
        [JsonPropertyName("trade_time")]
        public string TradeTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
