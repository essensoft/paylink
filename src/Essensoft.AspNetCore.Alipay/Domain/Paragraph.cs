using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// Paragraph Data Structure.
    /// </summary>
    public class Paragraph : AlipayObject
    {
        /// <summary>
        /// 图片列表
        /// </summary>
        [JsonProperty("pictures")]
        public List<Picture> Pictures { get; set; }

        /// <summary>
        /// 正文介绍
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
