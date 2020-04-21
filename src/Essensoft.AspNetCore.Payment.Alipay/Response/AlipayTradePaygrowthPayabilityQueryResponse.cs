using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradePaygrowthPayabilityQueryResponse.
    /// </summary>
    public class AlipayTradePaygrowthPayabilityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否有支付能力，true表示有支付能力，false表示没有支付能力。
        /// </summary>
        [JsonPropertyName("enable_to_pay")]
        public bool EnableToPay { get; set; }

        /// <summary>
        /// 是否需要运营干预，true表示需要运营干预，提供文字链、图片+聚合页、数据等多种干预手段。
        /// </summary>
        [JsonPropertyName("need_recommend")]
        public bool NeedRecommend { get; set; }

        /// <summary>
        /// 支付能力推荐信息，若用户没有支付能力且该场景需要做运营推荐，则返回运营推荐信息，包括推荐类型、文案、图片及跳转地址等。
        /// </summary>
        [JsonPropertyName("recommend_info")]
        public RecommendInfo RecommendInfo { get; set; }
    }
}
