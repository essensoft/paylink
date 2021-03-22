using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CommonPrizeModelVo Data Structure.
    /// </summary>
    public class CommonPrizeModelVo : AlipayObject
    {
        /// <summary>
        /// 奖品描述图片url
        /// </summary>
        [JsonPropertyName("prize_desc_image_url")]
        public string PrizeDescImageUrl { get; set; }

        /// <summary>
        /// 奖品底部文案
        /// </summary>
        [JsonPropertyName("prize_down_desc_text")]
        public string PrizeDownDescText { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [JsonPropertyName("prize_name")]
        public string PrizeName { get; set; }
    }
}
