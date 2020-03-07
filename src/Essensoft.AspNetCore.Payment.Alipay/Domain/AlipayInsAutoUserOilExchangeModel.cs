using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoUserOilExchangeModel Data Structure.
    /// </summary>
    public class AlipayInsAutoUserOilExchangeModel : AlipayObject
    {
        /// <summary>
        /// 验证point与benefitId的一致性，才能使用对应的积分
        /// </summary>
        [JsonPropertyName("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 将要扣减的油量（ml）
        /// </summary>
        [JsonPropertyName("oil")]
        public long Oil { get; set; }

        /// <summary>
        /// 请求业务单号，单号一致的两次请求将保证幂等
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        [JsonPropertyName("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 来源，车险分配
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
