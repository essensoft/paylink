using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

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
        [JsonProperty("shop_list")]
        public List<TBMiniShopBo> ShopList { get; set; }
    }
}
