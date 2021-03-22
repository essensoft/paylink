using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniCategoryRequireQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniCategoryRequireQueryModel : AlipayObject
    {
        /// <summary>
        /// 类目列表，不超过五个
        /// </summary>
        [JsonPropertyName("category_code_list")]
        public List<string> CategoryCodeList { get; set; }
    }
}
