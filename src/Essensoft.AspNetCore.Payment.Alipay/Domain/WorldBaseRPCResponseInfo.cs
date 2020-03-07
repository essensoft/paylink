using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WorldBaseRPCResponseInfo Data Structure.
    /// </summary>
    public class WorldBaseRPCResponseInfo : AlipayObject
    {
        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("error_indicator")]
        public WorldErrorIndicator ErrorIndicator { get; set; }

        /// <summary>
        /// 应答扩展参数
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 服务端时间(long型数据)
        /// </summary>
        [JsonPropertyName("time")]
        public long Time { get; set; }
    }
}
