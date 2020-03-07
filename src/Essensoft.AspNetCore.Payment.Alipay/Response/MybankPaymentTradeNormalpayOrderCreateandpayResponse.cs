using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOrderCreateandpayResponse.
    /// </summary>
    public class MybankPaymentTradeNormalpayOrderCreateandpayResponse : AlipayResponse
    {
        /// <summary>
        /// 网商创建的业务单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 请求受理时间，格式是yyyyMMddHHmmss
        /// </summary>
        [JsonPropertyName("request_accept_time")]
        public string RequestAcceptTime { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 外部平台是否可重试，失败时有值
        /// </summary>
        [JsonPropertyName("retry")]
        public string Retry { get; set; }
    }
}
