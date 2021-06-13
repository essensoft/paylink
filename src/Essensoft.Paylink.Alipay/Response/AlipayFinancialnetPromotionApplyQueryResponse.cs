using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFinancialnetPromotionApplyQueryResponse.
    /// </summary>
    public class AlipayFinancialnetPromotionApplyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 网商申请单号
        /// </summary>
        [JsonPropertyName("loan_order_no")]
        public string LoanOrderNo { get; set; }

        /// <summary>
        /// 签约订单编号
        /// </summary>
        [JsonPropertyName("sign_order_no")]
        public string SignOrderNo { get; set; }

        /// <summary>
        /// 蚂蚁traceId，便于查询日志内容
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
