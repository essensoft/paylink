using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataItemDescription Data Structure.
    /// </summary>
    public class AlipayDataItemDescription : AlipayObject
    {
        /// <summary>
        /// 标题下的描述列表
        /// </summary>
        [JsonPropertyName("details")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 明细图片列表
        /// </summary>
        [JsonPropertyName("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 描述标题，不得超过15个中文字符
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 套餐使用说明链接，必须是https的地址链接
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
