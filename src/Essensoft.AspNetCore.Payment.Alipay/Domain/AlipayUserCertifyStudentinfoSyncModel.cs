using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertifyStudentinfoSyncModel Data Structure.
    /// </summary>
    public class AlipayUserCertifyStudentinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 教育层次
        /// </summary>
        [JsonPropertyName("education_level")]
        public string EducationLevel { get; set; }

        /// <summary>
        /// 入学日期
        /// </summary>
        [JsonPropertyName("entry_date")]
        public string EntryDate { get; set; }

        /// <summary>
        /// 预期毕业日期
        /// </summary>
        [JsonPropertyName("graduation_date")]
        public string GraduationDate { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
