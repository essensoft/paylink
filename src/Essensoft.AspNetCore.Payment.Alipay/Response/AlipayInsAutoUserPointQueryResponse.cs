using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoUserPointQueryResponse.
    /// </summary>
    public class AlipayInsAutoUserPointQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户当前积分是否可兑换
        /// </summary>
        [JsonPropertyName("can_exchange")]
        public bool CanExchange { get; set; }

        /// <summary>
        /// 用户可用于兑换的积分值  攒油活动则表示用户可提取油量，单位为ml，例如可提取500ml
        /// </summary>
        [JsonPropertyName("can_exchange_amount")]
        public long CanExchangeAmount { get; set; }

        /// <summary>
        /// 用户剩余积分额度，可继续积攒的值  攒油活动则表示用户油桶剩余大小，单位为ml
        /// </summary>
        [JsonPropertyName("can_save_amount")]
        public long CanSaveAmount { get; set; }

        /// <summary>
        /// 用户有效积分。  攒油活动则表示可以使用的用户有效油量，单位为ml
        /// </summary>
        [JsonPropertyName("can_use_amount")]
        public long CanUseAmount { get; set; }

        /// <summary>
        /// 是否推荐用户兑换
        /// </summary>
        [JsonPropertyName("recommend_exchange")]
        public bool RecommendExchange { get; set; }

        /// <summary>
        /// 用户积分总额度  攒油活动则表示用户油桶总大小，单位为ml，例如3000ml
        /// </summary>
        [JsonPropertyName("total_limit")]
        public long TotalLimit { get; set; }

        /// <summary>
        /// 用户总共积攒量。  攒油活动则表示积攒油量，单位为ml，例如2000ml
        /// </summary>
        [JsonPropertyName("total_save_amount")]
        public long TotalSaveAmount { get; set; }
    }
}
