using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFinancialnetPromotionApplyCreateResponse.
    /// </summary>
    public class AlipayFinancialnetPromotionApplyCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 进件订单号
        /// </summary>
        [JsonPropertyName("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 蚂蚁traceId，便于查询日志内容
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
