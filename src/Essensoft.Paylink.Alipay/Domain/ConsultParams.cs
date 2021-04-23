using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ConsultParams Data Structure.
    /// </summary>
    public class ConsultParams : AlipayObject
    {
        /// <summary>
        /// 集团havana ID
        /// </summary>
        [JsonPropertyName("another_hid")]
        public string AnotherHid { get; set; }
    }
}
