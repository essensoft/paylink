using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataMallShopitemsQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataMallShopitemsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 店铺信息
        /// </summary>
        [JsonPropertyName("shop_list")]
        public List<TBMiniShopBo> ShopList { get; set; }
    }
}
