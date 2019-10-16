using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SubShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubShopInfo : AlipayObject
    {
        /// <summary>
        /// 门店信息集合
        /// </summary>
        [JsonProperty("shop_list")]
        public List<Shop> ShopList { get; set; }
    }
}
