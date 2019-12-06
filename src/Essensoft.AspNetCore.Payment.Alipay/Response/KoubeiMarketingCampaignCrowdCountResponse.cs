using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdCountResponse.
    /// </summary>
    public class KoubeiMarketingCampaignCrowdCountResponse : AlipayResponse
    {
        /// <summary>
        /// 各个细分维度的值，label为标签code，value为该标签各个标签值对应的统计信息，本示例表示pam_gender这个标签的男有100人，女有1000人满足入参指定的圈人条件
        /// </summary>
        [JsonPropertyName("dimension_values")]
        public string DimensionValues { get; set; }

        /// <summary>
        /// 人群组的汇总统计值total是人数，sum是交易金额
        /// </summary>
        [JsonPropertyName("summary_values")]
        public string SummaryValues { get; set; }
    }
}
