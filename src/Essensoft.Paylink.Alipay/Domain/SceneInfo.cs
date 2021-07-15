using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SceneInfo Data Structure.
    /// </summary>
    public class SceneInfo : AlipayObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonPropertyName("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 企业名
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 是否雇主（企业）访问
        /// </summary>
        [JsonPropertyName("employer_visit")]
        public string EmployerVisit { get; set; }

        /// <summary>
        /// 所属类目（最终归属的行业）
        /// </summary>
        [JsonPropertyName("job_category")]
        public string JobCategory { get; set; }

        /// <summary>
        /// 岗位所属类目及ID
        /// </summary>
        [JsonPropertyName("job_category_id")]
        public string JobCategoryId { get; set; }

        /// <summary>
        /// 岗位ID
        /// </summary>
        [JsonPropertyName("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 岗位名称
        /// </summary>
        [JsonPropertyName("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 发生时间的时间戳
        /// </summary>
        [JsonPropertyName("scene_time")]
        public string SceneTime { get; set; }

        /// <summary>
        /// 是否自己访问
        /// </summary>
        [JsonPropertyName("self_visit")]
        public string SelfVisit { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
