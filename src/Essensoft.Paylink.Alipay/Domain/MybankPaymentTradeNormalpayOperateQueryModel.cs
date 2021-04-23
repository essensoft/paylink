using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOperateQueryModel Data Structure.
    /// </summary>
    public class MybankPaymentTradeNormalpayOperateQueryModel : AlipayObject
    {
        /// <summary>
        /// 网商订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 请求流水号；外部平台在请求支付、退款、打款等操作时传入的流水号
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }
    }
}
