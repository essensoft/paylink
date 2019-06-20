using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertifyStudentinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertifyStudentinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 教育层次
        /// </summary>
        [JsonProperty("education_level")]
        public string EducationLevel { get; set; }

        /// <summary>
        /// 入学日期
        /// </summary>
        [JsonProperty("entry_date")]
        public string EntryDate { get; set; }

        /// <summary>
        /// 预期毕业日期
        /// </summary>
        [JsonProperty("graduation_date")]
        public string GraduationDate { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonProperty("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
