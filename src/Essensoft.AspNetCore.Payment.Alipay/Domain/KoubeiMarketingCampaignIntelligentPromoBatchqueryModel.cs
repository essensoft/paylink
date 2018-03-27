using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 操作员上下文信息
        /// </summary>
        [JsonProperty("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 外部业务id，请保持足够的复杂，方便定位数据来源
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 活动拥有者信息
        /// </summary>
        [JsonProperty("owner_info")]
        public PromoOperatorInfo OwnerInfo { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [JsonProperty("page_info")]
        public PromoPageInfo PageInfo { get; set; }
    }
}
