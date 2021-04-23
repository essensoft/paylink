using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceSchemaQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppServiceSchemaQueryModel : AlipayObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }
    }
}
