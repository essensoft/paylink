using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SearchServiceItems Data Structure.
    /// </summary>
    public class SearchServiceItems : AlipayObject
    {
        /// <summary>
        /// 申请单状态
        /// </summary>
        [JsonPropertyName("box_status")]
        public string BoxStatus { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [JsonPropertyName("category_codes")]
        public List<string> CategoryCodes { get; set; }

        /// <summary>
        /// 服务申请单提报关键词
        /// </summary>
        [JsonPropertyName("key_words")]
        public List<string> KeyWords { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
