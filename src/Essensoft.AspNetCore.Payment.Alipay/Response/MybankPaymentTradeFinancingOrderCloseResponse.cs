using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankPaymentTradeFinancingOrderCloseResponse.
    /// </summary>
    public class MybankPaymentTradeFinancingOrderCloseResponse : AlipayResponse
    {
        /// <summary>
        /// 外部业务单号
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 处理结果状态
        /// </summary>
        [JsonProperty("biz_sts")]
        public string BizSts { get; set; }

        /// <summary>
        /// 网商订单编号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 请求受理时间
        /// </summary>
        [JsonProperty("request_accept_time")]
        public string RequestAcceptTime { get; set; }
    }
}
