using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsMarketingExperienceAccountQueryResponse.
    /// </summary>
    public class AlipayInsMarketingExperienceAccountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 剩余可提现收益
        /// </summary>
        [JsonPropertyName("remaining_profit")]
        public string RemainingProfit { get; set; }

        /// <summary>
        /// 体验金总额
        /// </summary>
        [JsonPropertyName("total_experience_amount")]
        public string TotalExperienceAmount { get; set; }
    }
}
