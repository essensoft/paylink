using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Informant Data Structure.
    /// </summary>
    public class Informant : AlipayObject
    {
        /// <summary>
        /// 姓名，须与证件上名称一致
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 报案人证件号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，特殊可选，该字段需和证件号、名称同时有值或同时为空  枚举：  IDENTITY_CARD：身份证    备注：目前仅支持身份证类型
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonPropertyName("mobile_no")]
        public string MobileNo { get; set; }
    }
}
