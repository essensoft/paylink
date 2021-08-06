using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CertificateInfo Data Structure.
    /// </summary>
    public class CertificateInfo : AlipayObject
    {
        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonPropertyName("certificate_name")]
        public string CertificateName { get; set; }

        /// <summary>
        /// 身份证md5加密后字符串
        /// </summary>
        [JsonPropertyName("certificate_number")]
        public string CertificateNumber { get; set; }
    }
}
