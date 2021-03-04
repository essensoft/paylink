using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// XwbTestData Data Structure.
    /// </summary>
    public class XwbTestData : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("s")]
        public string S { get; set; }
    }
}
