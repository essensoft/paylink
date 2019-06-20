using Newtonsoft.Json;

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
        [JsonProperty("biz_sts")]
        public string BizSts { get; set; }

        /// <summary>
        /// 请求受理单号
        /// </summary>
        [JsonProperty("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 请求受理时间
        /// </summary>
        [JsonProperty("request_accept_time")]
        public string RequestAcceptTime { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [JsonProperty("request_no")]
        public string RequestNo { get; set; }
    }
}
