using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMultimediaResourceMasstokenGetResponse.
    /// </summary>
    public class AlipayMultimediaResourceMasstokenGetResponse : AlipayResponse
    {
        /// <summary>
        /// token创建时间戳，秒
        /// </summary>
        [JsonPropertyName("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// token失效时间戳，秒
        /// </summary>
        [JsonPropertyName("dead_time")]
        public long DeadTime { get; set; }

        /// <summary>
        /// 从AFTS系统获取的token参数，用于从AFTS系统上传下载操作时的鉴权参数。示例值仅供参考，无法直接使用。
        /// </summary>
        [JsonPropertyName("mass_token")]
        public string MassToken { get; set; }
    }
}
