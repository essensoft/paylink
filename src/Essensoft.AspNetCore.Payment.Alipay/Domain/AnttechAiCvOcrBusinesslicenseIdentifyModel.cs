using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechAiCvOcrBusinesslicenseIdentifyModel Data Structure.
    /// </summary>
    public class AnttechAiCvOcrBusinesslicenseIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 文件二进制内容 + base64
        /// </summary>
        [JsonPropertyName("image_raw")]
        public string ImageRaw { get; set; }

        /// <summary>
        /// 图片下载url
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 服务调用来源(需要咨询服务提供方)
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 单次调用唯一标示，用于异常问题排查，调用方需要负责生成并且记录在调用日志里
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
