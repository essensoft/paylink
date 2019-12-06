using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMarketShopCategoryQueryResponse.
    /// </summary>
    public class AlipayOfflineMarketShopCategoryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 门店类目配置信息，包括能够开店的叶子节点类目信息，以及类目约束配置信息。
        /// </summary>
        [JsonPropertyName("shop_category_config_infos")]
        public List<ShopCategoryConfigInfo> ShopCategoryConfigInfos { get; set; }
    }
}
