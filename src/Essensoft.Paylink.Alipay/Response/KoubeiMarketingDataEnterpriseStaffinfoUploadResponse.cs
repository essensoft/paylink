using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
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
