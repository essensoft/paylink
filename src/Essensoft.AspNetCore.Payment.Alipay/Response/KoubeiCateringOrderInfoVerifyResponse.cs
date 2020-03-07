using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringOrderInfoVerifyResponse.
    /// </summary>
    public class KoubeiCateringOrderInfoVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 核销是否幂等，true-幂等，false-没幂等
        /// </summary>
        [JsonPropertyName("idempotent")]
        public bool Idempotent { get; set; }

        /// <summary>
        /// 餐饮订单号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 是否需要重试，true-需要，false-不需要
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
