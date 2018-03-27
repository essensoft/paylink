using Newtonsoft.Json;

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
        [JsonProperty("crowd_id")]
        public string CrowdId { get; set; }
    }
}
