using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailExtitemShopextitemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailExtitemShopextitemQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询页码，表示第几页，不传默认1
        /// </summary>
        [JsonProperty("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小，表示每页查询数量，不传默认10
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 口碑店铺id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
