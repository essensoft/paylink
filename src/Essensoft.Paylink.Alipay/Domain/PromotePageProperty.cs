using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PromotePageProperty Data Structure.
    /// </summary>
    public class PromotePageProperty : AlipayObject
    {
        /// <summary>
        /// 留资属性key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 留资属性名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
