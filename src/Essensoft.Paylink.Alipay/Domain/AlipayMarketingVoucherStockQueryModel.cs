using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherStockQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingVoucherStockQueryModel : AlipayObject
    {
        /// <summary>
        /// 库存ID, 库存创建接口返回
        /// </summary>
        [JsonPropertyName("stock_id")]
        public string StockId { get; set; }
    }
}
