using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTrainActivitystatusModifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateTrainActivitystatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 活动 id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 领取状态
        /// </summary>
        [JsonPropertyName("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 课程id
        /// </summary>
        [JsonPropertyName("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 加密后的手机号
        /// </summary>
        [JsonPropertyName("encode_mobile")]
        public string EncodeMobile { get; set; }

        /// <summary>
        /// 错误描述 (SPECIAL_MOBILE_NUMBER)
        /// </summary>
        [JsonPropertyName("fail_desc")]
        public string FailDesc { get; set; }
    }
}
