using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataIsvShopQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataIsvShopQueryModel : AlipayObject
    {
        /// <summary>
        /// 门店ID列表（单次最多查询100个门店）
        /// </summary>
        [JsonPropertyName("shop_ids")]
        public List<string> ShopIds { get; set; }
    }
}
