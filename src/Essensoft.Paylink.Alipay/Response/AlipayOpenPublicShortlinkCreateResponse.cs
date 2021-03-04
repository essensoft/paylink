using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicShortlinkCreateResponse.
    /// </summary>
    public class AlipayOpenPublicShortlinkCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 生成的带参推广短链接
        /// </summary>
        [JsonPropertyName("shortlink")]
        public string Shortlink { get; set; }
    }
}
