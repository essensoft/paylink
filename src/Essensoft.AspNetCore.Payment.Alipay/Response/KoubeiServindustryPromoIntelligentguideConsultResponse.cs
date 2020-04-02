using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryPromoIntelligentguideConsultResponse.
    /// </summary>
    public class KoubeiServindustryPromoIntelligentguideConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 预计消费最大金额
        /// </summary>
        [JsonPropertyName("consume_max")]
        public long ConsumeMax { get; set; }

        /// <summary>
        /// 预计最少消费金额
        /// </summary>
        [JsonPropertyName("consume_min")]
        public long ConsumeMin { get; set; }

        /// <summary>
        /// 推荐卡项信息
        /// </summary>
        [JsonPropertyName("recommend_card")]
        public RecommendCard RecommendCard { get; set; }

        /// <summary>
        /// 推荐具体服务项目
        /// </summary>
        [JsonPropertyName("recommend_service_info")]
        public List<RecommendServiceInfo> RecommendServiceInfo { get; set; }

        /// <summary>
        /// 用户兴趣标签，多个用'|' 分隔符分隔
        /// </summary>
        [JsonPropertyName("user_tags")]
        public string UserTags { get; set; }
    }
}
