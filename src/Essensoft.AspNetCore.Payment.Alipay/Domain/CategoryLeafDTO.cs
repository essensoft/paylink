using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CategoryLeafDTO Data Structure.
    /// </summary>
    public class CategoryLeafDTO : AlipayObject
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
