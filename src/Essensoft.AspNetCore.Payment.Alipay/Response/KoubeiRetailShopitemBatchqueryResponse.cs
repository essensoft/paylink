using System.Collections.Generic;
using System.Text.Json.Serialization;
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
        [JsonPropertyName("shopitemlist")]
        public List<ExtShopItem> Shopitemlist { get; set; }
    }
}
