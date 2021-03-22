using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ParamInfo Data Structure.
    /// </summary>
    public class ParamInfo : AlipayObject
    {
        /// <summary>
        /// 参数名
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
