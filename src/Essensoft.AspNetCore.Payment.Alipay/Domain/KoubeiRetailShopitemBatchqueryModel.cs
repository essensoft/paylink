using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailShopitemBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailShopitemBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 查询店铺商品查询入参
        /// </summary>
        [JsonProperty("shop_items")]
        public List<RequestExtShopItemQuery> ShopItems { get; set; }
    }
}
