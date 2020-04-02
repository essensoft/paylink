using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPayCodecQrcodecacheAddModel Data Structure.
    /// </summary>
    public class AlipayPayCodecQrcodecacheAddModel : AlipayObject
    {
        /// <summary>
        /// 是否需要gzip压缩
        /// </summary>
        [JsonPropertyName("compress")]
        public bool Compress { get; set; }

        /// <summary>
        /// 批量json的键值对
        /// </summary>
        [JsonPropertyName("json")]
        public List<string> Json { get; set; }

        /// <summary>
        /// bizType_gridId
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 缓存时长，单位是秒
        /// </summary>
        [JsonPropertyName("time")]
        public long Time { get; set; }

        /// <summary>
        /// 码地址静态信息分隔符码地址静态信息
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
