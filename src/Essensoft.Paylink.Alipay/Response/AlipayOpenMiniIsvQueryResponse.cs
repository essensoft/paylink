using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniIsvQueryResponse.
    /// </summary>
    public class AlipayOpenMiniIsvQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序appId，商家确认后非空，若商家未确认或超时返回空
        /// </summary>
        [JsonPropertyName("min_app_id")]
        public string MinAppId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单号，开发者帐号+外部订单号维度来控制请求务幂等
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// PROCESS处理中，TIMEOUT超时，AGREED同意， REJECTED拒绝
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
