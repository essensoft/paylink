using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContentPrizeInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class ContentPrizeInfoModel : AlipayObject
    {
        /// <summary>
        /// 奖品id
        /// </summary>
        [JsonProperty("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品logo
        /// </summary>
        [JsonProperty("prize_logo")]
        public string PrizeLogo { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [JsonProperty("prize_name")]
        public string PrizeName { get; set; }
    }
}
