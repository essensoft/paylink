using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingVoucherStockCreateResponse.
    /// </summary>
    public class AlipayMarketingVoucherStockCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 本次重复导入数量
        /// </summary>
        [JsonPropertyName("duplicate_count")]
        public long DuplicateCount { get; set; }

        /// <summary>
        /// 本次导入失败数量
        /// </summary>
        [JsonPropertyName("fail_count")]
        public long FailCount { get; set; }

        /// <summary>
        /// 库存ID, 用于后续追加和查询库存
        /// </summary>
        [JsonPropertyName("stock_id")]
        public string StockId { get; set; }

        /// <summary>
        /// 本次导入成功数量
        /// </summary>
        [JsonPropertyName("success_count")]
        public long SuccessCount { get; set; }
    }
}
