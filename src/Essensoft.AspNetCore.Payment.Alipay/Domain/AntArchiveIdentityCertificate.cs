using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntArchiveIdentityCertificate Data Structure.
    /// </summary>
    public class AntArchiveIdentityCertificate : AlipayObject
    {
        /// <summary>
        /// 证件名
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 蚂蚁档案证件类型    个人类型取值范围：  100 居民身份证  102 护照  105 港澳居民往来内地通行证  106 台湾居民往来内地通行证    企业和组织类型取值范围：  200 统一社会信用代码  201 全国法人营业执照  204 民办非企业登记证书  206 社会团体法人登记证书  218 事业单位法人证书
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }
    }
}
