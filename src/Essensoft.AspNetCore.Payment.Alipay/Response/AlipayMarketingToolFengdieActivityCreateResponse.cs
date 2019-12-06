using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieActivityCreateResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieActivityCreateResponse : AlipayResponse
    {
        /// <summary>
        /// H5应用的唯一id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public long ActivityId { get; set; }
    }
}
