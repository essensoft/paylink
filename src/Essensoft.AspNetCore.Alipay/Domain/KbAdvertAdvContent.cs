using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KbAdvertAdvContent Data Structure.
    /// </summary>
    public class KbAdvertAdvContent : AlipayObject
    {
        /// <summary>
        /// 二维码
        /// </summary>
        [JsonProperty("codec")]
        public string Codec { get; set; }

        /// <summary>
        /// 访问地址
        /// </summary>
        [JsonProperty("link_url")]
        public string LinkUrl { get; set; }
    }
}
