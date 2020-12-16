using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProtocolPreviewVO Data Structure.
    /// </summary>
    public class ProtocolPreviewVO : AlipayObject
    {
        /// <summary>
        /// 协议内容
        /// </summary>
        [JsonPropertyName("protocol_content")]
        public string ProtocolContent { get; set; }

        /// <summary>
        /// oss文件地址
        /// </summary>
        [JsonPropertyName("protocol_file_path")]
        public string ProtocolFilePath { get; set; }

        /// <summary>
        /// 支付宝商户协议
        /// </summary>
        [JsonPropertyName("protocol_name")]
        public string ProtocolName { get; set; }
    }
}
