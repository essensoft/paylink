using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Insured Data Structure.
    /// </summary>
    public class Insured : AlipayObject
    {
        /// <summary>
        /// 姓名，须与证件上名称一致
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 被保人证件号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，  枚举：  IDENTITY_CARD：身份证  备注：目前仅支持身份证类型
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
