using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankPaymentTradeFinancingOrderRefundResponse.
    /// </summary>
    public class MybankPaymentTradeFinancingOrderRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 处理结果状态
        /// </summary>
        [JsonPropertyName("biz_sts")]
        public string BizSts { get; set; }

        /// <summary>
        /// 请求受理单号
        /// </summary>
        [JsonPropertyName("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 请求受理时间
        /// </summary>
        [JsonPropertyName("request_accept_time")]
        public string RequestAcceptTime { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }
    }
}
