using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceOperationUserPointQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceOperationUserPointQueryModel : AlipayObject
    {
        /// <summary>
        /// 场景代码，由行业运营平台分配，提供枚举值。 user_id + scene_code 确定返回内容。 bigTrip-出行
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 来源渠道，行业运营平台分配，例如：linkedmall
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
