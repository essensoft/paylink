using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditBankCertificateExperience Data Structure.
    /// </summary>
    public class CreditBankCertificateExperience : AlipayObject
    {
        /// <summary>
        /// 获得证书id
        /// </summary>
        [JsonPropertyName("cert_exp_outer_id")]
        public string CertExpOuterId { get; set; }

        /// <summary>
        /// 证书等级
        /// </summary>
        [JsonPropertyName("certificate_level")]
        public string CertificateLevel { get; set; }

        /// <summary>
        /// 证书名称
        /// </summary>
        [JsonPropertyName("certificate_name")]
        public string CertificateName { get; set; }

        /// <summary>
        /// 获取时间，格式yyyy-mm-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("experience_time")]
        public string ExperienceTime { get; set; }

        /// <summary>
        /// 办学机构
        /// </summary>
        [JsonPropertyName("inst_name")]
        public string InstName { get; set; }
    }
}
