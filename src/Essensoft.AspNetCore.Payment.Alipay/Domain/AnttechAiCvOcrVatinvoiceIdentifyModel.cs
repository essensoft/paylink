using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechAiCvOcrVatinvoiceIdentifyModel Data Structure.
    /// </summary>
    public class AnttechAiCvOcrVatinvoiceIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 目前只支持pdf、jpg两种file_type的识别能力，根据具体传入的发票的格式传入正确的值
        /// </summary>
        [JsonPropertyName("file_type")]
        public string FileType { get; set; }

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
