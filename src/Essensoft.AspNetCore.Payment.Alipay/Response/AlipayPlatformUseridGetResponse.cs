using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPlatformUseridGetResponse.
    /// </summary>
    public class AlipayPlatformUseridGetResponse : AlipayResponse
    {
        /// <summary>
        /// id字典，key为openId，value为userId
        /// </summary>
        [JsonProperty("dict")]
        public string Dict { get; set; }
    }
}
