using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CertInfoRequest Data Structure.
    /// </summary>
    public class CertInfoRequest : AlipayObject
    {
        /// <summary>
        /// 用户证件名称MD5值。  示例中的md5值对应明文为：张三
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 用户证件号码md5值。 示例中的md5值对应明文为：330120198409141587
        /// </summary>
        [JsonPropertyName("cert_number")]
        public string CertNumber { get; set; }

        /// <summary>
        /// 表示证件类型，目前仅支持以下类型：  01 - 身份证
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }
    }
}
