using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieActivityCreateResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieActivityCreateResponse : AlipayResponse
    {
        /// <summary>
        /// H5应用的唯一id
        /// </summary>
        [JsonProperty("activity_id")]
        public long ActivityId { get; set; }
    }
}
