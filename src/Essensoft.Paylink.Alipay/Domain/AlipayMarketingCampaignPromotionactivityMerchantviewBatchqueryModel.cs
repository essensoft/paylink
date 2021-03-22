using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionactivityMerchantviewBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignPromotionactivityMerchantviewBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 查询过滤条件, 单品券goods_id.  由于是列表, 单次限制最多5
        /// </summary>
        [JsonPropertyName("goods_ids")]
        public List<string> GoodsIds { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 是否只查询当前ISV代报名的活动
        /// </summary>
        [JsonPropertyName("only_current_isv")]
        public bool OnlyCurrentIsv { get; set; }

        /// <summary>
        /// 分页器
        /// </summary>
        [JsonPropertyName("paginator")]
        public Paginator Paginator { get; set; }
    }
}
