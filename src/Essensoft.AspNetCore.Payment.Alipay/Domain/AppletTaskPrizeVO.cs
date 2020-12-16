using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AppletTaskPrizeVO Data Structure.
    /// </summary>
    public class AppletTaskPrizeVO : AlipayObject
    {
        /// <summary>
        /// 奖品余额。
        /// </summary>
        [JsonPropertyName("budget_amount")]
        public long BudgetAmount { get; set; }

        /// <summary>
        /// 奖品系数。
        /// </summary>
        [JsonPropertyName("modulus")]
        public long Modulus { get; set; }

        /// <summary>
        /// 奖品id。
        /// </summary>
        [JsonPropertyName("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称。
        /// </summary>
        [JsonPropertyName("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖品类型
        /// </summary>
        [JsonPropertyName("prize_type")]
        public string PrizeType { get; set; }
    }
}
