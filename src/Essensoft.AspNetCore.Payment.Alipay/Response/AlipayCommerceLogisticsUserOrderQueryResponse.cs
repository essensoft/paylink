using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsUserOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsUserOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 格式 : json , 目前 json 的 key 有 biz_unique_no
        /// </summary>
        [JsonPropertyName("order_info")]
        public string OrderInfo { get; set; }
    }
}
