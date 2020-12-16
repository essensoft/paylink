using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateEInfoMoreDTO Data Structure.
    /// </summary>
    public class TemplateEInfoMoreDTO : AlipayObject
    {
        /// <summary>
        /// 标题文案，支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 跳转链接，需要带上http、https、alipays等协议头，支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
