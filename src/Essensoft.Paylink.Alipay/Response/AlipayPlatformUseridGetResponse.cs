using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayPlatformUseridGetResponse.
    /// </summary>
    public class AlipayPlatformUseridGetResponse : AlipayResponse
    {
        /// <summary>
        /// id字典，key为openId，value为userId
        /// </summary>
        [JsonPropertyName("dict")]
        public string Dict { get; set; }
    }
}
