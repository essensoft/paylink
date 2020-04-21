using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiAdvertDataPromotesummaryQueryResponse.
    /// </summary>
    public class KoubeiAdvertDataPromotesummaryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑平台推广数据
        /// </summary>
        [JsonPropertyName("kb_platform_promote_data")]
        public PromoteDataModel KbPlatformPromoteData { get; set; }

        /// <summary>
        /// 其他推广者推广数据
        /// </summary>
        [JsonPropertyName("others_promote_data")]
        public PromoteDataModel OthersPromoteData { get; set; }

        /// <summary>
        /// 入参时间段内总推广数据
        /// </summary>
        [JsonPropertyName("part_promote_data")]
        public PromoteDataModel PartPromoteData { get; set; }

        /// <summary>
        /// 自己推广数据
        /// </summary>
        [JsonPropertyName("self_promote_data")]
        public PromoteDataModel SelfPromoteData { get; set; }

        /// <summary>
        /// 总推广数据
        /// </summary>
        [JsonPropertyName("total_promote_data")]
        public PromoteDataModel TotalPromoteData { get; set; }
    }
}
