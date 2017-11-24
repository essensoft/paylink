using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// EduStudentInfoShareResult Data Structure.
    /// </summary>
    public class EduStudentInfoShareResult : AlipayObject
    {
        /// <summary>
        /// 教育分类
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 学生详细信息
        /// </summary>
        [JsonProperty("student_infos")]
        public List<StudentInfo> StudentInfos { get; set; }

        /// <summary>
        /// 用户的userid
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
