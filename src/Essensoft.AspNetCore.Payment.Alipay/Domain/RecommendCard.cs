using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RecommendCard Data Structure.
    /// </summary>
    public class RecommendCard : AlipayObject
    {
        /// <summary>
        /// 卡名称
        /// </summary>
        [JsonPropertyName("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 卡的推荐理由，非必须项
        /// </summary>
        [JsonPropertyName("card_recommend_reason")]
        public string CardRecommendReason { get; set; }

        /// <summary>
        /// 卡类型，非必须项
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 卡类目1，非必须项
        /// </summary>
        [JsonPropertyName("cate_1")]
        public string Cate1 { get; set; }

        /// <summary>
        /// 卡类目2，非必须项
        /// </summary>
        [JsonPropertyName("cate_2")]
        public string Cate2 { get; set; }

        /// <summary>
        /// 卡类目3，非必须项
        /// </summary>
        [JsonPropertyName("cate_3")]
        public string Cate3 { get; set; }
    }
}
