using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailShopitemUploadModel Data Structure.
    /// </summary>
    public class KoubeiRetailShopitemUploadModel : AlipayObject
    {
        /// <summary>
        /// 上传的商品集合
        /// </summary>
        [JsonProperty("shop_items")]
        public List<RequestExtShopItem> ShopItems { get; set; }
    }
}
