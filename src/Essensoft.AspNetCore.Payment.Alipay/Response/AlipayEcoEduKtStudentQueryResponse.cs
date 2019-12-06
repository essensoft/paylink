using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoEduKtStudentQueryResponse.
    /// </summary>
    public class AlipayEcoEduKtStudentQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 学生姓名
        /// </summary>
        [JsonPropertyName("child_name")]
        public string ChildName { get; set; }

        /// <summary>
        /// 班级名字
        /// </summary>
        [JsonPropertyName("class_name")]
        public string ClassName { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学生编号
        /// </summary>
        [JsonPropertyName("student_code")]
        public string StudentCode { get; set; }

        /// <summary>
        /// 学生身份证
        /// </summary>
        [JsonPropertyName("student_identify")]
        public string StudentIdentify { get; set; }

        /// <summary>
        /// 家长信息
        /// </summary>
        [JsonPropertyName("users")]
        public List<UserDetails> Users { get; set; }
    }
}
