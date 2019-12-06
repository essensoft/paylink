using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingVoucherStockQueryResponse.
    /// </summary>
    public class AlipayMarketingVoucherStockQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 剩余可用库存数量
        /// </summary>
        [JsonPropertyName("available_count")]
        public long AvailableCount { get; set; }

        /// <summary>
        /// 库存总量
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
