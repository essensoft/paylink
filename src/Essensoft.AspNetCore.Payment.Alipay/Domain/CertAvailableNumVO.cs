using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CertAvailableNumVO Data Structure.
    /// </summary>
    public class CertAvailableNumVO : AlipayObject
    {
        /// <summary>
        /// 凭证可用点数。
        /// </summary>
        [JsonPropertyName("available_num")]
        public long AvailableNum { get; set; }

        /// <summary>
        /// 凭证模板ID。
        /// </summary>
        [JsonPropertyName("cert_template_id")]
        public string CertTemplateId { get; set; }
    }
}
