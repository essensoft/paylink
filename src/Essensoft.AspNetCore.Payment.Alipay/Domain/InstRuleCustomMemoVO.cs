using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InstRuleCustomMemoVO Data Structure.
    /// </summary>
    public class InstRuleCustomMemoVO : AlipayObject
    {
        /// <summary>
        /// 备注要素
        /// </summary>
        [JsonPropertyName("element_list")]
        public List<MemoElement> ElementList { get; set; }

        /// <summary>
        /// 连接符，默认为空字符串
        /// </summary>
        [JsonPropertyName("split_str")]
        public string SplitStr { get; set; }
    }
}
