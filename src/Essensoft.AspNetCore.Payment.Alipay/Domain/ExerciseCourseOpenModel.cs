using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExerciseCourseOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class ExerciseCourseOpenModel : AlipayObject
    {
        /// <summary>
        /// 课程类型：团课(CLASS),私教(PRIVATE_LESSON)
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 上课教室名
        /// </summary>
        [JsonProperty("classroom")]
        public string Classroom { get; set; }

        /// <summary>
        /// 课程详情链接（订单链接）
        /// </summary>
        [JsonProperty("course_detail_url")]
        public string CourseDetailUrl { get; set; }

        /// <summary>
        /// 教练的手艺人ID
        /// </summary>
        [JsonProperty("craftsman_id")]
        public string CraftsmanId { get; set; }

        /// <summary>
        /// 教练昵称
        /// </summary>
        [JsonProperty("craftsman_name")]
        public string CraftsmanName { get; set; }

        /// <summary>
        /// 教练头衔
        /// </summary>
        [JsonProperty("craftsman_title")]
        public string CraftsmanTitle { get; set; }

        /// <summary>
        /// 课程结束时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 外部课程ID。课程记录在ISV系统中的ID
        /// </summary>
        [JsonProperty("external_course_id")]
        public string ExternalCourseId { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 来源类型。默认SIGN_UP。枚举：报名（SIGN_UP）,推荐（RECOMMEND）
        /// </summary>
        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 课程开始时间
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
    }
}
