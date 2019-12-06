using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EndowmentOrder Data Structure.
    /// </summary>
    public class EndowmentOrder : AlipayObject
    {
        /// <summary>
        /// apply_amount：申购金额，以分为单位
        /// </summary>
        [JsonPropertyName("apply_amount")]
        public string ApplyAmount { get; set; }

        /// <summary>
        /// 订单id，订单的唯一标识，可以用来做幂等
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// pay_time：支付时间，格式：YYYYMMDDHHMISS
        /// </summary>
        [JsonPropertyName("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// ta_requestId:TA的唯一业务流水号
        /// </summary>
        [JsonPropertyName("ta_request_id")]
        public string TaRequestId { get; set; }
    }
}
