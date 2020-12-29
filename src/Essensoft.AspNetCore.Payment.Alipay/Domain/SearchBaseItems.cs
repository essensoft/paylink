using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SearchBaseItems Data Structure.
    /// </summary>
    public class SearchBaseItems : AlipayObject
    {
        /// <summary>
        /// 搜索可见性
        /// </summary>
        [JsonPropertyName("can_search")]
        public bool CanSearch { get; set; }

        /// <summary>
        /// 提报关键词列表
        /// </summary>
        [JsonPropertyName("key_words")]
        public List<string> KeyWords { get; set; }
    }
}
