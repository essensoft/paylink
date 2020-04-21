using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StudentInfo Data Structure.
    /// </summary>
    public class StudentInfo : AlipayObject
    {
        /// <summary>
        /// 学校所在行政区域编码
        /// </summary>
        [JsonPropertyName("city_no")]
        public string CityNo { get; set; }

        /// <summary>
        /// 班级
        /// </summary>
        [JsonPropertyName("class_name")]
        public string ClassName { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonPropertyName("college_name")]
        public string CollegeName { get; set; }

        /// <summary>
        /// 学校机构编号
        /// </summary>
        [JsonPropertyName("college_no")]
        public string CollegeNo { get; set; }

        /// <summary>
        /// 学历
        /// </summary>
        [JsonPropertyName("degree")]
        public string Degree { get; set; }

        /// <summary>
        /// 院系
        /// </summary>
        [JsonPropertyName("departments")]
        public string Departments { get; set; }

        /// <summary>
        /// 入校时间
        /// </summary>
        [JsonPropertyName("gmt_enrollment")]
        public string GmtEnrollment { get; set; }

        /// <summary>
        /// 毕业时间
        /// </summary>
        [JsonPropertyName("gmt_graduation")]
        public string GmtGraduation { get; set; }

        /// <summary>
        /// 专业
        /// </summary>
        [JsonPropertyName("major")]
        public string Major { get; set; }

        /// <summary>
        /// 学生证号
        /// </summary>
        [JsonPropertyName("student_id")]
        public string StudentId { get; set; }
    }
}
