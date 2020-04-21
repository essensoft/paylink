using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieSpaceDomains Data Structure.
    /// </summary>
    public class FengdieSpaceDomains : AlipayObject
    {
        /// <summary>
        /// 发布的域名，在云凤蝶上创建的站点发布时采用的 url 域名
        /// </summary>
        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 是否是当前云凤蝶空间的默认发布域名，Y 则表示该空间下的站点默认以此域名生成站点url
        /// </summary>
        [JsonPropertyName("is_default")]
        public string IsDefault { get; set; }

        /// <summary>
        /// 当前域名状态，是否可用，值为 OPEN 或 DISCARDED
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
