using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContentPrizeInfoModel Data Structure.
    /// </summary>
    public class ContentPrizeInfoModel : AlipayObject
    {
        /// <summary>
        /// 奖品id
        /// </summary>
        [JsonPropertyName("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品logo
        /// </summary>
        [JsonPropertyName("prize_logo")]
        public string PrizeLogo { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [JsonPropertyName("prize_name")]
        public string PrizeName { get; set; }
    }
}
