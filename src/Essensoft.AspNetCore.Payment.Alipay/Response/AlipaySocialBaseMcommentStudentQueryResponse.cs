using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseMcommentStudentQueryResponse.
    /// </summary>
    public class AlipaySocialBaseMcommentStudentQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 大学编码
        /// </summary>
        [JsonPropertyName("campus_code")]
        public string CampusCode { get; set; }

        /// <summary>
        /// 大学名称
        /// </summary>
        [JsonPropertyName("campus_name")]
        public string CampusName { get; set; }

        /// <summary>
        /// 学历
        /// </summary>
        [JsonPropertyName("degree")]
        public string Degree { get; set; }

        /// <summary>
        /// 入学年份
        /// </summary>
        [JsonPropertyName("enrollment_time")]
        public string EnrollmentTime { get; set; }

        /// <summary>
        /// 毕业时间
        /// </summary>
        [JsonPropertyName("graduation_time")]
        public string GraduationTime { get; set; }

        /// <summary>
        /// 省份编码 引用方无需处理
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 外网无需处理此字段
        /// </summary>
        [JsonPropertyName("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// UNKNOWN(0, "未认证"),      UNDERGRADUATE(1, "在校生"),      GRADUATED(2, "毕业生"),      OFFICAL(3, "官方"),          UNIVERSITY(4, "学校"),      NEWBORN(6, "新生"),      EXPIRATION(7, "认证失效")
        /// </summary>
        [JsonPropertyName("status_enum")]
        public string StatusEnum { get; set; }

        /// <summary>
        /// 用户userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
