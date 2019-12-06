using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// YcsPri Data Structure.
    /// </summary>
    public class YcsPri : AlipayObject
    {
        /// <summary>
        /// aaa
        /// </summary>
        [JsonPropertyName("a")]
        public string A { get; set; }

        /// <summary>
        /// 支持输入标准html超链接：<a href="url" target="_blank">Link text</a>例如：<a href="https://open.alipay.com" target="_blank">蚂蚁开放平台</a>
        /// </summary>
        [JsonPropertyName("b")]
        public string B { get; set; }
    }
}
