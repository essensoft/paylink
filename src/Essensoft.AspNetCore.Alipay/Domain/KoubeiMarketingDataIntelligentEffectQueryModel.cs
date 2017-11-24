using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataIntelligentEffectQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataIntelligentEffectQueryModel : AlipayObject
    {
        /// <summary>
        /// 操作人上下文信息
        /// </summary>
        [JsonProperty("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 智能营销活动的详情，用于咨询的元数据
        /// </summary>
        [JsonProperty("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
