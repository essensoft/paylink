using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbVirtualShopInfo Data Structure.
    /// </summary>
    public class KbVirtualShopInfo : AlipayObject
    {
        /// <summary>
        /// 门店信息
        /// </summary>
        [JsonPropertyName("catetory_list")]
        public List<KbdishVirtualCategoryInfo> CatetoryList { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
