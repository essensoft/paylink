using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OfflinepayBaseRPCResponseInfo Data Structure.
    /// </summary>
    public class OfflinepayBaseRPCResponseInfo : AlipayObject
    {
        /// <summary>
        /// 错误指示器
        /// </summary>
        [JsonPropertyName("error_indicator")]
        public OfflinepayErrorIndicator ErrorIndicator { get; set; }

        /// <summary>
        /// 应答扩展参数
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }

        /// <summary>
        /// 服务端时间
        /// </summary>
        [JsonPropertyName("time")]
        public long Time { get; set; }
    }
}
