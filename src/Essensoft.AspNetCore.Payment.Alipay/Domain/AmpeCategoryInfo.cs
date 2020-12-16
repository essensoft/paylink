using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AmpeCategoryInfo Data Structure.
    /// </summary>
    public class AmpeCategoryInfo : AlipayObject
    {
        /// <summary>
        /// 行业描述
        /// </summary>
        [JsonPropertyName("category_desc")]
        public string CategoryDesc { get; set; }

        /// <summary>
        /// 行业id
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }
    }
}
