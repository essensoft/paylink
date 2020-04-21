using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignRetailDmSetResponse.
    /// </summary>
    public class KoubeiMarketingCampaignRetailDmSetResponse : AlipayResponse
    {
        /// <summary>
        /// 内容ID
        /// </summary>
        [JsonPropertyName("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }
    }
}
