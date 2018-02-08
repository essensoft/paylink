using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicMessageContentCreateResponse.
    /// </summary>
    public class AlipayOpenPublicMessageContentCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 内容id
        /// </summary>
        [JsonProperty("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 内容详情内链url
        /// </summary>
        [JsonProperty("content_url")]
        public string ContentUrl { get; set; }
    }
}
