using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoEduCampusJobstudentApplyResponse.
    /// </summary>
    public class AlipayEcoEduCampusJobstudentApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 备注问题或异常
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 备用字段，JSON格式
        /// </summary>
        [JsonPropertyName("content_var")]
        public string ContentVar { get; set; }

        /// <summary>
        /// 学历
        /// </summary>
        [JsonPropertyName("degree")]
        public string Degree { get; set; }

        /// <summary>
        /// 状态码描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 学生入学时间
        /// </summary>
        [JsonPropertyName("enrollment_time")]
        public string EnrollmentTime { get; set; }

        /// <summary>
        /// 是否毕业（1-已毕业；2-未毕业）
        /// </summary>
        [JsonPropertyName("is_graduate")]
        public long IsGraduate { get; set; }

        /// <summary>
        /// 学生是否在趣校园平台认证(1-认证；2-未认证)
        /// </summary>
        [JsonPropertyName("is_student")]
        public long IsStudent { get; set; }

        /// <summary>
        /// 返回code编码;成功返回Success
        /// </summary>
        [JsonPropertyName("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 学生所在学校
        /// </summary>
        [JsonPropertyName("school")]
        public string School { get; set; }
    }
}
