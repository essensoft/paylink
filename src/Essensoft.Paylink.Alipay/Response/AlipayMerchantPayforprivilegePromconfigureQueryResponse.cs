using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromconfigureQueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegePromconfigureQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 可核销的店铺id列表
        /// </summary>
        [JsonPropertyName("enabled_shop_list")]
        public List<string> EnabledShopList { get; set; }

        /// <summary>
        /// 剔除的单品id 列表
        /// </summary>
        [JsonPropertyName("exclude_item_ids")]
        public List<string> ExcludeItemIds { get; set; }

        /// <summary>
        /// 支持核销的商品id
        /// </summary>
        [JsonPropertyName("support_item_ids")]
        public List<string> SupportItemIds { get; set; }
    }
}
