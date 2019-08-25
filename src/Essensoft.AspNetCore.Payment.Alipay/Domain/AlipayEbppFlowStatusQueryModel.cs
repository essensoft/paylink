using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppFlowStatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppFlowStatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("ext_msg")]
        public string ExtMsg { get; set; }

        /// <summary>
        /// 内部订单号
        /// </summary>
        [JsonProperty("merchant_order_id")]
        public string MerchantOrderId { get; set; }

        /// <summary>
        /// 手机号码，15158886666
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 外部交易号
        /// </summary>
        [JsonProperty("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
