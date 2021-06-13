using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherCreateResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }
    }
}
