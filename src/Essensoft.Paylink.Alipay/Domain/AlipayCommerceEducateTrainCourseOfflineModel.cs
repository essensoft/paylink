using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTrainCourseOfflineModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateTrainCourseOfflineModel : AlipayObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 支付宝内部课程id
        /// </summary>
        [JsonPropertyName("course_id")]
        public string CourseId { get; set; }
    }
}
