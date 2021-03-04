using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossOrderApplyResponse.
    /// </summary>
    public class AlipayBossOrderApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 订单信息
        /// </summary>
        [JsonPropertyName("order_info")]
        public string OrderInfo { get; set; }
    }
}
