using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeIndustryOrderQueryResponse.
    /// </summary>
    public class ZhimaCreditPeIndustryOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 入参传入的外部订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 订单状态,具体业务对应的订单状态值请联系业务确认
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [JsonPropertyName("zm_order_id")]
        public string ZmOrderId { get; set; }
    }
}
