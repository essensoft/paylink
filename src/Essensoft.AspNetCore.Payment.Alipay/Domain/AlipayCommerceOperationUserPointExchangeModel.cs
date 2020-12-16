using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceOperationUserPointExchangeModel Data Structure.
    /// </summary>
    public class AlipayCommerceOperationUserPointExchangeModel : AlipayObject
    {
        /// <summary>
        /// 积分核销ID，验证point与benefitId的一致性，才能使用对应的积分
        /// </summary>
        [JsonPropertyName("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 业务发生时间，格式yyyyMMddHHmmssSSS
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 将要扣减的用户积分
        /// </summary>
        [JsonPropertyName("point")]
        public long Point { get; set; }

        /// <summary>
        /// 每次请求必须有唯一号，如果唯一号相等，会进行幂等返回
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 场景代码，由行业运营平台分配，提供枚举值。 user_id + scene_code 确定扣减积分的场景。
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 请求来源方，由行业运营分配。 例如：linkedmall
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
