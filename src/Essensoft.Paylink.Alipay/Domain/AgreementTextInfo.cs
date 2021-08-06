using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AgreementTextInfo Data Structure.
    /// </summary>
    public class AgreementTextInfo : AlipayObject
    {
        /// <summary>
        /// 协议文本名称
        /// </summary>
        [JsonPropertyName("agreement_text_title")]
        public string AgreementTextTitle { get; set; }

        /// <summary>
        /// 协议文本对应的url
        /// </summary>
        [JsonPropertyName("agreement_text_url")]
        public string AgreementTextUrl { get; set; }
    }
}
