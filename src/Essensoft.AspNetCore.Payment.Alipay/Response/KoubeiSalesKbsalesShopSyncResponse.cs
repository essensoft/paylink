using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiSalesKbsalesShopSyncResponse.
    /// </summary>
    public class KoubeiSalesKbsalesShopSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 流水结果描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 口碑流水id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 处理结果
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
