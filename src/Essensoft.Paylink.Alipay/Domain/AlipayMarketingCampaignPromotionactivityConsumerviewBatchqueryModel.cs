using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionactivityConsumerviewBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignPromotionactivityConsumerviewBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 单品券场景下对应的goods_id,单次最多限制5个
        /// </summary>
        [JsonPropertyName("goods_ids")]
        public List<string> GoodsIds { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 是否只查询当前ISV报名的活动
        /// </summary>
        [JsonPropertyName("only_current_isv")]
        public bool OnlyCurrentIsv { get; set; }
    }
}
