using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthUnifygwtestQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthUnifygwtestQueryModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("str")]
        public string Str { get; set; }
    }
}
