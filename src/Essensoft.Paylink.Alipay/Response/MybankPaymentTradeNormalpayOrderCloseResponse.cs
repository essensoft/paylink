using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOrderCloseResponse.
    /// </summary>
    public class MybankPaymentTradeNormalpayOrderCloseResponse : AlipayResponse
    {
        /// <summary>
        /// 网商订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 创建订单时的请求流水号
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 外部平台是否可重试，失败时有值，true=可重试，false=不可重试
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
