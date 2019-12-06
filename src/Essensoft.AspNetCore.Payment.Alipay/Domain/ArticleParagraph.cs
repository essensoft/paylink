using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArticleParagraph Data Structure.
    /// </summary>
    public class ArticleParagraph : AlipayObject
    {
        /// <summary>
        /// 图片列表
        /// </summary>
        [JsonPropertyName("pictures")]
        public List<ArticlePicture> Pictures { get; set; }

        /// <summary>
        /// 文章正文描述
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
