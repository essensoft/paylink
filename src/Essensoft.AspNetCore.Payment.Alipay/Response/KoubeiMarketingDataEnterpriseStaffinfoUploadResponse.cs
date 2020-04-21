using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataEnterpriseStaffinfoUploadResponse.
    /// </summary>
    public class KoubeiMarketingDataEnterpriseStaffinfoUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 人群ID
        /// </summary>
        [JsonPropertyName("crowd_id")]
        public string CrowdId { get; set; }
    }
}
