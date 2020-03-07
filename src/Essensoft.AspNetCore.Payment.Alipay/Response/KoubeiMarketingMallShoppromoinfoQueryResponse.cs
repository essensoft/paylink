using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingMallShoppromoinfoQueryResponse.
    /// </summary>
    public class KoubeiMarketingMallShoppromoinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 店铺营销信息详情
        /// </summary>
        [JsonPropertyName("shop_promo_infos")]
        public List<ShopPromoInfo> ShopPromoInfos { get; set; }
    }
}
