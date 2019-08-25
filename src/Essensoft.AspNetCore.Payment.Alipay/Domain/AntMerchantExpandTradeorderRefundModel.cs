using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandTradeorderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandTradeorderRefundModel : AlipayObject
    {
        /// <summary>
        /// 订单ID；订单唯一标识
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 退款理由
        /// </summary>
        [JsonProperty("refund_reason")]
        public string RefundReason { get; set; }
    }
}
