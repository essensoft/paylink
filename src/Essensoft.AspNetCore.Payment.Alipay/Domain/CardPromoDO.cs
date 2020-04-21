using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CardPromoDO Data Structure.
    /// </summary>
    public class CardPromoDO : AlipayObject
    {
        /// <summary>
        /// 卡片Id
        /// </summary>
        [JsonPropertyName("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 卡片星级
        /// </summary>
        [JsonPropertyName("card_level")]
        public long CardLevel { get; set; }

        /// <summary>
        /// 是否限时权益
        /// </summary>
        [JsonPropertyName("limit")]
        public bool Limit { get; set; }

        /// <summary>
        /// 权益图标
        /// </summary>
        [JsonPropertyName("promo_icon")]
        public string PromoIcon { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [JsonPropertyName("promo_title")]
        public string PromoTitle { get; set; }

        /// <summary>
        /// 用户是否领取了该权益
        /// </summary>
        [JsonPropertyName("received")]
        public bool Received { get; set; }

        /// <summary>
        /// 目标打卡次数，打卡target_mark_count天可以获取该权益
        /// </summary>
        [JsonPropertyName("target_mark_count")]
        public long TargetMarkCount { get; set; }
    }
}
