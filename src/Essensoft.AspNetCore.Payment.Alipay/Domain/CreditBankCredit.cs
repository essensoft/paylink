using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditBankCredit Data Structure.
    /// </summary>
    public class CreditBankCredit : AlipayObject
    {
        /// <summary>
        /// 课程名称
        /// </summary>
        [JsonPropertyName("course_name")]
        public string CourseName { get; set; }

        /// <summary>
        /// 教育类别，枚举：成人高等教育（30），普通高等教育（31）
        /// </summary>
        [JsonPropertyName("course_property")]
        public long CourseProperty { get; set; }

        /// <summary>
        /// 结果代码，枚举：（40=毕业，41=结业肄业）
        /// </summary>
        [JsonPropertyName("course_result_code")]
        public long CourseResultCode { get; set; }

        /// <summary>
        /// 成绩
        /// </summary>
        [JsonPropertyName("course_score")]
        public long CourseScore { get; set; }

        /// <summary>
        /// 毕业季代码（50=春，51=秋）
        /// </summary>
        [JsonPropertyName("course_season")]
        public long CourseSeason { get; set; }

        /// <summary>
        /// 专业名称
        /// </summary>
        [JsonPropertyName("course_subject")]
        public string CourseSubject { get; set; }

        /// <summary>
        /// 届别
        /// </summary>
        [JsonPropertyName("course_year")]
        public string CourseYear { get; set; }

        /// <summary>
        /// 学分
        /// </summary>
        [JsonPropertyName("credit")]
        public long Credit { get; set; }

        /// <summary>
        /// 学时
        /// </summary>
        [JsonPropertyName("credit_hour")]
        public long CreditHour { get; set; }

        /// <summary>
        /// 获得成绩id
        /// </summary>
        [JsonPropertyName("credit_outer_id")]
        public string CreditOuterId { get; set; }

        /// <summary>
        /// 获取时间，格式yyyy-mm-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("experience_time")]
        public string ExperienceTime { get; set; }

        /// <summary>
        /// 办学机构
        /// </summary>
        [JsonPropertyName("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 教育层次，枚举：本科（20），专科（21）
        /// </summary>
        [JsonPropertyName("learning_stage")]
        public long LearningStage { get; set; }
    }
}
