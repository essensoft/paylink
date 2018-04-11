using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailShopitemBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailShopitemBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 店铺商品集合
        /// </summary>
        [JsonProperty("shopitemlist")]
        [XmlArray("shopitemlist")]
        [XmlArrayItem("ext_shop_item")]
        public List<ExtShopItem> Shopitemlist { get; set; }
    }
}
