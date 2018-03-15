using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingMallShoppromoinfoQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingMallShoppromoinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [JsonProperty("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 商圈下店铺id列表
        /// </summary>
        [JsonProperty("shop_ids")]
        public List<string> ShopIds { get; set; }
    }
}
