using System.Text.Json.Serialization;

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
        [JsonPropertyName("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 外部业务id，请保持足够的复杂，方便定位数据来源
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 活动拥有者信息
        /// </summary>
        [JsonPropertyName("owner_info")]
        public PromoOperatorInfo OwnerInfo { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [JsonPropertyName("page_info")]
        public PromoPageInfo PageInfo { get; set; }
    }
}
