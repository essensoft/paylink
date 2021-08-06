using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromconfigureSetModel Data Structure.
    /// </summary>
    public class AlipayMerchantPayforprivilegePromconfigureSetModel : AlipayObject
    {
        /// <summary>
        /// 支持的可核销门店列表
        /// </summary>
        [JsonPropertyName("enabled_shop_list")]
        public List<string> EnabledShopList { get; set; }

        /// <summary>
        /// 需要剔除的单品id列表，不可同时与（support_item_ids）生效
        /// </summary>
        [JsonPropertyName("exclude_item_ids")]
        public List<string> ExcludeItemIds { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支持的核销单品id列表，不可同时与剔除的列表（exclude_item_ids）生效
        /// </summary>
        [JsonPropertyName("support_item_ids")]
        public List<string> SupportItemIds { get; set; }
    }
}
