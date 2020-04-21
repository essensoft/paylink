using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringOrderInfoCreateResponse.
    /// </summary>
    public class KoubeiCateringOrderInfoCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑的订单号（唯一主键），和pos本地订单号一一对应
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 是否需要重试，true-需要重试，false-不需要重试
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
