using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExerciseCourseOpenModel Data Structure.
    /// </summary>
    public class ExerciseCourseOpenModel : AlipayObject
    {
        /// <summary>
        /// 课程类型：团课(CLASS),私教(PRIVATE_LESSON)
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 上课教室名
        /// </summary>
        [JsonPropertyName("classroom")]
        public string Classroom { get; set; }

        /// <summary>
        /// 课程详情链接（订单链接）
        /// </summary>
        [JsonPropertyName("course_detail_url")]
        public string CourseDetailUrl { get; set; }

        /// <summary>
        /// 教练的手艺人ID
        /// </summary>
        [JsonPropertyName("craftsman_id")]
        public string CraftsmanId { get; set; }

        /// <summary>
        /// 教练昵称
        /// </summary>
        [JsonPropertyName("craftsman_name")]
        public string CraftsmanName { get; set; }

        /// <summary>
        /// 教练头衔
        /// </summary>
        [JsonPropertyName("craftsman_title")]
        public string CraftsmanTitle { get; set; }

        /// <summary>
        /// 课程结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 外部课程ID。课程记录在ISV系统中的ID
        /// </summary>
        [JsonPropertyName("external_course_id")]
        public string ExternalCourseId { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 来源类型。默认SIGN_UP。枚举：报名（SIGN_UP）,推荐（RECOMMEND）
        /// </summary>
        [JsonPropertyName("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 课程开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
