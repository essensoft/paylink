using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailShopitemUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailShopitemUploadModel : AlipayObject
    {
        /// <summary>
        /// 上传的商品集合
        /// </summary>
        [JsonProperty("shop_items")]
        [XmlArray("shop_items")]
        [XmlArrayItem("request_ext_shop_item")]
        public List<RequestExtShopItem> ShopItems { get; set; }
    }
}
