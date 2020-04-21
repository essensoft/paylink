using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataIsvShopQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataIsvShopQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 门店摘要信息列表
        /// </summary>
        [JsonPropertyName("shop_summary_infos")]
        public List<ShopSummaryInfo> ShopSummaryInfos { get; set; }
    }
}
