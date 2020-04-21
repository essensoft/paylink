using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozIdentificationCustomerBlacklistQueryModel Data Structure.
    /// </summary>
    public class ZolozIdentificationCustomerBlacklistQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备指纹
        /// </summary>
        [JsonPropertyName("apdid")]
        public string Apdid { get; set; }

        /// <summary>
        /// 设备指纹token
        /// </summary>
        [JsonPropertyName("apdid_token")]
        public string ApdidToken { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 淘宝无线安全设备标识
        /// </summary>
        [JsonPropertyName("umid")]
        public string Umid { get; set; }
    }
}
