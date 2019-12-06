using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtCategory Data Structure.
    /// </summary>
    public class ExtCategory : AlipayObject
    {
        /// <summary>
        /// 品类编码
        /// </summary>
        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 品类名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父品类编码。顶级类目此值为0
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string ParentId { get; set; }
    }
}
