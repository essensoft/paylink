using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInstserviceDeductresultQueryResponse.
    /// </summary>
    public class AlipayEbppInstserviceDeductresultQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝流水号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("order_result_code")]
        public string OrderResultCode { get; set; }

        /// <summary>
        /// 返回的结果码描述
        /// </summary>
        [JsonPropertyName("order_result_msg")]
        public string OrderResultMsg { get; set; }

        /// <summary>
        /// 上送流水号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 0:未知状态 1:支付成功 2:支付失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
