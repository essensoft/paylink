using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Paragraph Data Structure.
    /// </summary>
    public class Paragraph : AlipayObject
    {
        /// <summary>
        /// 图片列表
        /// </summary>
        [JsonPropertyName("pictures")]
        public List<Picture> Pictures { get; set; }

        /// <summary>
        /// 正文介绍
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
