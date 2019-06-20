using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankPaymentTradeFinancingOrderCreateResponse.
    /// </summary>
    public class MybankPaymentTradeFinancingOrderCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 处理结果状态
        /// </summary>
        [JsonProperty("biz_sts")]
        public string BizSts { get; set; }

        /// <summary>
        /// 请求受理单号，网商创建订单成功后返回的订单号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

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
