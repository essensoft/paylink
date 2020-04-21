using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EduStudentInfoShareResult Data Structure.
    /// </summary>
    public class EduStudentInfoShareResult : AlipayObject
    {
        /// <summary>
        /// 教育分类
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 学生详细信息
        /// </summary>
        [JsonPropertyName("student_infos")]
        public List<StudentInfo> StudentInfos { get; set; }

        /// <summary>
        /// 用户的userid
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
