using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// StudentCertificate Data Structure.
    /// </summary>
    public class StudentCertificate : AlipayObject
    {
        /// <summary>
        /// 证书大分类
        /// </summary>
        [JsonPropertyName("cert_category")]
        public string CertCategory { get; set; }

        /// <summary>
        /// 证书头编码
        /// </summary>
        [JsonPropertyName("cert_code")]
        public string CertCode { get; set; }

        /// <summary>
        /// 证书名称
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 外部证书编码
        /// </summary>
        [JsonPropertyName("cert_num")]
        public string CertNum { get; set; }

        /// <summary>
        /// 证书类型
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 证书描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 证书有效期开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 证书图片地址，oss永久地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// 证书图片类型，pdf、png、jpg
        /// </summary>
        [JsonPropertyName("url_type")]
        public string UrlType { get; set; }
    }
}
