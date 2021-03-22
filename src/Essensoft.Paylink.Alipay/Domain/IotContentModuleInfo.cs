using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// IotContentModuleInfo Data Structure.
    /// </summary>
    public class IotContentModuleInfo : AlipayObject
    {
        /// <summary>
        /// 对展位内容加签，用于校验内容合法性
        /// </summary>
        [JsonPropertyName("content_sign")]
        public string ContentSign { get; set; }

        /// <summary>
        /// 展位详情加密后返回数据
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 权益标识
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 展位类型，如BusinessOperation，CdpOperation
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// H5页面链接地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
