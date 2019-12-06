using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCertCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignCertCreateModel : AlipayObject
    {
        /// <summary>
        /// 凭证批次名称
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 拓展信息
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 凭证有效次数，数值(最大为10000)
        /// </summary>
        [JsonPropertyName("valid_count")]
        public string ValidCount { get; set; }
    }
}
