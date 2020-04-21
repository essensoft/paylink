using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiAdvertDeliveryDiscountGetResponse.
    /// </summary>
    public class KoubeiAdvertDeliveryDiscountGetResponse : AlipayResponse
    {
        /// <summary>
        /// 广告推荐的商品信息列表，个数小于等于请求中参数“size”个数
        /// </summary>
        [JsonPropertyName("discounts")]
        public DiscountInfo Discounts { get; set; }

        /// <summary>
        /// 本次推荐的唯一标识， 此字段需回传
        /// </summary>
        [JsonPropertyName("recommend_id")]
        public string RecommendId { get; set; }
    }
}
