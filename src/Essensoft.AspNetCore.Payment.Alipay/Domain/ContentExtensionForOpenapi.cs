using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContentExtensionForOpenapi Data Structure.
    /// </summary>
    public class ContentExtensionForOpenapi : AlipayObject
    {
        /// <summary>
        /// 扩展信息正文,新建内容的扩展信息存入这个字段。
        /// </summary>
        [JsonPropertyName("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 扩展类型,新建内容的扩展类型。RICH_TEXT，代表富文本。
        /// </summary>
        [JsonPropertyName("extension_type")]
        public string ExtensionType { get; set; }
    }
}
