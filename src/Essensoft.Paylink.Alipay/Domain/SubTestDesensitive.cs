using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SubTestDesensitive Data Structure.
    /// </summary>
    public class SubTestDesensitive : AlipayObject
    {
        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 邮箱列表
        /// </summary>
        [JsonPropertyName("email_list")]
        public List<string> EmailList { get; set; }

        /// <summary>
        /// 是否是学生
        /// </summary>
        [JsonPropertyName("is_student")]
        public string IsStudent { get; set; }

        /// <summary>
        /// ["T","T","T"]
        /// </summary>
        [JsonPropertyName("is_student_list")]
        public List<string> IsStudentList { get; set; }

        /// <summary>
        /// 1200
        /// </summary>
        [JsonPropertyName("school")]
        public string School { get; set; }
    }
}
