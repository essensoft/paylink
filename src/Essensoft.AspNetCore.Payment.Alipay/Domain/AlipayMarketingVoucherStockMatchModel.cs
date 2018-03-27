using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherStockMatchModel Data Structure.
    /// </summary>
    public class AlipayMarketingVoucherStockMatchModel : AlipayObject
    {
        /// <summary>
        /// 待核查券码列表，商户体系内可兑换使用的券码
        /// </summary>
        [JsonProperty("entity_list")]
        public List<string> EntityList { get; set; }

        /// <summary>
        /// 库存ID,创建库存时返回
        /// </summary>
        [JsonProperty("stock_id")]
        public string StockId { get; set; }
    }
}
