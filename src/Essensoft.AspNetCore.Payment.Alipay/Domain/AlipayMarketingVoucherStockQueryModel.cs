using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherStockQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingVoucherStockQueryModel : AlipayObject
    {
        /// <summary>
        /// 库存ID, 库存创建接口返回
        /// </summary>
        [JsonProperty("stock_id")]
        public string StockId { get; set; }
    }
}
