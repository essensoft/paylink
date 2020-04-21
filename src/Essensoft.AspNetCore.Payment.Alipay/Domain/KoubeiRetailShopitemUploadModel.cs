using System.Collections.Generic;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("shop_items")]
        public List<RequestExtShopItem> ShopItems { get; set; }
    }
}
