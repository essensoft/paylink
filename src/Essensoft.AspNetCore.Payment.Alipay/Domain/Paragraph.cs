using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Paragraph Data Structure.
    /// </summary>
    [Serializable]
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
